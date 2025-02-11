// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Core;

namespace ModelWithConverterUsage.Models
{
    [JsonConverter(typeof(ModelClassConverter))]
    public partial class ModelClass : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(StringProperty))
            {
                writer.WritePropertyName("String_Property"u8);
                writer.WriteStringValue(StringProperty);
            }
            writer.WritePropertyName("Enum_Property"u8);
            writer.WriteStringValue(EnumProperty.ToSerialString());
            if (Optional.IsDefined(ObjProperty))
            {
                writer.WritePropertyName("Obj_Property"u8);
                writer.WriteObjectValue(ObjProperty);
            }
            writer.WriteEndObject();
        }

        internal static ModelClass DeserializeModelClass(JsonElement element)
        {
            Optional<string> stringProperty = default;
            EnumProperty enumProperty = default;
            Optional<Product> objProperty = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("String_Property"u8))
                {
                    stringProperty = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("Enum_Property"u8))
                {
                    enumProperty = property.Value.GetString().ToEnumProperty();
                    continue;
                }
                if (property.NameEquals("Obj_Property"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    objProperty = Product.DeserializeProduct(property.Value);
                    continue;
                }
            }
            return new ModelClass(stringProperty.Value, enumProperty, objProperty.Value);
        }

        internal partial class ModelClassConverter : JsonConverter<ModelClass>
        {
            public override void Write(Utf8JsonWriter writer, ModelClass model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override ModelClass Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeModelClass(document.RootElement);
            }
        }
    }
}
