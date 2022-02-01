namespace E3DC.RSCP.Lib.Tags
{
    [TagGroup(0x10)]
    public enum LED : uint
    {
        SET_BAR_SWITCHED_ON_STATE = 0x000001,
        BAR_SWITCHED_ON_STATE = 0x000002,
        INTENSITY = 0x000003,
        SET_INTENSITY = 0x000004,
        COLOR = 0x000005,
        SET_COLOR = 0x000006,
        HW_INFO = 0x000007,
        STORE_CONFIG = 0x000008,
        CONFIG_STORED = 0x000009,
        DEVICE_STATE = 0x060000,
        INDEX = 0x060001,
        RED = 0x060002,
        GREEN = 0x060003,
        BLUE = 0x060004,
        FW_VERSION = 0x060005,
        BL_VERSION = 0x060006,
        DEVICE_CONNECTED = 0x060007,
        DEVICE_WORKING = 0x060008,
        DEVICE_IN_SERVICE = 0x060009,
        GENERAL_ERROR = 0x7fffff,
    }
}