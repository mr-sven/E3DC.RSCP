namespace E3DC.RSCP.Lib.Tags
{
    [TagGroup(0x20)]
    public enum WBD : uint
    {
        START_SCAN = 0x000001,
        IS_SCANNING = 0x000002,
        CREATE_WB = 0x000003,
        CANCEL_CAN = 0x000004,
        DELETE_WALL_BOX = 0x000005,
        GENERAL_ERROR = 0x7fffff,
    }
}
