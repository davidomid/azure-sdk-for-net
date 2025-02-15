// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Batch.Models
{
    internal static partial class PublicNetworkAccessTypeExtensions
    {
        public static string ToSerialString(this PublicNetworkAccessType value) => value switch
        {
            PublicNetworkAccessType.Enabled => "Enabled",
            PublicNetworkAccessType.Disabled => "Disabled",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown PublicNetworkAccessType value.")
        };

        public static PublicNetworkAccessType ToPublicNetworkAccessType(this string value)
        {
            if (string.Equals(value, "Enabled", StringComparison.InvariantCultureIgnoreCase)) return PublicNetworkAccessType.Enabled;
            if (string.Equals(value, "Disabled", StringComparison.InvariantCultureIgnoreCase)) return PublicNetworkAccessType.Disabled;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown PublicNetworkAccessType value.");
        }
    }
}
