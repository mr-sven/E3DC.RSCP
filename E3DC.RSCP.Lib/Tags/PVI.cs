﻿namespace E3DC.RSCP.Lib.Tags
{
    [TagGroup(0x02)]
    public enum PVI : uint
    {
        ON_GRID = 0x000001,
        STATE = 0x000002,
        LAST_ERROR = 0x000003,
        IS_FLASHING = 0x000004,
        REQ_START_FLASHING = 0x000005,
        FLASH_FILE_LIST = 0x000006,
        FLASH_FILE = 0x000007,
        SERVICE_PROGRESS_STATE = 0x000008,
        TYPE = 0x000009,
        GET_GAPP_LAST_CHANGE_TIME = 0x00000a,
        GET_GAPP_SYNC_TIME = 0x00000b,
        SET_GAPP_SYNC_TIME = 0x00000c,
        LAND_CODE = 0x000010,
        LAND_CODE_LIST = 0x000011,
        REQ_SET_LAND_CODE = 0x000012,
        ERROR_STRING = 0x000013,
        ERROR_LIST = 0x000014,
        STATUS_STRING = 0x000015,
        STATUS_LIST = 0x000016,
        REQ_SET_DEVICE_SILENCE = 0x000017,
        DEVICE_SILENCE = 0x000018,
        SELF_TEST = 0x000019,
        SET_FREE_INVERTER = 0x000020,
        SET_BLOCK_INVERTER = 0x000021,
        UZK_VOLTAGE = 0x000050,
        COS_PHI = 0x000060,
        REQ_SET_COS_PHI = 0x000061,
        COS_PHI_VALUE = 0x000062,
        COS_PHI_IS_AKTIV = 0x000063,
        COS_PHI_EXCITED = 0x000064,
        VOLTAGE_MONITORING = 0x000070,
        REQ_SET_VOLTAGE_MONITORING = 0x000071,
        VOLTAGE_MONITORING_THRESHOLD_TOP = 0x000072,
        VOLTAGE_MONITORING_THRESHOLD_BOTTOM = 0x000073,
        VOLTAGE_MONITORING_SLOPE_UP = 0x000074,
        VOLTAGE_MONITORING_SLOPE_DOWN = 0x000075,
        FREQUENCY_UNDER_OVER = 0x000080,
        SET_FREQUENCY_UNDER_OVER = 0x000081,
        FREQUENCY_UNDER = 0x000082,
        FREQUENCY_OVER = 0x000083,
        SET_SYSTEM_MODE = 0x000084,
        SYSTEM_MODE = 0x000085,
        SET_POWER_MODE = 0x000086,
        POWER_MODE = 0x000087,
        USED_STRING_COUNT = 0x000090,
        REQ_SET_USED_STRING_COUNT = 0x000091,
        DERATE_TO_POWER = 0x000092,
        TEMPERATURE = 0x000100,
        TEMPERATURE_COUNT = 0x000101,
        MAX_TEMPERATURE = 0x000102,
        MIN_TEMPERATURE = 0x000103,
        CT_TAR_USV_BOX = 0x000104,
        ROTARY_FIELD_DIRECTION = 0x000105,
        DATA = 0x040000,
        INDEX = 0x040001,
        VALUE = 0x040005,
        DEVICE_STATE = 0x060000,
        DEVICE_CONNECTED = 0x060001,
        DEVICE_WORKING = 0x060002,
        DEVICE_IN_SERVICE = 0x060003,
        SERIAL_NUMBER = 0x0abc01,
        VERSION = 0x0abc02,
        VERSION_MAIN = 0x0abc03,
        VERSION_PIC = 0x0abc04,
        VERSION_ALL = 0x0abc05,
        GAPP_JSON = 0x0abc13,
        GAPP_JSON_MD5 = 0x0abc14,
        REQ_SET_RESET_GPIO = 0x0abc50,
        REQ_SET_POWEROFF_GPIO = 0x0abc51,
        REQ_SET_NIGHTSWITCH_GPIO = 0x0abc52,
        REQ_SET_PRE_GRID_CHARGE = 0x0abc60,
        AC_MAX_PHASE_COUNT = 0x0ac000,
        AC_POWER = 0x0ac001,
        AC_VOLTAGE = 0x0ac002,
        AC_CURRENT = 0x0ac003,
        AC_APPARENTPOWER = 0x0ac004,
        AC_REACTIVEPOWER = 0x0ac005,
        AC_ENERGY_ALL = 0x0ac006,
        AC_MAX_APPARENTPOWER = 0x0ac007,
        AC_ENERGY_DAY = 0x0ac008,
        AC_ENERGY_GRID_CONSUMPTION = 0x0ac009,
        AC_FREQUENCY = 0x0ac00a,
        INVERTER_COUNT = 0x0cccc9,
        DC_MAX_STRING_COUNT = 0x0dc000,
        DC_POWER = 0x0dc001,
        DC_VOLTAGE = 0x0dc002,
        DC_CURRENT = 0x0dc003,
        DC_MAX_POWER = 0x0dc004,
        DC_MAX_VOLTAGE = 0x0dc005,
        DC_MIN_VOLTAGE = 0x0dc006,
        DC_MAX_CURRENT = 0x0dc007,
        DC_MIN_CURRENT = 0x0dc008,
        DC_STRING_ENERGY_ALL = 0x0dc009,
        AC_ENERGY_PRODUCED_L1 = 0x0dc00a,
        AC_ENERGY_PRODUCED_L2 = 0x0dc00b,
        AC_ENERGY_PRODUCED_L3 = 0x0dc00c,
        AC_ENERGY_CONSUMED_L1 = 0x0dc00d,
        AC_ENERGY_CONSUMED_L2 = 0x0dc00e,
        AC_ENERGY_CONSUMED_L3 = 0x0dc00f,
        REQ_ENABLE_FAN_TEST = 0x0dc010,
        REQ_DISABLE_FAN_TEST = 0x0dc011,
        RESET_LAND_NORM = 0x0dc012,
        IS_FAN_INSTALLED = 0x0dc013,
        GENERAL_ERROR = 0x7fffff,
    }
}
