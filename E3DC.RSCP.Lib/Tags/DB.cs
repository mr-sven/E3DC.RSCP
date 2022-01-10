﻿namespace E3DC.RSCP.Lib.Tags
{
    [TagGroup(0x06)]
	public enum DB : uint
	{

		GRAPH_INDEX = 0x01,
		BAT_POWER_IN = 0x02,
		BAT_POWER_OUT = 0x03,
		DC_POWER = 0x04,
		GRID_POWER_IN = 0x05,
		GRID_POWER_OUT = 0x06,
		CONSUMPTION = 0x07,
		PM_0_POWER = 0x08,
		PM_1_POWER = 0x09,
		BAT_CHARGE_LEVEL = 0x0a,
		BAT_CYCLE_COUNT = 0x0b,
		CONSUMED_PRODUCTION = 0x0c,
		AUTARKY = 0x0d,
		SUM_CONTAINER = 0x10,
		VALUE_CONTAINER = 0x20,
		HISTORY_DATA_DAY = 0x0100,
		HISTORY_TIME_START = 0x0101,
		HISTORY_TIME_INTERVAL = 0x0102,
		HISTORY_TIME_SPAN = 0x0103,
		HISTORY_UTC_TIME_START = 0x0104,
		HISTORY_DATA_WEEK = 0x0200,
		HISTORY_DATA_MONTH = 0x0300,
		HISTORY_DATA_YEAR = 0x0400,
		SYNC_HIST = 0x0500,
		VACUUM_HIST = 0x0501,
		SYNC_BPU = 0x0502,
		VACUUM_BPU = 0x0503,
		SYNC_DCB = 0x0504,
		VACUUM_DBC = 0x0505,
		SYNC_BPU_CONF = 0x0506,
		VACUUM_BPU_CONF = 0x0507,
		SYNC_DCB_CONF = 0x0508,
		VACUUM_DBC_CONF = 0x0509,
		SYNC_WALLBOX = 0x050a,
		VACUUM_WALLBOX = 0x050b,
		SYNC_PV_DEBUG = 0x050c,
		VACUUM_PV_DEBUG = 0x050d,
		SYNC_CONFIG = 0x050e,
		VACUUM_CONFIG = 0x050f,
		SET_SYNC_TIME = 0x0510,
		PVI_DIAL_RECORDINGS = 0x0511,
		SYNC_BAT_DIAGNOSE = 0x0512,
		VACUUM_BAT_DIAGNOSE = 0x0513,
		SYNC_EXT_LG = 0x0514,
		VACUUM_EXT_LG = 0x0515,
		CLEAN_DATABASE = 0x0516,
		PAR_TIME_MIN = 0x300000,
		PAR_TIME_MAX = 0x300001,
		PARAM_ROW = 0x300002,
		PARAM_COLUMN = 0x300003,
		PARAM_INDEX = 0x300004,
		PARAM_VALUE = 0x300005,
		PARAM_MAX_ROWS = 0x300006,
		PARAM_TIME = 0x300007,
		PARAM_VERSION = 0x300008,
		PARAM_HEADER = 0x300009,
		PARAM_PRODUCTION_L1 = 0x300010,
		PARAM_PRODUCTION_L2 = 0x300011,
		PARAM_PRODUCTION_L3 = 0x300012,
		PARAM_DC_POWER_S1 = 0x300013,
		PARAM_DC_POWER_S2 = 0x300014,
		PARAM_DC_POWER_S3 = 0x300015,
		GENERAL_ERROR = 0x007fffff,
	}
}