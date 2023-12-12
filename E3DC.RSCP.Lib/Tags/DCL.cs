namespace E3DC.RSCP.Lib.Tags
{
    [TagGroup(0xf5)]
    public enum DCL : uint
    {
        REQ_RM_ENTRY = 0x000af0,
        REQ_CL_LIST = 0x00a001,
        REQ_INSERT_CL_MSG = 0x00a002,
        REQ_REGISTER_ON_DEVICE = 0x00a003,
        SESSION_ID = 0x00b001,
        GROUP_ID = 0x00b002,
        USER_ID = 0x00b003,
        TIME = 0x00b004,
        USERNAME = 0x00b005,
        TICKET_REF = 0x00b006,
        DESCRIPTION = 0x00b007,
        SERIALNO = 0x00b008,
        LOCAL_ADDRESS = 0x00b009,
        ADD_CL_ELEMENT = 0x08a001,
        ADD_CL_SESSION = 0x08a002,
        REGISTER_ON_DEVICE = 0x08a003,
        GENERAL_ERROR = 0x7fffff,
    }
}
