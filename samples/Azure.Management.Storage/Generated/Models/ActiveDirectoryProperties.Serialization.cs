// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Management.Storage.Models
{
    public partial class ActiveDirectoryProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("domainName"u8);
            writer.WriteStringValue(DomainName);
            writer.WritePropertyName("netBiosDomainName"u8);
            writer.WriteStringValue(NetBiosDomainName);
            writer.WritePropertyName("forestName"u8);
            writer.WriteStringValue(ForestName);
            writer.WritePropertyName("domainGuid"u8);
            writer.WriteStringValue(DomainGuid);
            writer.WritePropertyName("domainSid"u8);
            writer.WriteStringValue(DomainSid);
            writer.WritePropertyName("azureStorageSid"u8);
            writer.WriteStringValue(AzureStorageSid);
            writer.WriteEndObject();
        }

        internal static ActiveDirectoryProperties DeserializeActiveDirectoryProperties(JsonElement element)
        {
            string domainName = default;
            string netBiosDomainName = default;
            string forestName = default;
            string domainGuid = default;
            string domainSid = default;
            string azureStorageSid = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("domainName"u8))
                {
                    domainName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("netBiosDomainName"u8))
                {
                    netBiosDomainName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("forestName"u8))
                {
                    forestName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("domainGuid"u8))
                {
                    domainGuid = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("domainSid"u8))
                {
                    domainSid = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("azureStorageSid"u8))
                {
                    azureStorageSid = property.Value.GetString();
                    continue;
                }
            }
            return new ActiveDirectoryProperties(domainName, netBiosDomainName, forestName, domainGuid, domainSid, azureStorageSid);
        }
    }
}
