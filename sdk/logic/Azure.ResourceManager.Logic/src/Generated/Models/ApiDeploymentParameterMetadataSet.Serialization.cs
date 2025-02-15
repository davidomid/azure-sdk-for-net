// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Logic.Models
{
    public partial class ApiDeploymentParameterMetadataSet
    {
        internal static ApiDeploymentParameterMetadataSet DeserializeApiDeploymentParameterMetadataSet(JsonElement element)
        {
            Optional<ApiDeploymentParameterMetadata> packageContentLink = default;
            Optional<ApiDeploymentParameterMetadata> redisCacheConnectionString = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("packageContentLink"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    packageContentLink = ApiDeploymentParameterMetadata.DeserializeApiDeploymentParameterMetadata(property.Value);
                    continue;
                }
                if (property.NameEquals("redisCacheConnectionString"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    redisCacheConnectionString = ApiDeploymentParameterMetadata.DeserializeApiDeploymentParameterMetadata(property.Value);
                    continue;
                }
            }
            return new ApiDeploymentParameterMetadataSet(packageContentLink.Value, redisCacheConnectionString.Value);
        }
    }
}
