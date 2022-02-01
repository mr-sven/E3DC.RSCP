namespace E3DC.RSCP.Lib.Tags
{
    [TagGroup(0x22)]
    public enum OVP : uint
    {
        STATUS = 0x000001,
        RESET = 0x000002,
        GENERAL_ERROR = 0x7fffff,
    }
}