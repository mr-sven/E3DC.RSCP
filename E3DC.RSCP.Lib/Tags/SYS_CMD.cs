﻿namespace E3DC.RSCP.Lib.Tags
{
    [TagGroup(0xf9)]
    public enum SYS_CMD : uint
    {
        FB = 0x000001,
        REQ_SYSTEM_REBOOT = 0x000005,
        REQ_SYSTEM_KILL = 0x000006,
        REQ_SERVER_SOCKETS = 0x000007,
        REQ_SYS_EXECUTE = 0x000010,
        REQ_SYS_EXECUTE_CANCEL = 0x000011,
        REQ_SHELL_REGISTER = 0x000012,
        REQ_SHELL_UNREGISTER = 0x000013,
        REQ_SHELL_IN = 0x000014,
        REQ_SHELL_OUT = 0x000015,
        REQ_REGISTER_REMOTE_DEBUG = 0x000016,
        REQ_UNREGISTER_REMOTE_DEBUG = 0x000017,
        REQ_ALL_DEBUG_DEVICES = 0x000018,
        REQ_ADD_DEBUG_DEVICE = 0x000019,
        REQ_SET_LEVEL = 0x000020,
        REQ_REMOVE_DEBUG_DEVICE = 0x000021,
        REQ_LOG_MSG = 0x000022,
        REQ_INLINE_SYS_EXECUTE = 0x000023,
        REQ_VIRTUAL_CONNECTIONS = 0x000024,
        REQ_SYS_EXECUTE_INTERACTIVE = 0x000026,
        REQ_REGISTER_SYS_OBSERVER = 0x000100,
        REQ_UNREGISTER_SYS_OBSERVER = 0x000101,
        REQ_CURRENT_FOLDER = 0x000102,
        REQ_LIST_ACTIVATOR_STATUS = 0x000103,
        REQ_FILE_LIST = 0x000104,
        REQ_MD5_HASH = 0x000105,
        REQ_FILE_CONTENT = 0x000106,
        REQ_CREATE_FOLDER = 0x000107,
        REQ_APPEND_FILE_CONTENT = 0x000108,
        REQ_RENAME_FILE = 0x000109,
        REQ_CREATE_SYM_LINK = 0x00010b,
        REQ_DELETE_FILE = 0x00010d,
        REQ_DELETE_FOLDER = 0x00010e,
        REQ_REGISTER_PROC_OBS = 0x000200,
        REQ_PROC_ID = 0x000203,
        REQ_PROC_FILE = 0x000204,
        REQ_PROC_LIST = 0x000205,
        REQ_UNREGISTER_PROC_OBS = 0x000206,
        REGISTER_PUSH_SERVICE = 0x000207,
        PUSH_SERVICE_ID = 0x000208,
        PUSH_MESSAGE = 0x000209,
        PUSH_SERVICE_IDRL = 0x000210,
        PUSH_MESSAGE_CONTENT = 0x000211,
        UNREGISTER_PUSH_SERVICE = 0x000212,
        NAME = 0x00b001,
        ID = 0x00b002,
        LEVEL = 0x00b003,
        MESSAGE = 0x00b004,
        STATUS = 0x00b005,
        VERSION = 0x00b006,
        FOLDER_NAME = 0x00b007,
        FILE = 0x00b008,
        TYPE = 0x00b009,
        SIZE = 0x00b00a,
        VALUE = 0x00b00c,
        INDEX_FROM = 0x00b00d,
        INDEX_UNTIL = 0x00b00e,
        DATA_LEN = 0x00b00f,
        DATA = 0x00b010,
        SRC_FILE = 0x00b011,
        DST_FILE = 0x00b012,
        LAST_ACCESS = 0x00b013,
        LAST_MODIFICATION = 0x00b014,
        LAST_STATUS_CHANGE = 0x00b015,
        PROC_LIST_ENTRY = 0x00b016,
        PROC_LIST_CURR_FOLDER = 0x00b017,
        REQ_INJECT_TOUCH_EVENT = 0x00b018,
        SYSTEM_REBOOT = 0x080005,
        SYSTEM_KILL = 0x080006,
        SERVER_SOCKETS = 0x080007,
        SSOCKET = 0x080008,
        SYS_EXECUTE = 0x080010,
        SYS_EXECUTE_CANCEL = 0x080011,
        SHELL_REGISTER = 0x080012,
        SHELL_UNREGISTER = 0x080013,
        SHELL_IN = 0x080014,
        SHELL_OUT = 0x080015,
        REMOTE_DEBUG_REGISTERED = 0x080016,
        REMOTE_DEBUG_UNREGISTERED = 0x080017,
        INLINE_SYS_EXECUTE = 0x080023,
        VIRTUAL_CONNECTIONS = 0x080024,
        VIRTUAL_CONNECTION = 0x080025,
        SYS_EXECUTE_INTERACTIVE = 0x080026,
        SYS_OBSERVER_REGISTERED = 0x080100,
        SYS_OBSERVER_UNREGISTERED = 0x080101,
        CURRENT_FOLDER = 0x080102,
        LIST_ACTIVATOR_STATUS = 0x080103,
        FILE_LIST = 0x080104,
        MD5_HASH = 0x080105,
        FILE_CONTENT = 0x080106,
        FOLDER_CREATED = 0x080107,
        FILE_CONTENT_APPENDED = 0x080108,
        FILE_RENAMED = 0x08010a,
        SYM_LINK_CREATED = 0x08010b,
        FILE_DELETED = 0x08010d,
        FOLDER_DELETED = 0x08010e,
        PROC_OBS_REGISTERED = 0x080200,
        PROC_ID = 0x080203,
        PROC_FILE = 0x080204,
        PROC_LIST = 0x080205,
        PROC_OBS_UNREGISTERED = 0x080206,
        ACTIVATOR_STATUS = 0x090103,
        PARAM_FB_SCREEN_WIDTH = 0x400001,
        PARAM_FB_SCREEN_HEIGHT = 0x400002,
        PARAM_FB_BPS = 0x400003,
        PARAM_FB_RAW_DATA = 0x400004,
        PARAM_FB_SCALE = 0x400005,
        PARAM_INJECT_TOUCH_EVENT_POS_Y = 0x400006,
        PARAM_INJECT_TOUCH_EVENT_POS_X = 0x400007,
        PARAM_FB_ALIGNMENT = 0x400008,
        PARAM_FB_INTERPOLATE = 0x400009,
        GENERAL_ERROR = 0x7fffff,
    }
}
