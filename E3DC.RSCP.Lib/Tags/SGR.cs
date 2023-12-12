namespace E3DC.RSCP.Lib.Tags
{
    [TagGroup(0x12)]
    public enum SGR : uint
    {
        STATE = 0x000001,
        READY_TO_USE = 0x000002,
        HW_PROVIDER_LIST = 0x000003,
        HW_PROVIDER = 0x000004,
        NAME = 0x000005,
        AKTIV = 0x000006,
        REQ_SET_COOLDOWN_START = 0x000007,
        COOLDOWN_END = 0x000008,
        USED_POWER = 0x000009,
        REQ_USED_POWER = 0x000010,
        REQ_SET_STATE = 0x000011,
        GLOBAL_OFF = 0x000012,
        REQ_GLOBAL_OFF = 0x000013,
        DATA = 0x040000,
        INDEX = 0x040001,
        GENERAL_ERROR = 0x7fffff,
    }
}
