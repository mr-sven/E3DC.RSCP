﻿namespace E3DC.RSCP.Lib.Tags
{
    [TagGroup(0x0e)]
    public enum WB : uint
    {
        ENERGY_ALL = 0x000001,
        ENERGY_SOLAR = 0x000002,
        SOC = 0x000003,
        STATUS = 0x000004,
        ERROR_CODE = 0x000005,
        MODE = 0x000006,
        APP_SOFTWARE = 0x000007,
        BOOTLOADER_SOFTWARE = 0x000008,
        HW_VERSION = 0x000009,
        FLASH_VERSION = 0x00000a,
        DEVICE_ID = 0x00000b,
        PM_POWER_L1 = 0x00000c,
        PM_POWER_L2 = 0x00000d,
        PM_POWER_L3 = 0x00000e,
        PM_ACTIVE_PHASES = 0x00000f,
        PM_MODE = 0x000011,
        PM_ENERGY_L1 = 0x000012,
        PM_ENERGY_L2 = 0x000013,
        PM_ENERGY_L3 = 0x000014,
        PM_DEVICE_ID = 0x000015,
        PM_ERROR_CODE = 0x000016,
        PM_FIRMWARE_VERSION = 0x000017,
        DIAG_DEVICE_ID = 0x000018,
        DIAG_BAT_CAPACITY = 0x000019,
        DIAG_USER_PARAM = 0x00001a,
        DIAG_MAX_CURRENT = 0x00001b,
        DIAG_PHASE_VOLTAGE = 0x00001c,
        DIAG_DISPLAY_SPEECH = 0x00001d,
        DIAG_DESIGN = 0x00001e,
        DIAG_INFOS = 0x00001f,
        DIAG_WARNINGS = 0x000020,
        DIAG_ERRORS = 0x000021,
        DIAG_TEMP_1 = 0x000022,
        DIAG_TEMP_2 = 0x000023,
        DIAG_CP_PEGEL = 0x000024,
        DIAG_PP_IN_A = 0x000025,
        DIAG_STATUS_DIODE = 0x000026,
        DIAG_DIG_IN_1 = 0x000027,
        DIAG_DIG_IN_2 = 0x000028,
        PM_DEVICE_STATE = 0x000029,
        PM_DEVICE_STATE_CONNECTED = 0x000030,
        SET_MODE = 0x000031,
        PM_DEVICE_STATE_IN_SERVICE = 0x000032,
        PM_MAX_PHASE_POWER = 0x000040,
        REQ_SET_DEVICE_NAME = 0x000041,
        DEVICE_NAME = 0x000042,
        DATA = 0x040000,
        INDEX = 0x040001,
        MODE_PARAM_MODE = 0x040031,
        MODE_PARAM_MAX_CURRENT = 0x040032,
        AVAILABLE_SOLAR_POWER = 0x041000,
        POWER = 0x041001,
        STATUS_BIT = 0x041002,
        SET_EXTERN = 0x041010,
        EXTERN_DATA_SUN = 0x041011,
        EXTERN_DATA_NET = 0x041012,
        EXTERN_DATA_ALL = 0x041013,
        EXTERN_DATA_ALG = 0x041014,
        SET_BAT_CAPACITY = 0x041015,
        SET_ENERGY_ALL = 0x041016,
        SET_ENERGY_SOLAR = 0x041017,
        SET_PARAM_1 = 0x041018,
        SET_PARAM_2 = 0x041019,
        RSP_PARAM_2 = 0x04101a,
        RSP_PARAM_1 = 0x04101b,
        CONNECTED_DEVICES = 0x04101c,
        SET_SOC = 0x04101d,
        STATION_AVAILABLE = 0x04101e,
        SET_STATION_AVAILABLE = 0x04101f,
        SET_PW = 0x041020,
        SET_STATION_ENABLED = 0x041021,
        MAC_ADDRESS = 0x041022,
        PROXIMITY_PLUG = 0x041023,
        REQ_PREFERRED_CHARGE_POWER = 0x041024,
        CHARGE_FULL = 0x041025,
        SET_CHARGE_FULL = 0x041026,
        ACTIVE_CHARGE_STRATEGY = 0x041027,
        SET_ACTIVE_CHARGE_STRAGETY = 0x041028,
        PARAMETER_LIST = 0x041029,
        STATION_ENABLED = 0x04102a,
        SET_PARAMETER_LIST = 0x041030,
        GATEWAY = 0x041031,
        SUBNET_MASK = 0x041032,
        IP_ADDR = 0x041033,
        DHCP_ENABLED = 0x041034,
        SET_DHCP_ENABLED = 0x041035,
        WALLBOX_TYPE = 0x041036,
        UPDATE_NETWORK_CONFIG = 0x041037,
        SUN_MODE_ACTIVE = 0x041038,
        SET_SUN_MODE_ACTIVE = 0x041039,
        NUMBER = 0x04103a,
        NUMBER_PHASES = 0x04103b,
        SET_NUMBER_PHASES = 0x04103c,
        ABORT_CHARGING = 0x04103d,
        REQ_SET_ABORT_CHARGING = 0x04103e,
        SET_ABORT_CHARGING = 0x04103f,
        SHUKO_AVAILABLE = 0x041040,
        IS_SHUKO_LOCKED = 0x041041,
        SET_SHUKO_LOCKED = 0x041042,
        MAX_POWER_PER_PHASE = 0x041043,
        MIN_POWER_PER_PHASE = 0x041044,
        UPPER_CURRENT_LITMIT = 0x041045,
        LOWER_CURRENT_LITMIT = 0x041046,
        MAX_CHARGE_CURRENT = 0x041047,
        MIN_CHARGE_CURRENT = 0x041048,
        SET_MAX_CHARGE_CURRENT = 0x041049,
        SET_MIN_CHARGE_CURRENT = 0x04104a,
        PARAM_INDEX = 0x04104b,
        CHARGE_STOP_HYSTERESIS = 0x04104c,
        SET_CHARGE_STOP_HYSTERESIS = 0x04104d,
        GET_KEY_LOCK_MODE = 0x04104e,
        SET_KEY_LOCK_MODE = 0x04104f,
        KEY_STATE = 0x041050,
        SERIAL = 0x041051,
        MAX_CHARGE_POWER = 0x041052,
        MIN_CHARGE_POWER = 0x041053,
        EXTERN_DATA = 0x042010,
        EXTERN_DATA_LEN = 0x042011,
        PARAM_USR = 0x042012,
        PARAM_PW = 0x042013,
        DEVICE_STATE = 0x060000,
        DEVICE_CONNECTED = 0x060001,
        DEVICE_WORKING = 0x060002,
        DEVICE_IN_SERVICE = 0x060003,
        SET_BIC_MODE = 0x0f0001,
        GET_BIC_MODE = 0x0f0002,
        GET_CHARGE_PLAN_TEXT = 0x0f0003,
        STRING_PARAMETER = 0x440010,
        PREFERRED_CHARGE_POWER = 0x741024,
        GENERAL_ERROR = 0x7fffff,
    }
}