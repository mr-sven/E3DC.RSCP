namespace E3DC.RSCP.Lib.Tags
{
    [TagGroup(0xfb)]
    public enum DB_RECOVERY : uint
    {
        FINISH = 0x000000,
        REQ_RECOVERY = 0x000001,
        SOURCE = 0x000002,
        TARGET = 0x000003,
        RECOVERY = 0x000004,
        ERROR = 0x000005,
        LOG = 0x000006,
        REQ_RECOVERY_CONFIRM = 0x000007,
        RECOVERY_CONFIRM = 0x000008,
        REQ_RECOVERY_CANCEL = 0x000009,
        CANDIDATE_LIST = 0x00000a,
        REQ_STATUS = 0x00000b,
        REQ_FINISH = 0x00000c,
        RECOVERY_CANCEL = 0x000010,
        PARAM_USER = 0x400001,
        PARAM_PASSWORD = 0x400002,
        PARAM_CANDIDATE_SERIAL = 0x400003,
        STATUS = 0x400004,
        PARAM_ID = 0x400005,
        GENERAL_ERROR = 0x7fffff,
    }
}
