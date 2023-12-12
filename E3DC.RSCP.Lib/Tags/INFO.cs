﻿namespace E3DC.RSCP.Lib.Tags
{
    [TagGroup(0x0a)]
    public enum INFO : uint
    {
        SERIAL_NUMBER = 0x000001,
        PRODUCTION_DATE = 0x000002,
        MODULES_SW_VERSIONS = 0x000003,
        MODULE_SW_VERSION = 0x000004,
        MODULE = 0x000005,
        VERSION = 0x000006,
        A35_SERIAL_NUMBER = 0x000007,
        IP_ADDRESS = 0x000008,
        SUBNET_MASK = 0x000009,
        MAC_ADDRESS = 0x00000a,
        GATEWAY = 0x00000b,
        DNS = 0x00000c,
        DHCP_STATUS = 0x00000d,
        TIME = 0x00000e,
        UTC_TIME = 0x00000f,
        TIME_ZONE = 0x000010,
        INFO = 0x000011,
        SET_IP_ADDRESS = 0x000012,
        SET_SUBNET_MASK = 0x000013,
        SET_DHCP_STATUS = 0x000014,
        SET_GATEWAY = 0x000015,
        SET_DNS = 0x000016,
        SET_TIME = 0x000017,
        SET_TIME_ZONE = 0x000018,
        SW_RELEASE = 0x000019,
        SET_GUI_TARGET = 0x00001a,
        GUI_TARGET = 0x00001b,
        PLATFORM_TYPE = 0x00001c,
        IS_CALIBRATED = 0x00001d,
        CALIBRATION_CHECK = 0x00001e,
        RESET_CALIBRATION = 0x00001f,
        HW_TIME = 0x000020,
        SET_TIME_UTC = 0x000021,
        SET_HW_TIME = 0x000022,
        SET_FACILITY = 0x000023,
        GET_FACILITY = 0x000024,
        NAME = 0x000025,
        STREET = 0x000026,
        STREET_NO = 0x000027,
        POSTCODE = 0x000028,
        CITY = 0x000029,
        FON = 0x00002a,
        E_MAIL = 0x00002b,
        COUNTRY = 0x00002c,
        GET_FS_USAGE = 0x00002d,
        FS_SIZE = 0x00002e,
        FS_USED = 0x00002f,
        FS_AVAILABLE = 0x000030,
        FS_USE_PERCENT = 0x000031,
        INODES = 0x000032,
        INODES_USED = 0x000033,
        INODES_AVAILABLE = 0x000034,
        INODES_USE_PERCENT = 0x000035,
        SURNAME = 0x000036,
        UPNP_STATUS = 0x000037,
        SET_UPNP_STATUS = 0x000038,
        IS_OVP_POSSIBLE = 0x000039,
        IS_RSCP_PASSWORD_SET = 0x00003a,
        SET_EULA_VERSION = 0x00003b,
        SET_EULA_CHECKSUM = 0x00003c,
        SET_WAIT_FOR_EULA = 0x00003d,
        ASSEMBLY_SERIAL_NUMBER = 0x00003e,
        SET_UUID = 0x00003f,
        GET_UUID = 0x000040,
        GET_SUID = 0x000041,
        IS_OVP2_POSSIBLE = 0x000042,
        LC_REQ_SET_TIME = 0x000043,
        LC_REQ_GET_IS_TIME_SYNCHRO = 0x000044,
        LC_REQ_GET_SYSTEM_TIME = 0x000045,
        LC_REQ_GET_TIME_TIMEZONE = 0x000046,
        GET_IS_MULTI_GC_POSSIBLE = 0x000047,
        GET_VALUES_PRESENTATION_SETTINGS = 0x000048,
        LC_PARAM_TOKEN = 0x400001,
        LC_PARAM_STATUS = 0x400002,
        LC_PARAM_TIME_SYSTEM = 0x400003,
        LC_PARAM_TIMEZONE = 0x400004,
        LC_PARAM_TIME_DIFF = 0x400005,
        LC_PARAM_TIME_BROWSER = 0x400006,
        LC_PARAM_TIME_SYNCHRO_STATE = 0x400007,
        GENERAL_ERROR = 0x7fffff,
    }
}
