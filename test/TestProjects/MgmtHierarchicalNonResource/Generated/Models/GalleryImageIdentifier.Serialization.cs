// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace MgmtHierarchicalNonResource.Models
{
    public partial class GalleryImageIdentifier
    {
        internal static GalleryImageIdentifier DeserializeGalleryImageIdentifier(JsonElement element)
        {
            string publisher = default;
            string offer = default;
            string sku = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("publisher"u8))
                {
                    publisher = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("offer"u8))
                {
                    offer = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sku"u8))
                {
                    sku = property.Value.GetString();
                    continue;
                }
            }
            return new GalleryImageIdentifier(publisher, offer, sku);
        }
    }
}
