// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.CognitiveServices.Models
{
    /// <summary> Properties to configure Encryption. </summary>
    public partial class ServiceAccountEncryptionProperties
    {
        /// <summary> Initializes a new instance of ServiceAccountEncryptionProperties. </summary>
        public ServiceAccountEncryptionProperties()
        {
        }

        /// <summary> Initializes a new instance of ServiceAccountEncryptionProperties. </summary>
        /// <param name="keyVaultProperties"> Properties of KeyVault. </param>
        /// <param name="keySource"> Enumerates the possible value of keySource for Encryption. </param>
        internal ServiceAccountEncryptionProperties(CognitiveServicesKeyVaultProperties keyVaultProperties, ServiceAccountEncryptionKeySource? keySource)
        {
            KeyVaultProperties = keyVaultProperties;
            KeySource = keySource;
        }

        /// <summary> Properties of KeyVault. </summary>
        public CognitiveServicesKeyVaultProperties KeyVaultProperties { get; set; }
        /// <summary> Enumerates the possible value of keySource for Encryption. </summary>
        public ServiceAccountEncryptionKeySource? KeySource { get; set; }
    }
}
