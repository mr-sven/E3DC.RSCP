using Force.Crc32;

namespace E3DC.RSCP.Lib
{
    /// <summary>
    /// Frame object is same as container but adding additional frame header data.
    /// </summary>
    public class Frame : Container
    {
        /// <summary>
        /// Protocol magic id
        /// </summary>
        public const ushort MAGIC_ID = 0xDCE3;

        /// <summary>
        /// default protocol version
        /// </summary>
        public const byte PROTOCOL_VERSION = 0x01;

        /// <summary>
        /// protocol version mask
        /// </summary>
        public const byte PROTOCOL_VERSION_MASK = 0x0F;

        /// <summary>
        /// protocol checksum flag
        /// </summary>
        public const byte WITH_CHECKSUM = 0x10;

        /// <summary>
        /// frame timestamp
        /// </summary>
        public DateTime Timestamp { get; set; } = DateTime.UtcNow;

        /// <summary>
        /// Frame checksum
        /// </summary>
        public bool WithChecksum { get; set; } = true;

        /// <summary>
        /// Overrides the byte getter to add frame header and checksum
        /// </summary>
        /// <returns>fram bytes</returns>
        public new byte[] GetBytes()
        {
            using MemoryStream ms = new();
            using BinaryWriter bw = new(ms);

            // appends magic id
            bw.Write(MAGIC_ID);

            // documentation missmatch of version flag
            bw.Write((byte)0x00); // GAP

            // add protocol version and checksum flag
            bw.Write((byte)(PROTOCOL_VERSION | (WithChecksum ? WITH_CHECKSUM : 0x00)));

            // write timestamp to data
            WriteTimeStamp(bw, Timestamp);

            // writes the current 
            bw.Write(Size);

            // writes the container data
            bw.Write(base.GetBytes());

            // calculates CRC sum
            uint crc = Crc32Algorithm.Compute(ms.ToArray());

            // write crc sum
            bw.Write(crc);

            // return data
            return ms.ToArray();
        }

        /// <summary>
        /// parse bytes to frame object
        /// </summary>
        /// <param name="data">byte data</param>
        /// <returns>frame</returns>
        /// <exception cref="ProtocolException">if frame parsing failed</exception>
        public static Frame FromBytes(byte[] data)
        {
            using MemoryStream ms = new(data);
            using BinaryReader br = new(ms);
            if (br.ReadUInt16() != MAGIC_ID)
            {
                throw new ProtocolException("Invalid Magic ID");
            }
            br.ReadByte(); // GAP
            byte protocolVersion = br.ReadByte();
            if ((protocolVersion & PROTOCOL_VERSION_MASK) != PROTOCOL_VERSION)
            {
                throw new ProtocolException($"Invalid Protocol version: {protocolVersion & PROTOCOL_VERSION_MASK}");
            }

            Frame result = [];
            result.WithChecksum = (protocolVersion & WITH_CHECKSUM) == WITH_CHECKSUM;
            result.Timestamp = ReadTimeStamp(br);

            ushort length = br.ReadUInt16();

            // store current position for CRC Check and later return to data
            int dataPosition = (int)br.BaseStream.Position;
            br.BaseStream.Position = 0;

            uint crc = Crc32Algorithm.Compute(br.ReadBytes(length + dataPosition));
            if (br.ReadUInt32() != crc)
            {
                throw new ProtocolException("CRC Checksum missmatch");
            }

            // return to data
            br.BaseStream.Position = dataPosition;

            result.ProcessBytes(length, br);

            return result;
        }
    }
}
