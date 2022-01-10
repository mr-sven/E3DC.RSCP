using System.Reflection;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace E3DC.RSCP.Lib.Json
{
    public class ContainerConverter : JsonConverter<Container>
    {
        private readonly Dictionary<string, Type> tagGroups = new();
        public ContainerConverter() : base()
        {
            foreach (Type type in typeof(Tags.TagGroupAttribute).Assembly.GetTypes())
            {
                Tags.TagGroupAttribute? tagInfo = type.GetCustomAttribute<Tags.TagGroupAttribute>();
                if (tagInfo == null || Enum.GetUnderlyingType(type) != typeof(uint))
                {
                    continue;
                }
                tagGroups.Add(type.Name, type);
            }
        }

        public override Container? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TokenType != JsonTokenType.StartObject)
            {
                throw new JsonException();
            }

            Container container = new();
            while (reader.Read())
            {
                if (reader.TokenType == JsonTokenType.EndObject)
                {
                    return container;
                }
                if (reader.TokenType != JsonTokenType.PropertyName)
                {
                    throw new JsonException();
                }
                string propertyName = reader.GetString() ?? string.Empty;
                string[] parts = propertyName.Split('_', 2);

                if (!tagGroups.ContainsKey(parts[0]))
                {
                    throw new JsonException($"Unknown Tag group: {parts[0]}");
                }

                if (!Enum.TryParse(tagGroups[parts[0]], parts[1], out object? result))
                {
                    throw new JsonException($"Unknown Tag: {propertyName}");
                }
                //TODO: Type Parsing could be complex, there is a Tag-Type-Mapping required
                throw new JsonException($"Not Supported");
            }
            return null;
        }

        public override void Write(Utf8JsonWriter writer, Container container, JsonSerializerOptions options)
        {
            writer.WriteStartObject();
            foreach (KeyValuePair<Enum, object?> item in container)
            {
                writer.WritePropertyName(Container.EnumToString(item.Key));
                JsonSerializer.Serialize(writer, item.Value, options);
            }
            writer.WriteEndObject();
        }
    }
}
