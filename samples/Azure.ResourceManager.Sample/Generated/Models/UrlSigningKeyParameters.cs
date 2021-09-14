// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Sample.Models
{
    /// <summary> Url signing key parameters. </summary>
    public partial class UrlSigningKeyParameters : SecretParameters
    {
        /// <summary> Initializes a new instance of UrlSigningKeyParameters. </summary>
        /// <param name="keyId"> Defines the customer defined key Id. This id will exist in the incoming request to indicate the key used to form the hash. </param>
        /// <param name="secretSource"> Resource reference to the KV secret. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="keyId"/> or <paramref name="secretSource"/> is null. </exception>
        public UrlSigningKeyParameters(string keyId, ResourceReference secretSource)
        {
            if (keyId == null)
            {
                throw new ArgumentNullException(nameof(keyId));
            }
            if (secretSource == null)
            {
                throw new ArgumentNullException(nameof(secretSource));
            }

            KeyId = keyId;
            SecretSource = secretSource;
            Type = SecretType.UrlSigningKey;
        }

        /// <summary> Initializes a new instance of UrlSigningKeyParameters. </summary>
        /// <param name="type"> The type of the Secret to create. </param>
        /// <param name="keyId"> Defines the customer defined key Id. This id will exist in the incoming request to indicate the key used to form the hash. </param>
        /// <param name="secretSource"> Resource reference to the KV secret. </param>
        /// <param name="secretVersion"> Version of the secret to be used. </param>
        internal UrlSigningKeyParameters(SecretType type, string keyId, ResourceReference secretSource, string secretVersion) : base(type)
        {
            KeyId = keyId;
            SecretSource = secretSource;
            SecretVersion = secretVersion;
            Type = type;
        }

        /// <summary> Defines the customer defined key Id. This id will exist in the incoming request to indicate the key used to form the hash. </summary>
        public string KeyId { get; set; }
        /// <summary> Resource reference to the KV secret. </summary>
        public ResourceReference SecretSource { get; set; }
        /// <summary> Version of the secret to be used. </summary>
        public string SecretVersion { get; set; }
    }
}
