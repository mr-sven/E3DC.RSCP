namespace E3DC.RSCP.Lib.Tags
{
    [TagGroup(0xfc)]
    public enum GROUP_CTRL : uint
    {
        STATUS = 0x000001,
        GROUP_ID = 0x000002,
        READY = 0x000003,
        P_OPERATION_POINT = 0x000004,
        P_ACTUAL = 0x000005,
        FORECAST_60MINUTES = 0x000006,
        CONTROL = 0x000007,
        P_TARGET = 0x000008,
        ACTIVE = 0x000009,
        AWARD = 0x00000a,
        TIME = 0x00000b,
        GENERAL_ERROR = 0x7fffff,
    }
}
