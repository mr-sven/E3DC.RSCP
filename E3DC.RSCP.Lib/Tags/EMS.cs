﻿namespace E3DC.RSCP.Lib.Tags
{
    [TagGroup(0x01)]
    public enum EMS : uint
    {
        POWER_PV = 0x000001,
        POWER_BAT = 0x000002,
        POWER_HOME = 0x000003,
        POWER_GRID = 0x000004,
        POWER_ADD = 0x000005,
        AUTARKY = 0x000006,
        SELF_CONSUMPTION = 0x000007,
        BAT_SOC = 0x000008,
        COUPLING_MODE = 0x000009,
        STORED_ERRORS = 0x00000a,
        ERROR_CONTAINER = 0x00000b,
        ERROR_TYPE = 0x00000c,
        ERROR_SOURCE = 0x00000d,
        ERROR_MESSAGE = 0x00000e,
        ERROR_CODE = 0x00000f,
        ERROR_TIMESTAMP = 0x000010,
        MODE = 0x000011,
        BALANCED_PHASES = 0x000012,
        INSTALLED_PEAK_POWER = 0x000013,
        DERATE_AT_PERCENT_VALUE = 0x000014,
        DERATE_AT_POWER_VALUE = 0x000015,
        ERROR_BUZZER_ENABLED = 0x000016,
        SET_BALANCED_PHASES = 0x000017,
        SET_INSTALLED_PEAK_POWER = 0x000018,
        SET_DERATE_PERCENT = 0x000019,
        SET_ERROR_BUZZER_ENABLED = 0x00001a,
        START_ADJUST_BATTERY_VOLTAGE = 0x00001b,
        CANCEL_ADJUST_BATTERY_VOLTAGE = 0x00001c,
        ADJUST_BATTERY_VOLTAGE_STATUS = 0x00001d,
        CONFIRM_ERRORS = 0x00001e,
        POWER_WB_ALL = 0x00001f,
        POWER_WB_SOLAR = 0x000020,
        EXT_SRC_AVAILABLE = 0x000021,
        RESCUE_BAT_MODE = 0x000022,
        REQ_SET_RESCUE_BAT_MODE = 0x000023,
        SET_POWER = 0x000030,
        REQ_SET_POWER_MODE = 0x000031,
        REQ_SET_POWER_VALUE = 0x000032,
        STATUS = 0x000040,
        USED_CHARGE_LIMIT = 0x000041,
        BAT_CHARGE_LIMIT = 0x000042,
        DCDC_CHARGE_LIMIT = 0x000043,
        USER_CHARGE_LIMIT = 0x000044,
        USED_DISCHARGE_LIMIT = 0x000045,
        BAT_DISCHARGE_LIMIT = 0x000046,
        DCDC_DISCHARGE_LIMIT = 0x000047,
        USER_DISCHARGE_LIMIT = 0x000048,
        SET_POWER_CONTROL_OFFSET = 0x000060,
        REMAINING_BAT_CHARGE_POWER = 0x000071,
        REMAINING_BAT_DISCHARGE_POWER = 0x000072,
        EMERGENCY_POWER_STATUS = 0x000073,
        SET_EMERGENCY_POWER = 0x000074,
        SET_OVERRIDE_AVAILABLE_POWER = 0x000075,
        SET_BATTERY_TO_CAR_MODE = 0x000076,
        BATTERY_TO_CAR_MODE = 0x000077,
        SET_BATTERY_BEFORE_CAR_MODE = 0x000078,
        BATTERY_BEFORE_CAR_MODE = 0x000079,
        GET_IDLE_PERIODS = 0x000080,
        SET_IDLE_PERIODS = 0x000081,
        IDLE_PERIOD = 0x000082,
        IDLE_PERIOD_TYPE = 0x000083,
        IDLE_PERIOD_DAY = 0x000084,
        IDLE_PERIOD_START = 0x000085,
        IDLE_PERIOD_END = 0x000086,
        IDLE_PERIOD_HOUR = 0x000087,
        IDLE_PERIOD_MINUTE = 0x000088,
        IDLE_PERIOD_ACTIVE = 0x000089,
        IDLE_PERIOD_CHANGE_MARKER = 0x00008a,
        GET_POWER_SETTINGS = 0x00008b,
        SET_POWER_SETTINGS = 0x00008c,
        SETTINGS_CHANGE_MARKER = 0x00008d,
        GET_MANUAL_CHARGE = 0x00008e,
        START_MANUAL_CHARGE = 0x00008f,
        START_EMERGENCYPOWER_TEST = 0x000090,
        GET_GENERATOR_STATE = 0x000091,
        SET_GENERATOR_MODE = 0x000092,
        EMERGENCYPOWER_TEST_STATUS = 0x000093,
        EPTEST_NEXT_TESTSTART = 0x000094,
        EPTEST_START_COUNTER = 0x000095,
        EPTEST_RUNNING = 0x000096,
        REQ_GET_SYS_SPECS = 0x000097,
        GET_SYS_SPECS = 0x000098,
        SYS_SPEC = 0x000099,
        SYS_SPEC_INDEX = 0x00009a,
        SYS_SPEC_NAME = 0x00009b,
        SYS_SPEC_VALUE_INT = 0x00009c,
        SYS_SPEC_VALUE_STRING = 0x00009d,
        SYS_STATUS = 0x00009e,
        POWER_LIMITS_USED = 0x000100,
        MAX_CHARGE_POWER = 0x000101,
        MAX_DISCHARGE_POWER = 0x000102,
        DISCHARGE_START_POWER = 0x000103,
        POWERSAVE_ENABLED = 0x000104,
        WEATHER_REGULATED_CHARGE_ENABLED = 0x000105,
        WEATHER_FORECAST_MODE = 0x000106,
        MANUAL_CHARGE_START_COUNTER = 0x000150,
        MANUAL_CHARGE_ACTIVE = 0x000151,
        MANUAL_CHARGE_ENERGY_COUNTER = 0x000152,
        MANUAL_CHARGE_LASTSTART = 0x000153,
        REMOTE_CONTROL = 0x000200,
        DEACTIVATE_REMOTE_CONTROL = 0x000201,
        IP_REMOTE_CONTROL = 0x000202,
        EP_DELAY = 0x000203,
        SET_EP_DELAY = 0x000204,
        REMOTE_CONTROL_STATUS = 0x000205,
        IDLE_PERIOD_MIN_SOC_UCB = 0x000206,
        IDLE_PERIOD_MAX_SOC_UCB = 0x000207,
        SET_IDLE_PERIOD_MIN_SOC_UCB = 0x000208,
        SET_IDLE_PERIOD_MAX_SOC_UCB = 0x000209,
        REGULATOR_MODE = 0x000210,
        SET_REGULATOR_MODE = 0x000211,
        SUPPORTED_REGULATOR_MODES = 0x000212,
        EMERGENCY_POWER_OVERLOAD_STATUS = 0x000213,
        EMERGENCY_POWER_RETRY = 0x000214,
        DETECT_PHASE_OFFSET = 0x000217,
        PHASE_DETECTION_STATUS = 0x000218,
        PHASE_OFFSET = 0x000219,
        ABORT_PHASE_DETECTION = 0x000220,
        REGULATOR_STRATEGY = 0x000221,
        SET_REGULATOR_STRATEGY = 0x000222,
        POWER_PV_AC_OUT = 0x000223,
        PV_ENERGY = 0x000224,
        PARAM_AC_ENERGY_OUT = 0x000225,
        PARAM_AC_ENERGY_IN = 0x000226,
        PARAM_DC_IN = 0x000227,
        ENERGY_STORAGE_MODEL = 0x000228,
        PARAM_CURR_CHARGED_ENERGY = 0x000229,
        PARAM_FULL_CHARGED_ENERGY_EP_RESERVE = 0x000230,
        PARAM_DESIGN_ENERGY = 0x000231,
        PARAM_FULL_CHARGED_ENERGY = 0x000232,
        PARAM_USED_CAPACITY = 0x000233,
        SPECIFICATION_VALUES = 0x000234,
        PARAM_MAX_CHARGE_POWER = 0x000235,
        PARAM_MAX_DISCHARGE_POWER = 0x000236,
        PARAM_MAX_PV_POWER = 0x000237,
        PARAM_MAX_AC_POWER = 0x000238,
        PARAM_INSTALLED_BAT_CAP = 0x000239,
        PARAM_HYBRIT_SUPPORTED = 0x000240,
        PARAM_INIT_STATUS = 0x000241,
        EP_RESERVE = 0x000242,
        SEC_LIMITS = 0x000243,
        PARAM_SEL_TOTAL_MAX = 0x000244,
        PARAM_SEL_TOTAL_MIN = 0x000245,
        PARAM_SEL_PHASE_MAX_L1 = 0x000246,
        PARAM_SEL_PHASE_MAX_L2 = 0x000247,
        PARAM_SEL_PHASE_MAX_L3 = 0x000248,
        PARAM_SEL_PHASE_MIN_L1 = 0x000249,
        PARAM_SEL_PHASE_MIN_L2 = 0x000250,
        PARAM_SEL_PHASE_MIN_L3 = 0x000251,
        SEC_DEVICE_STATUS = 0x000252,
        PARAM_PVI_1 = 0x000253,
        PARAM_PVI_2 = 0x000254,
        PARAM_PVI_3 = 0x000255,
        PARAM_DCDC = 0x000256,
        PARAM_BAT = 0x000257,
        BAT_CURRENT_IN = 0x000258,
        BAT_CURRENT_OUT = 0x000259,
        MAX_DC_POWER = 0x000260,
        AC_REACTIVE_POWER = 0x000261,
        REQ_SET_EP_PARTIAL_GRID = 0x000262,
        GET_PARTIAL_GRID = 0x000263,
        ESTIMATED_POWER_LIMITS = 0x000264,
        DESIGN_POWER_LIMITS = 0x000265,
        SET_CAN_ID_FEED_IN_REDUCTION = 0x000266,
        CAN_ID_FEED_IN_REDUCTION = 0x000267,
        SET_CAN_ID_UNBALANCED_LOAD = 0x000268,
        CAN_ID_UNBALANCED_LOAD = 0x000269,
        SET_WALLBOX_MODE = 0x000270,
        GET_WALLBOX_MODE = 0x000271,
        SET_MAX_FUSE_POWER = 0x000272,
        GET_MAX_FUSE_POWER = 0x000273,
        SET_CONNECTED_POWER = 0x000274,
        GET_CONNECTED_POWER = 0x000275,
        DERATE_AT_CONNECTED_POWER = 0x000276,
        SET_DERATE_AT_CONNECTED_POWER = 0x000277,
        WB_AVAILABLE = 0x000280,
        WB_PREFERRED_CHARGE_POWER = 0x000281,
        SET_PEAK_SHAVING_POWER = 0x000282,
        GET_PEAK_SHAVING_POWER = 0x000283,
        GET_RUNSCREENVALUES = 0x000284,
        SET_PEAK_SHAVING_TIMES = 0x000286,
        GET_PEAK_SHAVING_TIMES = 0x000287,
        SET_LIST_ACTOR = 0x000288,
        GET_LIST_ACTOR = 0x000289,
        ACTOR_ITEM = 0x000290,
        ACTOR_ID = 0x000291,
        ACTOR_NAME = 0x000292,
        ACTOR_PRIORITY = 0x000293,
        PERIOD_ITEM = 0x000300,
        PERIOD_ACTIVE = 0x000301,
        PERIOD_NAME = 0x000302,
        PERIOD_WEEKDAYS = 0x000303,
        PERIOD_START = 0x000304,
        PERIOD_STOP = 0x000305,
        PERIOD_POWER = 0x000306,
        PARAM_DERATE_POWER_VALUE = 0x040001,
        PARAM_AVAILABLE_POWER = 0x040002,
        PARAM_IP_REMOTE_CONTROL = 0x040004,
        PARAM_POWEROFFSET_VALUE = 0x040005,
        PARAM_POWER_VALUE_L1 = 0x040006,
        PARAM_POWER_VALUE_L2 = 0x040007,
        PARAM_POWER_VALUE_L3 = 0x040008,
        PARAM_SET_POINT = 0x040009,
        PARAM_DERATE_POWER_VALUE_L1 = 0x040010,
        PARAM_DERATE_POWER_VALUE_L2 = 0x040011,
        PARAM_DERATE_POWER_VALUE_L3 = 0x040012,
        PARAM_REMOTE_CONTROL_ACTIVE = 0x040013,
        PARAM_TIME_TO_RETRY = 0x040014,
        PARAM_NO_REMAINING_RETRY = 0x040015,
        PARAM_INDEX = 0x040016,
        PARAM_WALLBOX_SETPOINT_L1 = 0x040017,
        PARAM_WALLBOX_SETPOINT_L2 = 0x040018,
        PARAM_WALLBOX_SETPOINT_L3 = 0x040019,
        PARAM_DEACTIVATE_SURPLUS_ACTOR = 0x040115,
        ALIVE = 0x050000,
        PARAM_LIMITS_TOTAL_MAX = 0x400265,
        PARAM_LIMITS_TOTAL_MIN = 0x400266,
        PARAM_LIMITS_PHASE_MAX_L1 = 0x400267,
        PARAM_LIMITS_PHASE_MAX_L2 = 0x400268,
        PARAM_LIMITS_PHASE_MAX_L3 = 0x400269,
        PARAM_LIMITS_PHASE_MIN_L1 = 0x400270,
        PARAM_LIMITS_PHASE_MIN_L2 = 0x400271,
        PARAM_LIMITS_PHASE_MIN_L3 = 0x400272,
        PARAM_CURR_CHARGED_ENERGY_EP_RESERVE = 0x400278,
        GENERAL_ERROR = 0x7fffff,
    }
}