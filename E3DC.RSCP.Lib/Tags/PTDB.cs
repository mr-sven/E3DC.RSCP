namespace E3DC.RSCP.Lib.Tags
{
    [TagGroup(0x0f)]
    public enum PTDB : uint
    {
        SET_STD_PROPS = 0x000001,
        SET_PROP = 0x000002,
        PROP = 0x000003,
        PARAM_TABLE = 0x400001,
        PARAM_KEY = 0x400002,
        PARAM_VALUE = 0x400003,
        GENERAL_ERROR = 0x7fffff,
    }
}
