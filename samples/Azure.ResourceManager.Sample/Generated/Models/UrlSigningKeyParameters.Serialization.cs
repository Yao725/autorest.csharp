// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Sample.Models
{
    public partial class UrlSigningKeyParameters : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("keyId");
            writer.WriteStringValue(KeyId);
            writer.WritePropertyName("secretSource");
            writer.WriteObjectValue(SecretSource);
            if (Optional.IsDefined(SecretVersion))
            {
                writer.WritePropertyName("secretVersion");
                writer.WriteStringValue(SecretVersion);
            }
            writer.WritePropertyName("type");
            writer.WriteStringValue(Type.ToString());
            writer.WriteEndObject();
        }

        internal static UrlSigningKeyParameters DeserializeUrlSigningKeyParameters(JsonElement element)
        {
            string keyId = default;
            ResourceReference secretSource = default;
            Optional<string> secretVersion = default;
            SecretType type = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("keyId"))
                {
                    keyId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("secretSource"))
                {
                    secretSource = ResourceReference.DeserializeResourceReference(property.Value);
                    continue;
                }
                if (property.NameEquals("secretVersion"))
                {
                    secretVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = new SecretType(property.Value.GetString());
                    continue;
                }
            }
            return new UrlSigningKeyParameters(type, keyId, secretSource, secretVersion.Value);
        }
    }
}
