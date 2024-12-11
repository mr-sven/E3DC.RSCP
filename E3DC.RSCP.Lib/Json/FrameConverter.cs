using System.Text.Json;
using System.Text.Json.Serialization;

namespace E3DC.RSCP.Lib.Json
{
    public class FrameConverter : JsonConverter<Frame>
    {
        public override Frame? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TokenType != JsonTokenType.StartObject)
            {
                throw new JsonException();
            }

            Frame frame = [];
            while (reader.Read())
            {
                if (reader.TokenType == JsonTokenType.EndObject)
                {
                    return frame;
                }
                if (reader.TokenType != JsonTokenType.PropertyName)
                {
                    throw new JsonException();
                }
                string propertyName = reader.GetString() ?? string.Empty;
                switch (propertyName)
                {
                    case "TIMESTAMP":
                        frame.Timestamp = JsonSerializer.Deserialize<DateTime>(ref reader, options);
                        break;
                    case "ITEMS":
                        frame.AddRange(JsonSerializer.Deserialize<Container>(ref reader, options)?.GetEnumerator());
                        break;
                    default:
                        throw new JsonException();
                }
            }
            return null;
        }

        public override void Write(Utf8JsonWriter writer, Frame frame, JsonSerializerOptions options)
        {
            writer.WriteStartObject();

            writer.WritePropertyName("TIMESTAMP");
            JsonSerializer.Serialize(writer, frame.Timestamp, options);

            writer.WritePropertyName("ITEMS");
            JsonSerializer.Serialize(writer, (Container)frame, options);

            writer.WriteEndObject();
        }
    }
}