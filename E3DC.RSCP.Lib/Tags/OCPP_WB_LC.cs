﻿namespace E3DC.RSCP.Lib.Tags
{
    [TagGroup(0x2d)]
    public enum OCPP_WB_LC : uint
    {
        SET_ACCEPTANCE_RULE = 0x000001,
        GET_NON_ACCEPTED_EVCS = 0x000002,
        GET_ACCEPTED_EVCS = 0x000003,
        SET_ACCEPT_EVCS = 0x000004,
        SET_ACCEPT_ALL_EVCS = 0x000005,
        SET_BADGE_STRATEGY = 0x000006,
        SET_BADGE_ACQUISITION_MODE_START = 0x000007,
        SET_BADGE_ACQUISITION_MODE_STOP = 0x000008,
        GET_ACCEPTANCE_RULE = 0x000009,
        GET_BADGE_STRATEGY = 0x00000a,
        GET_ACCEPTED_EVCS_EXTENDED = 0x00000b,
        GET_EVCS_AVAILABLE_PARAMETERS_PROFILES = 0x00000c,
        GET_EVCS_DEVICE_ADVANCED_SETTINGS = 0x00000d,
        SET_EVCS_DEVICES_PARAMETERS = 0x00000e,
        SET_REMOVE_WB = 0x00000f,
        SET_FACTORY_RESET = 0x000010,
        GET_WALLBOXES_COUNT = 0x000011,
        GET_MAX_WALLBOXES_COUNT = 0x000012,
        GET_AVAILABLE_CPO_LIST = 0x000013,
        SET_CPO_BUTTON_STATE = 0x000014,
        GET_CPO_BUTTON_STATE = 0x000015,
        SET_CLEAN_CPO_SETTINGS = 0x000016,
        SET_CPO_MODE = 0x000017,
        SET_CPO_SETTINGS = 0x000018,
        GET_CPO_SETTINGS = 0x000019,
        GET_EVCS_DEVICE_CPO_CONNECTABLE = 0x00001a,
        SET_EVCS_DEVICE_CPO_CONNECTABLE = 0x00001b,
        GET_CPO_MODE = 0x00001c,
        GET_EVCS_CHARGING_SESSION_HISTORY_NB = 0x00001d,
        GET_EVCS_CHARGING_SESSION_HISTORY = 0x00001e,
        GET_EVCS_CHARGING_SESSIONS_ACTIVE = 0x00001f,
        GET_BADGES_PER_EVCS = 0x000020,
        SET_BADGES_PER_EVCS = 0x000021,
        GET_EVCS_LIST_PER_BADGE = 0x000022,
        SET_EVCS_LIST_PER_BADGE = 0x000023,
        PARAM_TOKEN = 0x400001,
        PARAM_ACCEPTANCE_RULE_VAL = 0x400002,
        PARAM_STATUS = 0x400003,
        PARAM_EVCS_DEVICE = 0x400004,
        PARAM_EVCS_DEVICE_HOSTNAME = 0x400005,
        PARAM_EVCS_DEVICE_IP = 0x400006,
        PARAM_EVCS_DEVICE_OCPP_ID = 0x400007,
        PARAM_EVCS_DEVICE_STATUS = 0x400008,
        PARAM_BADGE_STRATEGY = 0x400009,
        PARAM_EVCS_DEVICE_CONNECTOR = 0x40000a,
        PARAM_EVCS_DEVICE_CONNECTOR_ID = 0x40000b,
        PARAM_EVCS_DEVICE_CONNECTOR_PLUG_TYPE = 0x40000c,
        PARAM_EVCS_DEVICE_CONNECTOR_MAX_CURRENT_PER_PHASE = 0x40000d,
        PARAM_EVCS_DEVICE_CONNECTOR_MIN_CURRENT_PER_PHASE = 0x40000e,
        PARAM_EVCS_DEVICE_CONNECTOR_AUTH_OFFLINE_CHARGE_SESS = 0x40000f,
        PARAM_EVCS_DEVICE_OCPP_SETTINGS = 0x400010,
        PARAM_EVCS_DEVICE_OCPP_ACCEPT_UNKNOWN_OFFLINE_AUTH = 0x400011,
        PARAM_EVCS_DEVICE_OCPP_AUTHORIZATION_CACHE_ENABLED = 0x400012,
        PARAM_EVCS_DEVICE_OCPP_REMOTE_TRANSACTION_ENABLED = 0x400013,
        PARAM_EVCS_DEVICE_OCPP_BLINKS_NUMBER = 0x400014,
        PARAM_EVCS_DEVICE_OCPP_CLOCK_ALIGNED_DATA_INTERVAL = 0x400015,
        PARAM_EVCS_DEVICE_OCPP_CONNECTION_TIMEOUT = 0x400016,
        PARAM_EVCS_DEVICE_OCPP_CONNECTOR_PHASE_ROTATION = 0x400017,
        PARAM_EVCS_DEVICE_OCPP_HEARTBEAT_INTERVAL = 0x400018,
        PARAM_EVCS_DEVICE_OCPP_LIGHT_INTENSITY = 0x400019,
        PARAM_EVCS_DEVICE_OCPP_LOCAL_AUTHORIZE_OFFLINE = 0x40001a,
        PARAM_EVCS_DEVICE_OCPP_LOCAL_PRE_AUTHORIZE = 0x40001b,
        PARAM_EVCS_DEVICE_OCPP_MAX_ENERGY_ON_INVALID_ID = 0x40001c,
        PARAM_EVCS_DEVICE_PHASE_MAPPING = 0x40001d,
        PARAM_EVCS_DEVICE_CLUSTER_NAME = 0x40001e,
        PARAM_EVCS_DEVICE_NAME = 0x40001f,
        PARAM_EVCS_DEVICE_CONFIG_STATUS = 0x400020,
        PARAM_EVCS_PARAMETERS_PROFILE = 0x400021,
        PARAM_EVCS_DEVICE_DEFAULT_CHARGING_PROFILE = 0x400022,
        PARAM_EVCS_DEVICE_PLUG_TYPE_PER_CONNECTOR = 0x400023,
        PARAM_EVCS_DEVICE_ID = 0x400024,
        PARAM_EVCS_DEVICE_STATE = 0x400025,
        PARAM_WB_COUNT = 0x400026,
        PARAM_EVCS_DEVICE_CONNECTOR_COUNT = 0x400027,
        PARAM_CPO_INFO = 0x400028,
        PARAM_CPO_NAME = 0x400029,
        PARAM_CPO_URI = 0x40002a,
        PARAM_CPO_BUTTON = 0x40002b,
        PARAM_CPO_MODE = 0x40002c,
        PARAM_SETTINGS = 0x40002d,
        PARAM_CREDENTIALS = 0x40002e,
        PARAM_LOGIN = 0x40002f,
        PARAM_PASSWORD = 0x400030,
        PARAM_AUTH_TYPE = 0x400031,
        PARAM_CPO_ADDRESS = 0x400032,
        PARAM_CPO_PORT = 0x400033,
        PARAM_CPO_PATH = 0x400034,
        PARAM_CPO_UUID = 0x400035,
        PARAM_EVCS_CHARGING_SESSION_START_DATE = 0x400036,
        PARAM_EVCS_CHARGING_SESSION_STOP_DATE = 0x400037,
        PARAM_EVCS_CHARGING_SESSION_HISTORY_NB = 0x400038,
        PARAM_EVCS_CHARGING_SESSION_HISTORY = 0x400039,
        PARAM_EVCS_BADGE_ID = 0x40003a,
        PARAM_EVCS_BADGE_COMMENT = 0x40003b,
        PARAM_EVCS_ENERGY_CHARGED = 0x40003c,
        PARAM_EVCS_END_DATE = 0x40003d,
        PARAM_EVCS_TRANSACTION_ID = 0x40003e,
        PARAM_IS_EVCS_CHARGING_SESSIONS_ACTIVE = 0x40003f,
        PARAM_EVCS_DEVICE_CPO_CONFIG_STATUS = 0x400041,
        PARAM_EVCS_DEVICE_ASSOCIATED = 0x400042,
        PARAM_EVCS_DEVICE_BADGE = 0x400044,
        PARAM_EVCS_BADGE_ASSOCIATED = 0x400045,
        PARAM_EVCS_BADGE_MASK = 0x400048,
        PARAM_EVCS_BADGE_MASK_INDEX = 0x400049,
        GENERAL_ERROR = 0x7fffff,
    }
}