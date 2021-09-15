// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Sample.Models
{
    public partial class DeliveryRuleCacheExpirationAction : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("parameters");
            writer.WriteObjectValue(Parameters);
            writer.WritePropertyName("name");
            writer.WriteStringValue(Name.ToString());
            writer.WriteEndObject();
        }

        internal static DeliveryRuleCacheExpirationAction DeserializeDeliveryRuleCacheExpirationAction(JsonElement element)
        {
            CacheExpirationActionParameters parameters = default;
            DeliveryRuleAction name = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("parameters"))
                {
                    parameters = CacheExpirationActionParameters.DeserializeCacheExpirationActionParameters(property.Value);
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = new DeliveryRuleAction(property.Value.GetString());
                    continue;
                }
            }
            return new DeliveryRuleCacheExpirationAction(name, parameters);
        }
    }
}
