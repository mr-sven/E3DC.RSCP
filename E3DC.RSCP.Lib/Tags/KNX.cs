namespace E3DC.RSCP.Lib.Tags
{
    [TagGroup(0x16)]
    public enum KNX : uint
    {
        RSP_SET = 0x000001,
        MAC = 0x000002,
        IP = 0x000003,
        GENERAL_ERROR = 0x7fffff,
    }
}