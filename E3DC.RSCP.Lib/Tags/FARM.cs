﻿namespace E3DC.RSCP.Lib.Tags
{
    [TagGroup(0x1a)]
    public enum FARM : uint
    {
        CONNECTED_DEVICES = 0x000001,
        LIST_AVAILABLE_DEVICES = 0x000002,
        REQ_CONNECTED_DEVICES_REV = 0x000003,
        REQ_LIST_AVAILABLE_DEVICES = 0x000004,
        PARAM_DEVICE = 0x040000,
        PARAM_SERIALNO = 0x040001,
        PARAM_CNAME = 0x040002,
        CONNECTED_DEVICES_REV = 0x040003,
        PARAM_SHORT_ID = 0x400001,
        GENERAL_ERROR = 0x7fffff,
    }
}
