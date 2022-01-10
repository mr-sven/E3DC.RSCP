using Tags = E3DC.RSCP.Lib.Tags;
using E3DC.RSCP.Lib;
using System.Text.Json;
using System.Text.Json.Serialization;
using E3DC.RSCP.Lib.Json;

const string username = "username@example.com";
const string password = "password";
const string encryptionKey = "key";
const string hostname = "localhost";

RscpClient client = new(username, password, encryptionKey);
try
{
    Console.WriteLine($"RSCP Connection establishing");
    UserLevel level = await client.ConnectAsync(hostname);
    Console.WriteLine($"RSCP Connection established with userlevel: {level}");

    Frame infoFrame = new()
    {
        [Tags.INFO.SERIAL_NUMBER] = null,
        [Tags.INFO.MAC_ADDRESS] = null,
        [Tags.INFO.SW_RELEASE] = null,
        [Tags.EMS.REQ_GET_SYS_SPECS] = null,
        [Tags.DCDC.DATA] = new Container()
        {
            [Tags.DCDC.INDEX] = 0,
            [Tags.DCDC.FIRMWARE_VERSION] = null,
            [Tags.DCDC.FPGA_FIRMWARE] = null,
            [Tags.DCDC.SERIAL_NUMBER] = null,
            [Tags.DCDC.BOARD_VERSION] = null,
        },
        [Tags.PVI.DATA] = new Container()
        {
            [Tags.PVI.INDEX] = 0,
            [Tags.PVI.SERIAL_NUMBER] = null,
            [Tags.PVI.VERSION] = null,
        }
    };

    Frame resultFrame = await client.SendAsync(infoFrame);

    JsonSerializerOptions serializeOptions = new()
    {
        WriteIndented = true,
        Converters =
        {
            new JsonStringEnumConverter(),
            new FrameConverter(),
            new ContainerConverter()
        }
    };
    string json = JsonSerializer.Serialize(resultFrame, serializeOptions);
    Console.WriteLine(json);
}
catch (Exception ex)
{

    Console.WriteLine($"Exception[{ex.GetType()}]: {ex.Message}");
    Console.WriteLine($"Source: {ex.Source}");
    Console.WriteLine($"StackTrace: {ex.StackTrace}");
}
finally
{
    client.Disconnect();
    Console.WriteLine($"RSCP Connection closed");
}