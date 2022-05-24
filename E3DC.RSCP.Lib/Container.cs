using System.Collections;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;

namespace E3DC.RSCP.Lib
{
    /// <summary>
    /// Main parse, write and data holding class
    /// </summary>
    public class Container : IEnumerable
    {
        /// <summary>
        /// Byte Mask for extracting the SubTag from tag data
        /// </summary>
        public const uint SUB_TAG_MASK = 0x007fffff;

        /// <summary>
        /// List for container items
        /// </summary>
        private readonly Dictionary<Enum, object?> items = new();

        /// <summary>
        /// contains list of all Tag group enums
        /// </summary>
        private static readonly Dictionary<uint, Type> tagGroups = new();

        /// <summary>
        /// static contructor to initialize list of tag groups
        /// </summary>
        static Container()
        {
            foreach (Type type in typeof(Tags.TagGroupAttribute).Assembly.GetTypes())
            {
                Tags.TagGroupAttribute? tagInfo = type.GetCustomAttribute<Tags.TagGroupAttribute>();
                if (tagInfo == null || Enum.GetUnderlyingType(type) != typeof(uint))
                {
                    continue;
                }
                tagGroups.Add(tagInfo.Group, type);
            }
        }

        #region Item getter / setter
        /// <summary>
        /// indexer can be used for array access the containing items 
        /// </summary>
        /// <param name="tag">RSCP Tag Enum with TagGroupAttribute</param>
        /// <returns>Element from list</returns>
        public object? this[Enum tag]
        {
            get
            {
                if (items.ContainsKey(tag))
                {
                    return items[tag];
                }
                return null;
            }
            set
            {
                // prevent adding unknown enum types
                GetTagFromEnum(tag);
                if (items.ContainsKey(tag))
                {
                    items[tag] = value;
                }
                else
                {
                    items.Add(tag, value);
                }
            }
        }

        /// <summary>
        /// Value adder for adding request tag data
        /// </summary>
        /// <typeparam name="T">Tag Enum Type</typeparam>
        /// <typeparam name="TData">Value Type</typeparam>
        /// <param name="Tag">Tag</param>
        /// <param name="Value">Value data</param>
        public void Add<T, TData>(T Tag, TData Value) where T : Enum
        {
            // prevent adding unknown enum types
            GetDataTypeFromValue(Value);
            if (items.ContainsKey(Tag))
            {
                if (items[Tag] is IList)
                {
                    (items[Tag] as IList)?.Add(Value);
                }
                else
                {
                    items[Tag] = new List<object?>()
                    {
                        items[Tag],
                        Value
                    };
                }
            }
            else
            {
                items.Add(Tag, Value);
            }
        }

        /// <summary>
        /// adding multiple items
        /// </summary>
        /// <param name="collection">enumerator</param>
        public void AddRange(IEnumerator<KeyValuePair<Enum, object?>>? enumerator)
        {
            if (enumerator == null)
            {
                return;
            }
            while (enumerator.MoveNext())
            {
                Add(enumerator.Current.Key, enumerator.Current.Value);
            }
        }

        /// <summary>
        /// Returns value from item list
        /// </summary>
        /// <typeparam name="T">Tag Enum Type</typeparam>
        /// <typeparam name="TData">Value Type</typeparam>
        /// <param name="Tag">Tag</param>
        /// <returns>Value, if not exists it returns null</returns>
        public TData? Get<T, TData>(T Tag) where T : Enum
        {
            if (items.ContainsKey(Tag) && items[Tag] is TData)
            {
                return (TData?)items[Tag];
            }
            return default;
        }

        /// <summary>
        /// Returns value from item list
        /// </summary>
        /// <typeparam name="TData">Value Type</typeparam>
        /// <param name="Tag">Tag</param>
        /// <returns>Value, if not exists it returns null</returns>
        public TData? Get<TData>(Enum Tag)
        {
            if (items.ContainsKey(Tag) && items[Tag] is TData)
            {
                return (TData?)items[Tag];
            }
            return default;
        }

        /// <summary>
        /// Removes a value from item list
        /// </summary>
        /// <typeparam name="T">Tag Enum Type</typeparam>
        /// <param name="Tag">Tag</param>
        public void Remove<T>(T Tag) where T : Enum
        {
            if (items.ContainsKey(Tag))
            {
                items.Remove(Tag);
            }
        }

        /// <summary>
        /// checks tag existence
        /// </summary>
        /// <param name="Tag">Tag</param>
        /// <returns>true if tag exists</returns>
        public bool Contains(Enum Tag)
        {
            return items.ContainsKey(Tag);
        }

        /// <summary>
        /// Item enumerator
        /// </summary>
        /// <returns>kvp</returns>
        public IEnumerator<KeyValuePair<Enum, object?>> GetEnumerator()
        {
            foreach (KeyValuePair<Enum, object?> p in items)
            {
                yield return p;
            }
        }

        /// <summary>
        /// Item enumerator
        /// </summary>
        /// <returns>enum</returns>
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        #endregion

        #region byte writer
        /// <summary>
        /// calucates and returns the size of the container data
        /// </summary>
        public ushort Size
        {
            get
            {
                ushort result = 0;

                foreach (Enum key in items.Keys)
                {
                    if (items[key] is List<object> list)
                    {
                        foreach (object item in list)
                        {
                            result += GetValueSize(GetDataTypeFromValue(item), item);
                            result += (ushort)Marshal.SizeOf<ValueHeader>();
                        }
                    }
                    else
                    {
                        result += GetValueSize(GetDataTypeFromValue(items[key]), items[key]);
                        result += (ushort)Marshal.SizeOf<ValueHeader>();
                    }
                }

                return result;
            }
        }

        /// <summary>
        /// Returns full byte content of the container
        /// </summary>
        /// <returns>array of bytes</returns>
        public byte[] GetBytes()
        {
            using MemoryStream ms = new();
            using BinaryWriter bw = new(ms);
            foreach (Enum key in items.Keys)
            {
                if (items[key] is List<object> list)
                {
                    foreach (object item in list)
                    {
                        WriteElement(bw, key, item);
                    }
                }
                else
                {
                    WriteElement(bw, key, items[key]);
                }
            }
            return ms.ToArray();
        }

        /// <summary>
        /// writes a single element to writer
        /// </summary>
        /// <param name="bw">the writer</param>
        /// <param name="key">element key</param>
        /// <param name="item">item data</param>
        private static void WriteElement(BinaryWriter bw, Enum key, object? item)
        {
            DataType dataType = GetDataTypeFromValue(item);
            ValueHeader header = new()
            {
                Tag = GetTagFromEnum(key),
                DataType = (byte)dataType,
                Length = GetValueSize(dataType, item)
            };
            header.ToBinaryWriter(bw);
            WriteBytes(bw, dataType, item);
        }

        /// <summary>
        /// writes the bytes of the container using binary writer
        /// </summary>
        /// <param name="bw">the writer</param>
        /// <param name="dataType">type of data</param>
        /// <param name="value">data value</param>
        private static void WriteBytes(BinaryWriter bw, DataType dataType, object? value)
        {
            if (value == null)
            {
                return;
            }

            switch (dataType)
            {
                case DataType.None:
                    break;
                case DataType.Bool:
                    bw.Write((bool)value);
                    break;
                case DataType.Char8:
                    bw.Write((sbyte)value);
                    break;
                case DataType.UChar8:
                    bw.Write((byte)value);
                    break;
                case DataType.Int16:
                    bw.Write((short)value);
                    break;
                case DataType.UInt16:
                    bw.Write((ushort)value);
                    break;
                case DataType.Int32:
                    bw.Write((int)value);
                    break;
                case DataType.UInt32:
                    bw.Write((uint)value);
                    break;
                case DataType.Int64:
                    bw.Write((long)value);
                    break;
                case DataType.UInt64:
                    bw.Write((ulong)value);
                    break;
                case DataType.Float32:
                    bw.Write((float)value);
                    break;
                case DataType.Double64:
                    bw.Write((double)value);
                    break;
                case DataType.Bitfield:
                    bw.Write(FromBitField((bool[])value));
                    break;
                case DataType.String:
                    bw.Write(Encoding.ASCII.GetBytes((string)value));
                    break;
                case DataType.Container:
                    bw.Write(((Container)value).GetBytes());
                    break;
                case DataType.Timestamp:
                    WriteTimeStamp(bw, (DateTime)value);
                    break;
                case DataType.ByteArray:
                    bw.Write((byte[])value);
                    break;
                case DataType.Error:
                    bw.Write((uint)value);
                    break;
            }
        }

        /// <summary>
        /// Converts bitfield to byte array
        /// </summary>
        /// <param name="bits">bit array</param>
        /// <returns>data</returns>
        protected static byte[] FromBitField(bool[] bits)
        {
            byte[] result = new byte[(int)Math.Ceiling(bits.Length / 8.0)];            
            for (int bitIndex = 0; bitIndex < bits.Length; bitIndex++)
            {
                if (bits[bitIndex])
                {
                    int byteIndex = bitIndex / 8;
                    result[byteIndex] |= (byte)(1 << (bitIndex % 8));
                }
            }
            return result;
        }

        /// <summary>
        /// writes a timestamp value
        /// </summary>
        /// <param name="bw">the writer</param>
        /// <param name="dateTime">datetime object</param>
        protected static void WriteTimeStamp(BinaryWriter bw, DateTime dateTime)
        {
            TimeSpan timeSpan = dateTime.Subtract(DateTime.UnixEpoch);
            long ticks = timeSpan.Ticks;
            bw.Write(ticks / TimeSpan.TicksPerSecond);
            bw.Write((int)(ticks % TimeSpan.TicksPerSecond) * 100);
        }
        #endregion

        #region byte reader
        /// <summary>
        /// Process bytes at converting bytes to a container
        /// </summary>
        /// <param name="length">length of data to process</param>
        /// <param name="br">Binary reader to read from</param>
        protected void ProcessBytes(int length, BinaryReader br)
        {
            int valueHeaderSize = Marshal.SizeOf<ValueHeader>();

            while (length > 0)
            {
                ValueHeader header = ValueHeader.FromBinaryReader(br);
                ReadFromBytes(header, br);
                length -= valueHeaderSize;
                length -= header.Length;
            }
        }

        /// <summary>
        /// Read value specific bytes from reader
        /// </summary>
        /// <param name="header">the value header struct</param>
        /// <param name="br">Binary reader to read from</param>
        private void ReadFromBytes(ValueHeader header, BinaryReader br)
        {
            DataType dataType = (DataType)header.DataType;
            object? value = null;

            // read data based on DataType
            switch (dataType)
            {
                case DataType.None:
                    break;
                case DataType.Bool:
                    value = br.ReadBoolean();
                    break;
                case DataType.Char8:
                    value = br.ReadSByte();
                    break;
                case DataType.UChar8:
                    value = br.ReadByte();
                    break;
                case DataType.Int16:
                    value = br.ReadInt16();
                    break;
                case DataType.UInt16:
                    value = br.ReadUInt16();
                    break;
                case DataType.Int32:
                    value = br.ReadInt32();
                    break;
                case DataType.UInt32:
                    value = br.ReadUInt32();
                    break;
                case DataType.Int64:
                    value = br.ReadInt64();
                    break;
                case DataType.UInt64:
                    value = br.ReadUInt64();
                    break;
                case DataType.Float32:
                    value = br.ReadSingle();
                    break;
                case DataType.Double64:
                    value = br.ReadDouble();
                    break;
                case DataType.Bitfield:
                    value = ToBitField(br.ReadBytes(header.Length));
                    break;
                case DataType.String:
                    value = Encoding.ASCII.GetString(br.ReadBytes(header.Length));
                    break;
                case DataType.Container:
                    value = new Container();
                    (value as Container)!.ProcessBytes(header.Length, br);
                    break;
                case DataType.Timestamp:
                    value = ReadTimeStamp(br);
                    break;
                case DataType.ByteArray:
                    value = br.ReadBytes(header.Length);
                    break;
                case DataType.Error:
                    value = br.ReadUInt32();
                    if (Enum.IsDefined(typeof(ErrorCode), value))
                    {
                        value = (ErrorCode)value;
                    }
                    break;
            }

            // split tag group and Subtag, ignore response bit
            uint tagGroup = header.Tag >> 24 & 0xff;
            uint subTag = header.Tag & SUB_TAG_MASK;

            if (tagGroups.ContainsKey(tagGroup))
            {
                Enum group = (Enum)Enum.ToObject(tagGroups[tagGroup], subTag);
                Add(group, value);
            }
        }

        /// <summary>
        /// Converts byte array to bit field
        /// </summary>
        /// <param name="data">input bytes</param>
        /// <returns>bit array</returns>
        protected static bool[] ToBitField(byte[] data)
        {
            bool[] result = new bool[data.Length * 8];
            for (int byteIndex = 0; byteIndex < data.Length; byteIndex++)
            {
                for (int bitIndex = 0; bitIndex < 8; bitIndex++)
                {
                    result[(byteIndex * 8) + bitIndex] = (data[byteIndex] & (1 << bitIndex)) != 0;
                }

            }
            return result;
        }

        /// <summary>
        /// reads timestamp
        /// </summary>
        /// <param name="br">the reader</param>
        /// <returns>DateTime object</returns>
        protected static DateTime ReadTimeStamp(BinaryReader br)
        {
            long seconds = br.ReadInt64();
            int nanoseconds = br.ReadInt32();
            long ticks = (seconds * TimeSpan.TicksPerSecond) + (nanoseconds / 100);
            return DateTime.UnixEpoch.Add(TimeSpan.FromTicks(ticks));
        }
        #endregion

        /// <summary>
        /// returns the size of the data value
        /// </summary>
        /// <param name="dataType">Data Type</param>
        /// <param name="value">value data</param>
        /// <returns>size</returns>
        /// <exception cref="ArgumentException">on unknown data type</exception>
        private static ushort GetValueSize(DataType dataType, object? value)
        {
            if (value == null)
            {
                return 0;
            }
            return dataType switch
            {
                DataType.Bool => sizeof(bool),
                DataType.Char8 => sizeof(sbyte),
                DataType.UChar8 => sizeof(byte),
                DataType.Int16 => sizeof(short),
                DataType.UInt16 => sizeof(ushort),
                DataType.Int32 => sizeof(int),
                DataType.UInt32 => sizeof(uint),
                DataType.Int64 => sizeof(long),
                DataType.UInt64 => sizeof(ulong),
                DataType.Float32 => sizeof(float),
                DataType.Double64 => sizeof(double),
                DataType.Bitfield => (ushort)Math.Ceiling((((bool[])value)?.Length ?? 0) / 8.0),
                DataType.String => (ushort)(((string)value)?.Length ?? 0),
                DataType.Container => ((Container)value)?.Size ?? 0,
                DataType.Timestamp => sizeof(long) + sizeof(int),
                DataType.ByteArray => (ushort)(((byte[])value)?.Length ?? 0),
                DataType.Error => sizeof(uint),
                _ => throw new ArgumentException("Invalid value type"),
            };
        }

        /// <summary>
        /// Try to get type of value.
        /// Bitfield not implemented due to overlap with byte array.
        /// Maybe change bitfield to bool[]
        /// </summary>
        /// <param name="value">value can be null</param>
        /// <returns>Data type, if value null then None returned</returns>
        /// <exception cref="ArgumentException">on unknown value type</exception>
        private static DataType GetDataTypeFromValue(object? value)
        {
            if (value == null)
            {
                return DataType.None;
            }
            return value.GetType() switch
            {
                Type type when type == typeof(bool) => DataType.Bool,
                Type type when type == typeof(sbyte) => DataType.Char8,
                Type type when type == typeof(byte) => DataType.UChar8,
                Type type when type == typeof(short) => DataType.Int16,
                Type type when type == typeof(ushort) => DataType.UInt16,
                Type type when type == typeof(int) => DataType.Int32,
                Type type when type == typeof(uint) => DataType.UInt32,
                Type type when type == typeof(long) => DataType.Int64,
                Type type when type == typeof(ulong) => DataType.UInt64,
                Type type when type == typeof(float) => DataType.Float32,
                Type type when type == typeof(double) => DataType.Double64,
                Type type when type == typeof(bool[]) => DataType.Bitfield,
                Type type when type == typeof(string) => DataType.String,
                Type type when type == typeof(Container) => DataType.Container,
                Type type when type == typeof(DateTime) => DataType.Timestamp,
                Type type when type == typeof(byte[]) => DataType.ByteArray,
                Type type when type == typeof(ErrorCode) => DataType.Error,
                _ => throw new ArgumentException("Invalid value type"),
            };
        }

        /// <summary>
        /// get tag value from enum object
        /// </summary>
        /// <param name="key">the tag enum value</param>
        /// <returns>tag uint</returns>
        /// <exception cref="ArgumentException">if enum not correct type</exception>
        private static uint GetTagFromEnum(object key)
        {
            Tags.TagGroupAttribute? tagInfo = key.GetType().GetCustomAttribute<Tags.TagGroupAttribute>();
            if (tagInfo == null || Enum.GetUnderlyingType(key.GetType()) != typeof(uint))
            {
                throw new ArgumentException("Invalid enum type");
            }

            return tagInfo.Group << 24 | (uint)key;
        }

        /// <summary>
        /// convert tag enum value to string
        /// </summary>
        /// <param name="key">tag enum</param>
        /// <returns>string</returns>
        /// <exception cref="ArgumentException">if enum not correct type</exception>
        public static string EnumToString(Enum key)
        {
            Tags.TagGroupAttribute? tagInfo = key.GetType().GetCustomAttribute<Tags.TagGroupAttribute>();
            if (tagInfo == null || Enum.GetUnderlyingType(key.GetType()) != typeof(uint))
            {
                throw new ArgumentException("Invalid enum type");
            }

            return $"{key.GetType().Name}_{key}";
        }
    }
}
