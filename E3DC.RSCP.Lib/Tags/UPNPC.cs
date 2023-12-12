namespace E3DC.RSCP.Lib.Tags
{
    [TagGroup(0x15)]
    public enum UPNPC : uint
    {
        DEFAULT_LIST = 0x000001,
        SET_DEFAULT_LIST = 0x000002,
        SERVICE_LIST = 0x000003,
        DEFAULT_LIST_REV = 0x000006,
        SERVICE_LIST_REV = 0x000007,
        PARAM_DEVICE_ENTRY = 0x040000,
        PARAM_SERIALNO = 0x040001,
        PARAM_IP_ADR = 0x040002,
        PARAM_PORT = 0x040003,
        PARAM_NAME = 0x040004,
        PARAM_LOCATION = 0x040005,
        GENERAL_ERROR = 0x7fffff,
    }
}
