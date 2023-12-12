namespace E3DC.RSCP.Lib.Tags
{
    [TagGroup(0x11)]
    public enum DIAG : uint
    {
        CURRENT_ISSUES = 0x000000,
        REPORTED_ISSUES = 0x000001,
        ISSUE = 0x060000,
        ERR_CODE = 0x060001,
        ENDURE_TIME = 0x060002,
        TIME_ARISED = 0x060003,
        ERR_MSG = 0x060004,
        GENERAL_ERROR = 0x7fffff,
    }
}
