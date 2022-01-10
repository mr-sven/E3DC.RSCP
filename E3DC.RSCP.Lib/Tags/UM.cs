namespace E3DC.RSCP.Lib.Tags
{
    [TagGroup(0x0d)]
	public enum UM : uint
	{
		UPDATE_STATUS = 0x01,
		UPDATE_DCDC = 0x02,
		CHECK_FOR_UPDATES = 0x03,
		GENERAL_ERROR = 0x007fffff,
	}
}