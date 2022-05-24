# E3/DC RSCP Connection Lib

This lib is a small RSCP connector based on .Net 6.

* omit the use of double namings and wrappings
* implemented native type parsing without wrapping types
* array indexer at container for easy access.

The response bit in the Tag field is ignored due the fact there is no known need to take care on this.

I implemented `System.Text.Json` serializer for JSON converting. For converting JSON to RSCP there is a DataType mapping required for correct conversation, but this is not implemented at the moment.

The encryption uses the `BouncyCastle.NetCore` lib with sample source from [@Spontifixu](https://github.com/Spontifixus/) repo [am-e3dc](https://github.com/Spontifixus/am-e3dc).

The list of Tag enums and other Enums is based on various implementations (original RSCP Example, python libs, etc.)

The CRC32 Code is used from Force.CRC32, but due the lack of .Net 6 availablibity, the source is copied.

## Usage

The basic usage can be checked in the [Example Project](/E3DC.RSCP.Example).

```csharp
RscpClient client = new(username, password, encryptionKey);

Console.WriteLine($"RSCP Connection establishing");
UserLevel level = await client.ConnectAsync(hostname);

Console.WriteLine($"RSCP Connection established with userlevel: {level}");

Frame infoFrame = new()
{
    [Tags.INFO.SERIAL_NUMBER] = null,
    [Tags.INFO.MAC_ADDRESS] = null,
    [Tags.INFO.SW_RELEASE] = null,
};

Frame resultFrame = await client.SendAsync(infoFrame);

Console.WriteLine($"Serial Number: {resultFrame[Tags.INFO.SERIAL_NUMBER]}");

// get typed value
string macAddress = resultFrame.Get<string>(Tags.INFO.MAC_ADDRESS);
```

To create a Frame or Container, you can use array indexer at Constructor.

```csharp
Frame frame = new()
{
    [Tags.EMS.POWER_PV] = null,
    [Tags.EMS.POWER_BAT] = null,
    [Tags.EMS.POWER_GRID] = null,
};
```

If you want to request multiple values of the same tag, you have to use object brackets. The array indexer `[]` uses the indexer, the object brackets `{}` uses the `Add` function.

```csharp
Frame frame = new()
{
    [Tags.PVI.DATA] = new Container()
    {
        { Tags.PVI.INDEX, 0 },
        { Tags.PVI.DC_POWER, (byte)0 },
        { Tags.PVI.DC_POWER, (byte)1 },
    },
};
```

## ToDo
- [x] correct implement parsing and wirting BitField
- [ ] JSON to RSCP converter with type mapping
- [x] Write multiple values of the same Tag to bytes