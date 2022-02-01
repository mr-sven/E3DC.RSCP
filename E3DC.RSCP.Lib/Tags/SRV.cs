namespace E3DC.RSCP.Lib.Tags
{
    [TagGroup(0x08)]
    public enum SRV : uint
    {
        IS_ONLINE = 0x000001,
        ADD_USER = 0x000002,
        SET_LOCAL_USER = 0x000003,
        GENERAL_ERROR = 0x7fffff,
    }
}