namespace E3DC.RSCP.Lib.Tags
{
    [TagGroup(0x0c)]
    public enum SYS : uint
    {
        SYSTEM_REBOOT = 0x000001,
        IS_SYSTEM_REBOOTING = 0x000002,
        RESTART_APPLICATION = 0x000003,
        SCRIPT_FILE_LIST = 0x000010,
        SCRIPT_FILE = 0x000011,
        EXECUTE_SCRIPT = 0x000015,
        REQ_SYSTEM_SHUTDOWN = 0x000016,
        IS_SYSTEM_SHUTING_DOWN = 0x000017,
        GENERAL_ERROR = 0x7fffff,
    }
}