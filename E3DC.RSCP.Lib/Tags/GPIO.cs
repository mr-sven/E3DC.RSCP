namespace E3DC.RSCP.Lib.Tags
{
    [TagGroup(0x19)]
	public enum GPIO : uint
	{

		SET = 0x01,
		GET = 0x02,
		LIST = 0x03,
		TUPEL = 0x060001,
		NUMBER = 0x060002,
		NAME = 0x060003,
		VALUE = 0x060004,
		GENERAL_ERROR = 0x007fffff,
	}
}