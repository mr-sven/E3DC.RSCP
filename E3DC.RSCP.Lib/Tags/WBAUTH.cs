namespace E3DC.RSCP.Lib.Tags
{
    [TagGroup(0x24)]
    public enum WBAUTH : uint
    {
        VERIFY_SESSION = 0x000000,
        WALLBOX_ID = 0x400001,
        SESSION_ID = 0x400002,
        VERIFICATION_ENTRY = 0x400003,
        ENTRY_TYPE = 0x400004,
        ENTRY_DATA = 0x400005,
        VERIFICATION_RESULT = 0x400006,
        ENTRY_SWAPPED = 0x400007,
        GENERAL_ERROR = 0x7fffff,
    }
}
