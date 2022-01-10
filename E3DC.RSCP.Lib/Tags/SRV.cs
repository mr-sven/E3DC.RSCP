namespace E3DC.RSCP.Lib.Tags
{
    [TagGroup(0x08)]
	public enum SRV : uint
	{
		IS_ONLINE = 0x01,
		ADD_USER = 0x02,
		SET_LOCAL_USER = 0x03,
		GENERAL_ERROR = 0x007fffff,
	}
}