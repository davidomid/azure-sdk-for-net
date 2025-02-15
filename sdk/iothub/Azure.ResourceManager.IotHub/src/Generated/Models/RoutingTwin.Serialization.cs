// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.IotHub.Models
{
    public partial class RoutingTwin : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Tags))
            {
                writer.WritePropertyName("tags");
#if NET6_0_OR_GREATER
				writer.WriteRawValue(Tags);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(Tags.ToString()).RootElement);
#endif
            }
            if (Optional.IsDefined(Properties))
            {
                writer.WritePropertyName("properties");
                writer.WriteObjectValue(Properties);
            }
            writer.WriteEndObject();
        }
    }
}
