namespace E3DC.RSCP.Lib.Tags
{
    [TagGroup(0x19)]
    public enum GPIO : uint
    {
        RSP_SET = 0x000001,
        RSP_GET = 0x000002,
        RSP_LIST = 0x000003,
        TUPEL = 0x060001,
        NUMBER = 0x060002,
        NAME = 0x060003,
        VALUE = 0x060004,
        GENERAL_ERROR = 0x7fffff,
    }
}