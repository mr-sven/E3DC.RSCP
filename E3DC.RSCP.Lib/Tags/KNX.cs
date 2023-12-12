namespace E3DC.RSCP.Lib.Tags
{
    [TagGroup(0x16)]
    public enum KNX : uint
    {
        RSP_SET = 0x000001,
        MAC = 0x000002,
        IP = 0x000003,
        SOFTWAREVERSION = 0x000004,
        FIRMWAREVERSION = 0x000005,
        REQ_STORED_ERRORS = 0x000006,
        REQ_STORE_FILTER = 0x000007,
        REQ_SHOW_KNX_SCREEN = 0x000008,
        ERROR_CONTAINER = 0x400001,
        ERROR_TYPE = 0x400002,
        ERROR_SOURCE = 0x400003,
        ERROR_MESSAGE = 0x400004,
        ERROR_CODE = 0x400005,
        ERROR_TIMESTAMP = 0x400006,
        STORE_FILTER = 0x400007,
        FILTER_CATEGORY = 0x400008,
        FILTER_ENUM = 0x400009,
        GENERAL_ERROR = 0x7fffff,
    }
}
