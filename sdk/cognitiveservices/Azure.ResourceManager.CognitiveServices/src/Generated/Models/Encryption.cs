// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.CognitiveServices.Models
{
    /// <summary> Properties to configure Encryption. </summary>
    public partial class Encryption
    {
        /// <summary> Initializes a new instance of Encryption. </summary>
        public Encryption()
        {
        }

        /// <summary> Initializes a new instance of Encryption. </summary>
        /// <param name="keyVaultProperties"> Properties of KeyVault. </param>
        /// <param name="keySource"> Enumerates the possible value of keySource for Encryption. </param>
        internal Encryption(KeyVaultProperties keyVaultProperties, KeySource? keySource)
        {
            KeyVaultProperties = keyVaultProperties;
            KeySource = keySource;
        }

        /// <summary> Properties of KeyVault. </summary>
        public KeyVaultProperties KeyVaultProperties { get; set; }
        /// <summary> Enumerates the possible value of keySource for Encryption. </summary>
        public KeySource? KeySource { get; set; }
    }
}
