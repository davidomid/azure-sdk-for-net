// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Logic.Models
{
    /// <summary> The encryption algorithm. </summary>
    public readonly partial struct EncryptionAlgorithm : IEquatable<EncryptionAlgorithm>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="EncryptionAlgorithm"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public EncryptionAlgorithm(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string NotSpecifiedValue = "NotSpecified";
        private const string NoneValue = "None";
        private const string DES3Value = "DES3";
        private const string RC2Value = "RC2";
        private const string AES128Value = "AES128";
        private const string AES192Value = "AES192";
        private const string AES256Value = "AES256";

        /// <summary> NotSpecified. </summary>
        public static EncryptionAlgorithm NotSpecified { get; } = new EncryptionAlgorithm(NotSpecifiedValue);
        /// <summary> None. </summary>
        public static EncryptionAlgorithm None { get; } = new EncryptionAlgorithm(NoneValue);
        /// <summary> DES3. </summary>
        public static EncryptionAlgorithm DES3 { get; } = new EncryptionAlgorithm(DES3Value);
        /// <summary> RC2. </summary>
        public static EncryptionAlgorithm RC2 { get; } = new EncryptionAlgorithm(RC2Value);
        /// <summary> AES128. </summary>
        public static EncryptionAlgorithm AES128 { get; } = new EncryptionAlgorithm(AES128Value);
        /// <summary> AES192. </summary>
        public static EncryptionAlgorithm AES192 { get; } = new EncryptionAlgorithm(AES192Value);
        /// <summary> AES256. </summary>
        public static EncryptionAlgorithm AES256 { get; } = new EncryptionAlgorithm(AES256Value);
        /// <summary> Determines if two <see cref="EncryptionAlgorithm"/> values are the same. </summary>
        public static bool operator ==(EncryptionAlgorithm left, EncryptionAlgorithm right) => left.Equals(right);
        /// <summary> Determines if two <see cref="EncryptionAlgorithm"/> values are not the same. </summary>
        public static bool operator !=(EncryptionAlgorithm left, EncryptionAlgorithm right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="EncryptionAlgorithm"/>. </summary>
        public static implicit operator EncryptionAlgorithm(string value) => new EncryptionAlgorithm(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is EncryptionAlgorithm other && Equals(other);
        /// <inheritdoc />
        public bool Equals(EncryptionAlgorithm other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
