// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Logic.Models
{
    /// <summary> The ApiType. </summary>
    public readonly partial struct ApiType : IEquatable<ApiType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ApiType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ApiType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string NotSpecifiedValue = "NotSpecified";
        private const string RestValue = "Rest";
        private const string SoapValue = "Soap";

        /// <summary> NotSpecified. </summary>
        public static ApiType NotSpecified { get; } = new ApiType(NotSpecifiedValue);
        /// <summary> Rest. </summary>
        public static ApiType Rest { get; } = new ApiType(RestValue);
        /// <summary> Soap. </summary>
        public static ApiType Soap { get; } = new ApiType(SoapValue);
        /// <summary> Determines if two <see cref="ApiType"/> values are the same. </summary>
        public static bool operator ==(ApiType left, ApiType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ApiType"/> values are not the same. </summary>
        public static bool operator !=(ApiType left, ApiType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ApiType"/>. </summary>
        public static implicit operator ApiType(string value) => new ApiType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ApiType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ApiType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
