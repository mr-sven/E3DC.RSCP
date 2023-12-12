namespace E3DC.RSCP.Lib.Tags
{
    [TagGroup(0xf4)]
    public enum LOG : uint
    {
        REQ_LOGGER = 0x00a001,
        REQ_SET_LEVEL = 0x00a002,
        REQ_LOG = 0x00a003,
        NOTIFY_REGISTERED = 0x00a004,
        PAR_LEVEL = 0x00b001,
        PAR_NAME = 0x00b002,
        PAR_CONTENT = 0x00b003,
        PAR_TIME = 0x00b004,
        PAR_SERVER_ID = 0x00b005,
        LOGGER = 0x08a001,
        SET_LEVEL = 0x08a002,
        GENERAL_ERROR = 0x7fffff,
    }
}
