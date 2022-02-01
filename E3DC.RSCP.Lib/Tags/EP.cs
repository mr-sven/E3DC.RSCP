namespace E3DC.RSCP.Lib.Tags
{
    [TagGroup(0x0b)]
    public enum EP : uint
    {
        SWITCH_TO_GRID = 0x000001,
        SWITCH_TO_ISLAND = 0x000002,
        IS_READY_FOR_SWITCH = 0x000003,
        IS_GRID_CONNECTED = 0x000004,
        IS_ISLAND_GRID = 0x000005,
        IS_INVALID_STATE = 0x000006,
        IS_POSSIBLE = 0x000007,
        LEAVE_INVALID_STATE_TO_ISLAND = 0x000008,
        LEAVE_INVALID_STATE_TO_GRID = 0x000009,
        GENERAL_ERROR = 0x7fffff,
    }
}