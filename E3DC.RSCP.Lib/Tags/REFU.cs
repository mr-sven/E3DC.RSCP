namespace E3DC.RSCP.Lib.Tags
{
    [TagGroup(0x21)]
    public enum REFU : uint
    {
        START_SCAN = 0x000001,
        IS_SCANNING = 0x000002,
        CREATE_INV = 0x000003,
        CANCEL_CAN = 0x000004,
        DELETE_INVERTER = 0x000005,
        NO_INVERTERS = 0x000006,
        CONNECTED_DEVICES = 0x000008,
        PARAM_MAC = 0x400001,
        PARAM_IP = 0x400002,
        PARAM_ALIVE = 0x400003,
        PARAM_INDEX = 0x400004,
        PARAM_DHCP = 0x400005,
        GENERAL_ERROR = 0x7fffff,
    }
}