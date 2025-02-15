// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataFactory.Models
{
    public partial class IntegrationRuntimeDataProxyProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(ConnectVia))
            {
                writer.WritePropertyName("connectVia");
                writer.WriteObjectValue(ConnectVia);
            }
            if (Optional.IsDefined(StagingLinkedService))
            {
                writer.WritePropertyName("stagingLinkedService");
                writer.WriteObjectValue(StagingLinkedService);
            }
            if (Optional.IsDefined(Path))
            {
                writer.WritePropertyName("path");
                writer.WriteStringValue(Path);
            }
            writer.WriteEndObject();
        }

        internal static IntegrationRuntimeDataProxyProperties DeserializeIntegrationRuntimeDataProxyProperties(JsonElement element)
        {
            Optional<EntityReference> connectVia = default;
            Optional<EntityReference> stagingLinkedService = default;
            Optional<string> path = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("connectVia"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    connectVia = EntityReference.DeserializeEntityReference(property.Value);
                    continue;
                }
                if (property.NameEquals("stagingLinkedService"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    stagingLinkedService = EntityReference.DeserializeEntityReference(property.Value);
                    continue;
                }
                if (property.NameEquals("path"))
                {
                    path = property.Value.GetString();
                    continue;
                }
            }
            return new IntegrationRuntimeDataProxyProperties(connectVia.Value, stagingLinkedService.Value, path.Value);
        }
    }
}
