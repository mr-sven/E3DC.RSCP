using System.Runtime.InteropServices;

namespace E3DC.RSCP.Lib
{
    /// <summary>
    /// Struct of value header
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct ValueHeader
    {
        public uint Tag { get; set; }
        public byte DataType { get; set; }
        public ushort Length { get; set; }

        public readonly void ToBinaryWriter(BinaryWriter wr)
        {
            int size = Marshal.SizeOf<ValueHeader>();
            byte[] buffer = new byte[size];
            GCHandle gcHandle = GCHandle.Alloc(buffer, GCHandleType.Pinned);
            Marshal.StructureToPtr(this, gcHandle.AddrOfPinnedObject(), true);
            wr.Write(buffer);
            gcHandle.Free();
        }

        public static ValueHeader FromBinaryReader(BinaryReader br)
        {
            byte[] bytes = br.ReadBytes(Marshal.SizeOf<ValueHeader>());
            GCHandle gcHandle = GCHandle.Alloc(bytes, GCHandleType.Pinned);
            ValueHeader header = (ValueHeader)Marshal.PtrToStructure(gcHandle.AddrOfPinnedObject(), typeof(ValueHeader))!;
            gcHandle.Free();
            return header;
        }
    }
}
