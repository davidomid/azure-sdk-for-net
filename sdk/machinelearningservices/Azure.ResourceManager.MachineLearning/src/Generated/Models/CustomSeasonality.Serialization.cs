// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    public partial class CustomSeasonality : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("value");
            writer.WriteNumberValue(Value);
            writer.WritePropertyName("mode");
            writer.WriteStringValue(Mode.ToString());
            writer.WriteEndObject();
        }

        internal static CustomSeasonality DeserializeCustomSeasonality(JsonElement element)
        {
            int value = default;
            SeasonalityMode mode = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    value = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("mode"))
                {
                    mode = new SeasonalityMode(property.Value.GetString());
                    continue;
                }
            }
            return new CustomSeasonality(mode, value);
        }
    }
}
