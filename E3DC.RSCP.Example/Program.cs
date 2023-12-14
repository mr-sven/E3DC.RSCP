using Tags = E3DC.RSCP.Lib.Tags;
using E3DC.RSCP.Lib;
using System.Text.Json;
using System.Text.Json.Serialization;
using E3DC.RSCP.Lib.Json;

using Org.BouncyCastle.Crypto.Engines;
using Org.BouncyCastle.Crypto.Modes;
using Org.BouncyCastle.Crypto.Paddings;
using Org.BouncyCastle.Crypto.Parameters;



Frame frame = new()
{
    [Tags.RSCP.AUTHENTICATION] = new Container()
    {
        [Tags.RSCP.AUTHENTICATION_USER] = "blah",
        [Tags.RSCP.AUTHENTICATION_PASSWORD] = "blubb",
        [Tags.RSCP.USER_LEVEL] = null
    }
};
frame.Timestamp = DateTime.UnixEpoch;

//Console.WriteLine(BitConverter.ToString(frame.GetBytes()));



const int IV_SIZE = 32;

byte[] ivEncryption = Enumerable.Repeat((byte)0xff, IV_SIZE).ToArray();
byte[] encryptionPassword = Enumerable.Repeat((byte)0xff, IV_SIZE).ToArray();
System.Text.Encoding.ASCII.GetBytes("RSCP_KEY").CopyTo(encryptionPassword, 0);
byte[] data = System.Text.Encoding.ASCII.GetBytes("11122233344455566677788899900012");

Console.WriteLine(BitConverter.ToString(encryptionPassword));
Console.WriteLine(BitConverter.ToString(ivEncryption));

PaddedBufferedBlockCipher encryptAlg = new PaddedBufferedBlockCipher(new CbcBlockCipher(new RijndaelEngine(256)), new ZeroBytePadding());

// Algo needs to reinit with last IV, because DoFinal resets the IV
encryptAlg!.Init(true, new ParametersWithIV(new KeyParameter(encryptionPassword), ivEncryption, 0, IV_SIZE));
byte[] cipherTextBytes = new byte[encryptAlg!.GetOutputSize(data.Length)];
int length = encryptAlg.ProcessBytes(data, cipherTextBytes, 0);
length += encryptAlg.DoFinal(cipherTextBytes, length);

Console.WriteLine(BitConverter.ToString(data));
Console.WriteLine(BitConverter.ToString(cipherTextBytes));
// some evil behavior of bouncy castle, discoused in meany threads,
// on n times IV_SIZE the cipher adds a full block of padding (zero) to output.
// Encryption on E3DC does not support this, and dies, so remove block of nothing
if (data.Length % IV_SIZE == 0 && length > data.Length)
{
    cipherTextBytes = cipherTextBytes[..data.Length];
}
Array.Copy(cipherTextBytes, cipherTextBytes.Length - ivEncryption.Length, ivEncryption, 0, ivEncryption.Length);

Console.WriteLine(BitConverter.ToString(cipherTextBytes));
Console.WriteLine(BitConverter.ToString(ivEncryption));


/*
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
*/