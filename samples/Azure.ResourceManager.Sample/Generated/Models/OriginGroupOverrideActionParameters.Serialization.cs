// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Sample.Models
{
    public partial class OriginGroupOverrideActionParameters : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("@odata.type");
            writer.WriteStringValue(OdataType);
            writer.WritePropertyName("originGroup");
            writer.WriteObjectValue(OriginGroup);
            writer.WriteEndObject();
        }

        internal static OriginGroupOverrideActionParameters DeserializeOriginGroupOverrideActionParameters(JsonElement element)
        {
            string odataType = default;
            ResourceReference originGroup = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("@odata.type"))
                {
                    odataType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("originGroup"))
                {
                    originGroup = ResourceReference.DeserializeResourceReference(property.Value);
                    continue;
                }
            }
            return new OriginGroupOverrideActionParameters(odataType, originGroup);
        }
    }
}
