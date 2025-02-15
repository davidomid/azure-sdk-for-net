// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Logic.Models
{
    /// <summary> The ip address range. </summary>
    public partial class IPAddressRange
    {
        /// <summary> Initializes a new instance of IPAddressRange. </summary>
        public IPAddressRange()
        {
        }

        /// <summary> Initializes a new instance of IPAddressRange. </summary>
        /// <param name="addressRange"> The IP address range. </param>
        internal IPAddressRange(string addressRange)
        {
            AddressRange = addressRange;
        }

        /// <summary> The IP address range. </summary>
        public string AddressRange { get; set; }
    }
}
