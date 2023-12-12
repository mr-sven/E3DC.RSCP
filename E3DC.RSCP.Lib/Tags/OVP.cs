namespace E3DC.RSCP.Lib.Tags
{
    [TagGroup(0x22)]
    public enum OVP : uint
    {
        PARAM_STATUS = 0x000001,
        PARAM_RESET = 0x000002,
        STATUS = 0x000003,
        RESET = 0x000004,
        PARAM_INDEX = 0x400001,
        GENERAL_ERROR = 0x7fffff,
    }
}
