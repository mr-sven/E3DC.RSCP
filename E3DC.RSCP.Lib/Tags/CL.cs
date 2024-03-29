﻿namespace E3DC.RSCP.Lib.Tags
{
    [TagGroup(0xf6)]
    public enum CL : uint
    {
        CLIENT_LIST_AVAILABLE = 0x00a001,
        REQ_CLIENT_LIST = 0x00a002,
        REQ_CONNECTED_USER = 0x00a004,
        REQ_INET_ADDR = 0x00a005,
        REQ_CONNECTION_TIME = 0x00a006,
        REQ_DIAG = 0x00a007,
        REQ_UPDATE = 0x00a008,
        FILTER_TYPE = 0x00b001,
        LIST_FILTER = 0x00b002,
        DEVICE_TYPE = 0x00b003,
        SERIALNO = 0x00b004,
        PRODUCTION_DATE = 0x00b005,
        MAC_ADDRESS = 0x00b006,
        IP_ADDRESS = 0x00b007,
        SUBNET_MASK = 0x00b008,
        GATEWAY = 0x00b009,
        DNS = 0x00b010,
        DHCP_STATUS = 0x00b011,
        SYSTEM_TIME = 0x00b012,
        TIME_ZONE = 0x00b013,
        UTC_TIME = 0x00b014,
        A35_SERIALNO = 0x00b015,
        REG_ID = 0x00b016,
        IS_ONLINE = 0x00b017,
        USERNAME = 0x00b018,
        PARAM_DIAG = 0x00b019,
        LIST_LIMIT = 0x00b01a,
        ADD_CLIENT = 0x08a002,
        REMOVE_CLIENT = 0x08a003,
        CONNECTED_USER = 0x08a004,
        INET_ADDR = 0x08a005,
        CONNECTION_TIME = 0x08a006,
        DIAG = 0x08a007,
        GENERAL_ERROR = 0x7fffff,
    }
}
