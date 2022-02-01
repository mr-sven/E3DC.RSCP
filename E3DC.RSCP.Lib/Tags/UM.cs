namespace E3DC.RSCP.Lib.Tags
{
    [TagGroup(0x0d)]
    public enum UM : uint
    {
        UPDATE_STATUS = 0x000001,
        UPDATE_DCDC = 0x000002,
        CHECK_FOR_UPDATES = 0x000003,
        GENERAL_ERROR = 0x7fffff,
    }
}