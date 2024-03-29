﻿namespace E3DC.RSCP.Lib.Tags
{
    [TagGroup(0x1b)]
    public enum SE : uint
    {
        SE_COUNT = 0x000001,
        SE_DATA = 0x000002,
        SET_POWER = 0x000003,
        SET_DERATE = 0x000004,
        SET_COUPLE_MODE = 0x000005,
        COUPLE_MODE = 0x000006,
        SET_BRI = 0x000007,
        GET_BRI = 0x000008,
        EP_RESERVE = 0x000009,
        GET_PROTECTION_STRATEGY = 0x00000a,
        SET_EP_RESERVE = 0x000010,
        GET_ESTIMATED_POWER_LIMIT = 0x000011,
        DESIGN_LIMIT = 0x000012,
        SET_RESTART_SWITCH_TO_EP = 0x000013,
        EP_STATUS = 0x000014,
        DIAGNOSIS_ERRORS = 0x000015,
        REQ_RESET_POWERSAVE_TIMEOUT = 0x000027,
        EMERGENCY_POWER_OVERLOAD_STATUS = 0x000028,
        EMERGENCY_POWER_RETRY = 0x000029,
        IS_EMERGENCYPOWER_POSSIBLE = 0x000030,
        SET_PROTECTION_STRATEGY = 0x000031,
        PARAM_INDEX = 0x040000,
        PARAM_DCDC_STATUS = 0x040001,
        PARAM_BAT_STATUS = 0x040002,
        PARAM_CTRL_STATE = 0x040003,
        PARAM_PVPOWER = 0x040004,
        PARAM_PVENERGY = 0x040005,
        PARAM_BATTERYPOWER = 0x040006,
        PARAM_BATCAPACITY = 0x040007,
        PARAM_LIMITS = 0x040008,
        PARAM_DESIREDPOWER = 0x040009,
        PARAM_DESIREDDERATING = 0x040010,
        PARAM_INT = 0x040011,
        PARAM_UINT = 0x040012,
        PARAM_FLOAT = 0x040013,
        PARAM_EMERGENCYMODE = 0x040014,
        PARAM_PVI1_STATUS = 0x040020,
        PARAM_PVI2_STATUS = 0x040021,
        PARAM_PVI3_STATUS = 0x040022,
        PARAM_EP_RESERVE = 0x040023,
        PARAM_TIME_LAST_FULL = 0x040024,
        PARAM_TIME_LAST_EMPTY = 0x040025,
        PARAM_LAST_SOC = 0x040026,
        PARAM_EP_STATUS = 0x040027,
        PARAM_TIME_TO_RETRY = 0x040030,
        PARAM_NO_REMAINING_RETRY = 0x040031,
        PARAM_EP_RESERVE_W = 0x040033,
        PARAM_EP_RESERVE_MAX_W = 0x040034,
        PARAM_BOOL = 0x400001,
        PARAM_BRI_INDEX = 0x400002,
        GENERAL_ERROR = 0x7fffff,
    }
}
