// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Media;

namespace Azure.ResourceManager.Media.Models
{
    internal partial class AssetTrackCollection
    {
        internal static AssetTrackCollection DeserializeAssetTrackCollection(JsonElement element)
        {
            Optional<IReadOnlyList<AssetTrackData>> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<AssetTrackData> array = new List<AssetTrackData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(AssetTrackData.DeserializeAssetTrackData(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new AssetTrackCollection(Optional.ToList(value));
        }
    }
}
