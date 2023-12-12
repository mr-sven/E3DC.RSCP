namespace E3DC.RSCP.Lib.Tags
{
    [TagGroup(0x19)]
    public enum GPIO : uint
    {
        RSP_SET = 0x000001,
        RSP_GET = 0x000002,
        RSP_LIST = 0x000003,
        RSP_LIST_ALIAS = 0x000004,
        RSP_LIST_REAL = 0x000005,
        RSP_CONNECT = 0x000006,
        RSP_CHANGECOUNTER = 0x000007,
        RSP_REMOTE_EXCHANGE = 0x000008,
        TUPEL = 0x060001,
        NUMBER = 0x060002,
        NAME = 0x060003,
        VALUE = 0x060004,
        KEY = 0x060005,
        AVAILABLE = 0x060006,
        MODE = 0x060007,
        SUPPORTED = 0x060008,
        CONNECTEDTO = 0x060009,
        USERLEVEL = 0x06000a,
        INACTIVE = 0x06000b,
        SETTINGS = 0x06000c,
        REMOTE_LINKED = 0x06000d,
        GENERAL_ERROR = 0x7fffff,
    }
}
