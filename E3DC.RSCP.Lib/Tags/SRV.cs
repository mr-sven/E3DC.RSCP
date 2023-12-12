namespace E3DC.RSCP.Lib.Tags
{
    [TagGroup(0x08)]
    public enum SRV : uint
    {
        IS_ONLINE = 0x000001,
        ADD_USER = 0x000002,
        SET_LOCAL_USER = 0x000003,
        CREATE_USER = 0x000004,
        CREATE_USER_STATUS = 0x000005,
        NAME = 0x400001,
        STREET = 0x400002,
        STREET_NO = 0x400003,
        POSTCODE = 0x400004,
        CITY = 0x400005,
        COUNTRY = 0x400006,
        FON = 0x400007,
        E_MAIL = 0x400008,
        SURNAME = 0x400009,
        GENERAL_ERROR = 0x7fffff,
    }
}
