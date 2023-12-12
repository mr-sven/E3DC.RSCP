﻿namespace E3DC.RSCP.Lib.Tags
{
    [TagGroup(0x1d)]
    public enum GAPP : uint
    {
        DEV_COUNT = 0x000001,
        SERIALNO = 0x000002,
        SUPPORTED_REACTIVE_POWER_FUNCTIONS = 0x000003,
        ENABLED_REACTIVE_POWER_FUNCTIONS = 0x000004,
        SET_REACTIVE_POWER_FUNCTIONS = 0x000005,
        SET_REACTIVE_POWER_FUNCTIONS_PARAMETER = 0x000006,
        REACTIVE_POWER_FUNCTIONS_PARAMETER = 0x000007,
        SUPPORTED_ACTIVE_POWER_FUNCTIONS = 0x000008,
        ENABLED_ACTIVE_POWER_FUNCTIONS_PU = 0x000009,
        SET_ACTIVE_POWER_FUNCTIONS_PU = 0x00000a,
        SET_ACTIVE_POWER_FUNCTIONS_PU_PARAMETER = 0x00000b,
        ACTIVE_POWER_FUNCTION_PU_PARAMETER = 0x00000c,
        REACTIVE_POWER_SETTINGS_EQUAL = 0x00000d,
        ACTIVE_POWER_SETTINGS_EQUAL = 0x00000e,
        SUPPORTED_GRID_PROTECTION_FUNCTIONS = 0x00000f,
        GRID_PROTECTION_FUNCTION_PARAMETER = 0x000010,
        SET_GRID_PROTECTION_FUNCTION_PARAMETER = 0x000011,
        PARAM_INDEX = 0x040000,
        PARAM_SERIALNO = 0x040001,
        PARAM_REACTIVE_POWER_FUNCTION = 0x040002,
        PARAM_ACTIVE_POWER_FUNCTION_PU = 0x040003,
        PARAM_GAPP_PARAMETER = 0x040004,
        PARAM_GAPP_PARAMETER_FUNCTION = 0x040005,
        PARAM_GAPP_PARAMETER_VALUE_LIST = 0x040006,
        PARAM_GAPP_PARAMETER_VALUE_LIST_ENTRY = 0x040007,
        PARAM_GAPP_PARAMETER_SCALE_FACTOR_X = 0x040008,
        PARAM_GAPP_PARAMETER_SCALE_FACTOR_Y = 0x040009,
        PARAM_GAPP_PARAMETER_VALUE_MAX = 0x040010,
        PARAM_GAPP_PARAMETER_VALUE_MIN = 0x040011,
        PARAM_GAPP_PARAMETER_VALUE = 0x040012,
        PARAM_GAPP_PARAMETER_VALUE_INIT = 0x040013,
        PARAM_SUPPORTED_REACTIVE_POWER_FUNCTIONS = 0x040014,
        PARAM_SUPPORTED_ACTIVE_POWER_FUNCTIONS = 0x040015,
        PARAM_SUCCESS = 0x040016,
        PARAM_GAPP_PARAMETER_HAS_Y = 0x040017,
        PARAM_GAPP_PARAMETER_COUNT_MIN = 0x040018,
        PARAM_GAPP_PARAMETER_COUNT_MAX = 0x040019,
        PARAM_GAPP_PARAMETER_COUNT_USED = 0x040020,
        PARAM_SUPPORTED_GRID_PROTECTION_FUNCTIONS = 0x040021,
        GENERAL_ERROR = 0x7fffff,
    }
}
