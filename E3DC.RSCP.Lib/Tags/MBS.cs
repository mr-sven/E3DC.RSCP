﻿namespace E3DC.RSCP.Lib.Tags
{
    [TagGroup(0x13)]
    public enum MBS : uint
    {
        MODBUS_ENABLED = 0x000001,
        MODBUS_CONNECTORS = 0x000002,
        REQ_ENABLE_CONNECTOR = 0x000003,
        REQ_DISABLE_CONNECTOR = 0x000004,
        CHANGE_SETTING = 0x000005,
        REQ_CHANGE_SETTING_ERR = 0x000006,
        MODBUS_CONNECTOR_CONTAINER = 0x010002,
        MODBUS_CONNECTOR_NAME = 0x010003,
        MODBUS_CONNECTOR_ID = 0x010004,
        MODBUS_CONNECTOR_ENABLED = 0x010005,
        MODBUS_CONNECTOR_SETUP = 0x010006,
        MODBUS_SETUP_NAME = 0x010007,
        MODBUS_SETUP_TYPE = 0x010008,
        MODBUS_SETUP_VALUE = 0x010009,
        MODBUS_SETUP_VALUES = 0x01000a,
        MODBUS_SETUP_VALUE_STRING = 0x01000b,
        REQ_SET_MODBUS_ENABLED = 0x700001,
        GENERAL_ERROR = 0x7fffff,
    }
}