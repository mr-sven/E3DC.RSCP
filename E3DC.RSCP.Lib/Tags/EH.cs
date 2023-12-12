namespace E3DC.RSCP.Lib.Tags
{
    [TagGroup(0x14)]
    public enum EH : uint
    {
        UNREPORTED_ERRORS = 0x000001,
        MARKED_REPORTED = 0x000002,
        GET_SAVED_ERRORS = 0x000003,
        PARAM_ROW = 0x040000,
        PARAM_ROW_ID = 0x040001,
        PARAM_ROW_TIME = 0x040002,
        PARAM_ROW_CODE = 0x040003,
        PARAM_ROW_TYPE = 0x040004,
        PARAM_ROW_CLEARED = 0x040005,
        PARAM_ROW_ERR_SRC = 0x040006,
        PARAM_ROW_MSG = 0x040007,
        GENERAL_ERROR = 0x7fffff,
    }
}
