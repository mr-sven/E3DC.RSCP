﻿namespace E3DC.RSCP.Lib.Tags
{
    [TagGroup(0x01)]
	public enum EMS : uint
	{

		POWER_PV = 0x01,
		POWER_BAT = 0x02,
		POWER_HOME = 0x03,
		POWER_GRID = 0x04,
		POWER_ADD = 0x05,
		AUTARKY = 0x06,
		SELF_CONSUMPTION = 0x07,
		BAT_SOC = 0x08,
		COUPLING_MODE = 0x09,
		STORED_ERRORS = 0x0a,
		ERROR_CONTAINER = 0x0b,
		ERROR_TYPE = 0x0c,
		ERROR_SOURCE = 0x0d,
		ERROR_MESSAGE = 0x0e,
		ERROR_CODE = 0x0f,
		ERROR_TIMESTAMP = 0x10,
		MODE = 0x11,
		BALANCED_PHASES = 0x12,
		INSTALLED_PEAK_POWER = 0x13,
		DERATE_AT_PERCENT_VALUE = 0x14,
		DERATE_AT_POWER_VALUE = 0x15,
		ERROR_BUZZER_ENABLED = 0x16,
		SET_BALANCED_PHASES = 0x17,
		SET_INSTALLED_PEAK_POWER = 0x18,
		SET_DERATE_PERCENT = 0x19,
		SET_ERROR_BUZZER_ENABLED = 0x1a,
		START_ADJUST_BATTERY_VOLTAGE = 0x1b,
		CANCEL_ADJUST_BATTERY_VOLTAGE = 0x1c,
		ADJUST_BATTERY_VOLTAGE_STATUS = 0x1d,
		CONFIRM_ERRORS = 0x1e,
		POWER_WB_ALL = 0x1f,
		POWER_WB_SOLAR = 0x20,
		EXT_SRC_AVAILABLE = 0x21,
		RESCUE_BAT_MODE = 0x22,
		SET_RESCUE_BAT_MODE = 0x23,
		SET_POWER = 0x30,
		SET_POWER_MODE = 0x31,
		SET_POWER_VALUE = 0x32,
		STATUS = 0x40,
		USED_CHARGE_LIMIT = 0x41,
		BAT_CHARGE_LIMIT = 0x42,
		DCDC_CHARGE_LIMIT = 0x43,
		USER_CHARGE_LIMIT = 0x44,
		USED_DISCHARGE_LIMIT = 0x45,
		BAT_DISCHARGE_LIMIT = 0x46,
		DCDC_DISCHARGE_LIMIT = 0x47,
		USER_DISCHARGE_LIMIT = 0x48,
		SET_POWER_CONTROL_OFFSET = 0x60,
		REMAINING_BAT_CHARGE_POWER = 0x71,
		REMAINING_BAT_DISCHARGE_POWER = 0x72,
		EMERGENCY_POWER_STATUS = 0x73,
		SET_EMERGENCY_POWER = 0x74,
		SET_OVERRIDE_AVAILABLE_POWER = 0x75,
		SET_BATTERY_TO_CAR_MODE = 0x76,
		BATTERY_TO_CAR_MODE = 0x77,
		SET_BATTERY_BEFORE_CAR_MODE = 0x78,
		BATTERY_BEFORE_CAR_MODE = 0x79,
		GET_IDLE_PERIODS = 0x80,
		SET_IDLE_PERIODS = 0x81,
		IDLE_PERIOD = 0x82,
		IDLE_PERIOD_TYPE = 0x83,
		IDLE_PERIOD_DAY = 0x84,
		IDLE_PERIOD_START = 0x85,
		IDLE_PERIOD_END = 0x86,
		IDLE_PERIOD_HOUR = 0x87,
		IDLE_PERIOD_MINUTE = 0x88,
		IDLE_PERIOD_ACTIVE = 0x89,
		IDLE_PERIOD_CHANGE_MARKER = 0x8a,
		GET_POWER_SETTINGS = 0x8b,
		SET_POWER_SETTINGS = 0x8c,
		SETTINGS_CHANGE_MARKER = 0x8d,
		GET_MANUAL_CHARGE = 0x8e,
		START_MANUAL_CHARGE = 0x8f,
		START_EMERGENCYPOWER_TEST = 0x90,
		GET_GENERATOR_STATE = 0x91,
		SET_GENERATOR_MODE = 0x92,
		EMERGENCYPOWER_TEST_STATUS = 0x93,
		EPTEST_NEXT_TESTSTART = 0x94,
		EPTEST_START_COUNTER = 0x95,
		EPTEST_RUNNING = 0x96,
		REQ_GET_SYS_SPECS = 0x97, //TODO: Check Request is one number lower than response
		GET_SYS_SPECS = 0x98,
		SYS_SPEC = 0x99,
		SYS_SPEC_INDEX = 0x9a,
		SYS_SPEC_NAME = 0x9b,
		SYS_SPEC_VALUE_INT = 0x9c,
		SYS_SPEC_VALUE_STRING = 0x9d,
		SYS_STATUS = 0x9e,
		POWER_LIMITS_USED = 0x0100,
		MAX_CHARGE_POWER = 0x0101,
		MAX_DISCHARGE_POWER = 0x0102,
		DISCHARGE_START_POWER = 0x0103,
		POWERSAVE_ENABLED = 0x0104,
		WEATHER_REGULATED_CHARGE_ENABLED = 0x0105,
		WEATHER_FORECAST_MODE = 0x0106,
		MANUAL_CHARGE_START_COUNTER = 0x0150,
		MANUAL_CHARGE_ACTIVE = 0x0151,
		MANUAL_CHARGE_ENERGY_COUNTER = 0x0152,
		MANUAL_CHARGE_LASTSTART = 0x0153,
		REMOTE_CONTROL = 0x0200,
		DEACTIVATE_REMOTE_CONTROL = 0x0201,
		IP_REMOTE_CONTROL = 0x0202,
		EP_DELAY = 0x0203,
		SET_EP_DELAY = 0x0204,
		REMOTE_CONTROL_STATUS = 0x0205,
		IDLE_PERIOD_MIN_SOC_UCB = 0x0206,
		IDLE_PERIOD_MAX_SOC_UCB = 0x0207,
		SET_IDLE_PERIOD_MIN_SOC_UCB = 0x0208,
		SET_IDLE_PERIOD_MAX_SOC_UCB = 0x0209,
		REGULATOR_MODE = 0x0210,
		SET_REGULATOR_MODE = 0x0211,
		SUPPORTED_REGULATOR_MODES = 0x0212,
		EMERGENCY_POWER_OVERLOAD_STATUS = 0x0213,
		EMERGENCY_POWER_RETRY = 0x0214,
		DETECT_PHASE_OFFSET = 0x0217,
		PHASE_DETECTION_STATUS = 0x0218,
		PHASE_OFFSET = 0x0219,
		ABORT_PHASE_DETECTION = 0x0220,
		REGULATOR_STRATEGY = 0x0221,
		SET_REGULATOR_STRATEGY = 0x0222,
		POWER_PV_AC_OUT = 0x0223,
		PV_ENERGY = 0x0224,
		PARAM_AC_ENERGY_OUT = 0x0225,
		PARAM_AC_ENERGY_IN = 0x0226,
		PARAM_DC_IN = 0x0227,
		ENERGY_STORAGE_MODEL = 0x0228,
		PARAM_CURR_CHARGED_ENERGY = 0x0229,
		PARAM_CURR_CHARGED_USED_ENERGY = 0x0230,
		PARAM_DESIGN_CAPACITY = 0x0231,
		PARAM_FULL_CHARGED_CAPACITY = 0x0232,
		PARAM_USED_CAPACITY = 0x0233,
		SPECIFICATION_VALUES = 0x0234,
		PARAM_MAX_CHARGE_POWER = 0x0235,
		PARAM_MAX_DISCHARGE_POWER = 0x0236,
		PARAM_MAX_PV_POWER = 0x0237,
		PARAM_MAX_AC_POWER = 0x0238,
		PARAM_INSTALLED_BAT_CAP = 0x0239,
		PARAM_HYBRIT_SUPPORTED = 0x0240,
		PARAM_INIT_STATUS = 0x0241,
		EP_RESERVE = 0x0242,
		SEC_LIMITS = 0x0243,
		PARAM_SEL_TOTAL_MAX = 0x0244,
		PARAM_SEL_TOTAL_MIN = 0x0245,
		PARAM_SEL_PHASE_MAX_L1 = 0x0246,
		PARAM_SEL_PHASE_MAX_L2 = 0x0247,
		PARAM_SEL_PHASE_MAX_L3 = 0x0248,
		PARAM_SEL_PHASE_MIN_L1 = 0x0249,
		PARAM_SEL_PHASE_MIN_L2 = 0x0250,
		PARAM_SEL_PHASE_MIN_L3 = 0x0251,
		SEC_DEVICE_STATUS = 0x0252,
		PARAM_PVI_1 = 0x0253,
		PARAM_PVI_2 = 0x0254,
		PARAM_PVI_3 = 0x0255,
		PARAM_DCDC = 0x0256,
		PARAM_BAT = 0x0257,
		BAT_CURRENT_IN = 0x0258,
		BAT_CURRENT_OUT = 0x0259,
		MAX_DC_POWER = 0x0260,
		AC_REACTIVE_POWER = 0x0261,
		SET_EP_PARTIAL_GRID = 0x0262,
		GET_PARTIAL_GRID = 0x0263,
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
		PARAM_DEACTIVATE_SURPLUS_ACTOR = 0x040115,
		ALIVE = 0x050000,
		GENERAL_ERROR = 0x007fffff,

	}
}