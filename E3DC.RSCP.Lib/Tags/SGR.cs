﻿namespace E3DC.RSCP.Lib.Tags
{
    [TagGroup(0x12)]
	public enum SGR : uint
	{
		STATE = 0x01,
		READY_TO_USE = 0x02,
		HW_PROVIDER_LIST = 0x03,
		HW_PROVIDER = 0x04,
		NAME = 0x05,
		SET_AKTIV = 0x06,
		SET_COOLDOWN_START = 0x07,
		COOLDOWN_END = 0x08,
		SET_USED_POWER = 0x09,
		USED_POWER = 0x10,
		SET_STATE = 0x11,
		DATA = 0x040000,
		INDEX = 0x040001,
		GENERAL_ERROR = 0x007fffff,
	}
}