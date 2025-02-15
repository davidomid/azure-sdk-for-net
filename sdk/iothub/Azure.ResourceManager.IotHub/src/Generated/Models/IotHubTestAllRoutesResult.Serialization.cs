// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.IotHub.Models
{
    public partial class IotHubTestAllRoutesResult
    {
        internal static IotHubTestAllRoutesResult DeserializeIotHubTestAllRoutesResult(JsonElement element)
        {
            Optional<IReadOnlyList<MatchedRoute>> routes = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("routes"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<MatchedRoute> array = new List<MatchedRoute>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MatchedRoute.DeserializeMatchedRoute(item));
                    }
                    routes = array;
                    continue;
                }
            }
            return new IotHubTestAllRoutesResult(Optional.ToList(routes));
        }
    }
}
