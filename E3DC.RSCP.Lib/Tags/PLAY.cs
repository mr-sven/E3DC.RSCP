namespace E3DC.RSCP.Lib.Tags
{
    [TagGroup(0x25)]
    public enum PLAY : uint
    {
        DATA = 0x000001,
        SEND_TIME = 0x400001,
        GENERAL_ERROR = 0x7fffff,
    }
}
