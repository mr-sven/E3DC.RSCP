namespace E3DC.RSCP.Lib.Tags
{
    [TagGroup(0xf8)]
    public enum SERVER : uint
    {
        REGISTER_CONNECTION = 0x00a001,
        UNREGISTER_CONNECTION = 0x00a002,
        REQ_RSCP_CMD = 0x00a003,
        REQ_PING = 0x00a004,
        REQ_NEW_VIRTUAL_CONNECTION = 0x00a005,
        CONNECTION_ID = 0x00b001,
        AUTH_LEVEL = 0x00b002,
        STATUS = 0x00b003,
        RSCP_DATA_LEN = 0x00b004,
        RSCP_DATA = 0x00b005,
        TYPE = 0x00b006,
        HASH_CODE = 0x00b007,
        USER = 0x00b008,
        PASSWD = 0x00b009,
        IDENTIFIER = 0x00b010,
        CONNECTION_REGISTERED = 0x08a001,
        CONNECTION_UNREGISTERED = 0x08a002,
        RSCP_CMD_RESP = 0x08a003,
        PING = 0x08a004,
        GENERAL_ERROR = 0x7fffff,
    }
}