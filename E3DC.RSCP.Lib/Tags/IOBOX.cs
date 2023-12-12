namespace E3DC.RSCP.Lib.Tags
{
    [TagGroup(0x1f)]
    public enum IOBOX : uint
    {
        RSP_IDENTIFY = 0x000001,
        RSP_GETCOUNT = 0x000002,
        RSP_SEARCH = 0x000003,
        RSP_SERIAL_NUMBER = 0x000004,
        RSP_STATE = 0x000005,
        LIST = 0x000006,
        REMOVE = 0x000007,
        DATA = 0x040000,
        INDEX = 0x040001,
        ITEM = 0x400001,
        ITEM_INDEX = 0x400002,
        ITEM_NAME = 0x400003,
        ITEM_SERIAL_NUMBER = 0x400004,
        ITEM_STATUS = 0x400005,
        ITEM_SWVERSION = 0x400006,
        ITEM_ADDITIONAL_INFO = 0x400007,
        GENERAL_ERROR = 0x7fffff,
    }
}
