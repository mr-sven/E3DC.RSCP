﻿namespace E3DC.RSCP.Lib.Tags
{
    [TagGroup(0x05)]
	public enum PM : uint
	{
		POWER_L1 = 0x01,
		POWER_L2 = 0x02,
		POWER_L3 = 0x03,
		ACTIVE_PHASES = 0x04,
		MODE = 0x05,
		ENERGY_L1 = 0x06,
		ENERGY_L2 = 0x07,
		ENERGY_L3 = 0x08,
		DEVICE_ID = 0x09,
		ERROR_CODE = 0x0a,
		SET_PHASE_ELIMINATION = 0x0b,
		FIRMWARE_VERSION = 0x0c,
		SET_FOR_EMERGENCY_TEST = 0x0d,
		IS_CAN_SILENCE = 0x0e,
		MAX_PHASE_POWER = 0x0f,
		VOLTAGE_L1 = 0x11,
		VOLTAGE_L2 = 0x12,
		VOLTAGE_L3 = 0x13,
		TYPE = 0x14,
		SET_TYPE = 0x15,
		GET_PHASE_ELIMINATION = 0x18,
		COMM_STATE = 0x50,
		CS_START_TIME = 0x51,
		CS_LAST_TIME = 0x52,
		CS_SUCC_FRAMES_ALL = 0x53,
		CS_SUCC_FRAMES_100 = 0x54,
		CS_EXP_FRAMES_ALL = 0x55,
		CS_EXP_FRAMES_100 = 0x56,
		CS_ERR_FRAMES_ALL = 0x57,
		CS_ERR_FRAMES_100 = 0x58,
		CS_UNK_FRAMES = 0x59,
		CS_ERR_FRAME = 0x5a,
		CONNECTED_DEVICES = 0xa0,
		CONNECTED_DEVICE = 0xa1,
		SET_DEVICE_NAME = 0xb0,
		DEVICE_NAME = 0xb1,
		SET_EXTERN_LOAD = 0xb3,
		DATA = 0x040000,
		INDEX = 0x040001,
		DEVICE_STATE = 0x060000,
		DEVICE_CONNECTED = 0x060001,
		DEVICE_WORKING = 0x060002,
		DEVICE_IN_SERVICE = 0x060003,
		GENERAL_ERROR = 0x007fffff,
	};
}