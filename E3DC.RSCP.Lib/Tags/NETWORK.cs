﻿namespace E3DC.RSCP.Lib.Tags
{
    [TagGroup(0x23)]
    public enum NETWORK : uint
    {
        PING = 0x000001,
        INFO = 0x000002,
        DIAGNOSE = 0x000003,
        SET_IP = 0x000004,
        SET_SUBNETMASK = 0x000005,
        SET_GATEWAY = 0x000006,
        SET_DNS_SERVER = 0x000007,
        SET_DHCP = 0x000008,
        MAKE_INFO_FILE = 0x000009,
        CHECK_INTERNET_SPEED = 0x00000a,
        PARAM_IP = 0x400001,
        PARAM_SUBNETMASK = 0x400002,
        PARAM_GATEWAY = 0x400003,
        PARAM_DNS_SERVER = 0x400004,
        PARAM_DHCP = 0x400005,
        PARAM_MAC_ADDRESS = 0x400006,
        PARAM_E3DC_SERVER_REACHABLE = 0x400007,
        PARAM_DNS_SERVER_REACHABLE = 0x400008,
        PARAM_DNS_LOOKUP_WORKING = 0x400009,
        PARAM_GATEWAY_REACHABLE = 0x40000a,
        PARAM_SYSTEM_IP_VALID = 0x40000b,
        PARAM_CABLE_CONNECTED = 0x40000c,
        PARAM_INTERNET_SPEED = 0x40000d,
        GENERAL_ERROR = 0x7fffff,
    }
}
