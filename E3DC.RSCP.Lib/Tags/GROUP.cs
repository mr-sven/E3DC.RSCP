namespace E3DC.RSCP.Lib.Tags
{
    [TagGroup(0xfc)]
    public enum GROUP : uint
    {
        CTRL_REQ_STATUS = 0x000001,
        CTRL_GROUP_ID = 0x000002,
        CTRL_READY = 0x000003,
        CTRL_P_OPERATION_POINT = 0x000004,
        CTRL_P_ACTUAL = 0x000005,
        CTRL_FORECAST_60MINUTES = 0x000006,
        CTRL_REQ_CONTROL = 0x000007,
        CTRL_P_TARGET = 0x000008,
        CTRL_ACTIVE = 0x000009,
        CTRL_AWARD = 0x00000a,
        GENERAL_ERROR = 0x7fffff,
    }
}