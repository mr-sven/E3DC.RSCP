namespace E3DC.RSCP.Lib.Tags
{
    [TagGroup(0x16)]
	public enum KNX : uint
	{

		SET = 0x01,
		MAC = 0x02,
		IP = 0x03,
		GENERAL_ERROR = 0x007fffff,
	}
}