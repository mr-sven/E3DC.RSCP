namespace E3DC.RSCP.Lib.Tags
{
    [TagGroup(0x1a)]
    public enum FARM : uint
    {
        CONNECTED_DEVICES = 0x000001,
        REQ_CONNECTED_DEVICES_REV = 0x000003,
        PARAM_DEVICE = 0x040000,
        PARAM_SERIALNO = 0x040001,
        PARAM_CNAME = 0x040002,
        CONNECTED_DEVICES_REV = 0x040003,
        GENERAL_ERROR = 0x7fffff,
    }
}