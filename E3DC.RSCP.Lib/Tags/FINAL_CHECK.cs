﻿namespace E3DC.RSCP.Lib.Tags
{
    [TagGroup(0xfe)]
    public enum FINAL_CHECK : uint
    {
        PARAM_TEST_PASSED_ON = 0x000000,
        REPORT = 0x000001,
        SERIAL_FOR_ASSEMBLY = 0x000002,
        ERROR_MESSAGE = 0x000003,
        SERIAL_STATUS = 0x000004,
        SUBMIT_TEST_PROTOCOL = 0x000005,
        PARAM_SN = 0x400001,
        PARAM_STATUS = 0x400002,
        PARAM_START = 0x400003,
        PARAM_END = 0x400004,
        PARAM_META = 0x400005,
        PARAM_LOG = 0x400006,
        PARAM_TICKET = 0x400007,
        DEVICE_PROPERTY = 0x400008,
        DEVICE_PROPERTY_MODULE_NAME = 0x400009,
        DEVICE_PROPERTY_PROP_NAME = 0x40000a,
        DEVICE_PROPERTY_ACTUAL_VALUE = 0x40000b,
        PARAM_ASSEMBLY_SERIAL = 0x40000c,
        PARAM_SERIAL_NUMBER = 0x40000d,
        ERROR_TAG_REFERENCE = 0x40000e,
        ERROR_TEXT = 0x40000f,
        PARAM_TEST_STATUS = 0x400011,
        PARAM_SUBMITTED_ON = 0x400012,
        PARAM_PROTOCOL = 0x400013,
        PARAM_PROTOCOL_SAVED = 0x400014,
        PARAM_TEST_PASSED = 0x400016,
        GENERAL_ERROR = 0x7fffff,
    }
}
