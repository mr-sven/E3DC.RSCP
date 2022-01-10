﻿namespace E3DC.RSCP.Lib.Tags
{
    [TagGroup(0x1b)]
	public enum SE : uint
	{
		SE_COUNT = 0x01,
		SE_DATA = 0x02,
		SET_POWER = 0x03,
		SET_DERATING = 0x04,
		SET_COUPLE_MODE = 0x05,
		COUPLE_MODE = 0x06,
		SET_BAT_VOLT_ADJUSTMENT = 0x07,
		BAT_VOLT_ADJUSTMENT = 0x08,
		EP_RESERVE = 0x09,
		SET_EP_RESERVE = 0x10,
		RESET_POWERSAVE_TIMEOUT = 0x27,
		EMERGENCY_POWER_OVERLOAD_STATUS = 0x28,
		EMERGENCY_POWER_RETRY = 0x29,
		BAT_VOLT_ADJ_READY_INDEX = 0x32,
		PARAM_INDEX = 0x040000,
		PARAM_DCDC_STATUS = 0x040001,
		PARAM_BAT_STATUS = 0x040002,
		PARAM_CTRL_STATE = 0x040003,
		PARAM_PvPower = 0x040004,
		PARAM_PvEnergy = 0x040005,
		PARAM_BatteryPower = 0x040006,
		PARAM_BatCapacity = 0x040007,
		PARAM_Limits = 0x040008,
		PARAM_DesiredPower = 0x040009,
		PARAM_DesiredDerating = 0x040010,
		PARAM_INT = 0x040011,
		PARAM_UINT = 0x040012,
		PARAM_FLOAT = 0x040013,
		PARAM_EmergencyMode = 0x040014,
		PARAM_BAT_VOLT_STATUS = 0x040015,
		PARAM_BAT_VOLT_TARGET_VALUE = 0x040016,
		PARAM_BAT_VOLT_MIN_VOLTAGE = 0x040017,
		PARAM_BAT_VOLT_MAX_VOLTAGE = 0x040018,
		PARAM_BAT_VOLT_ENABLED = 0x040019,
		PARAM_PVI1_STATUS = 0x040020,
		PARAM_PVI2_STATUS = 0x040021,
		PARAM_PVI3_STATUS = 0x040022,
		PARAM_EP_RESERVE = 0x040023,
		PARAM_TIME_LAST_FULL = 0x040024,
		PARAM_TIME_LAST_EMPTY = 0x040025,
		PARAM_LAST_SOC = 0x040026,
		PARAM_TIME_TO_RETRY = 0x040030,
		PARAM_NO_REMAINING_RETRY = 0x040031,
		PARAM_BAT_VOLT_ADJ_READY_INDEX = 0x040032,
	}
}