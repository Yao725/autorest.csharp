// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace MgmtSubscriptionNameParameter.Models
{
    /// <summary> The Resource definition. </summary>
    internal partial class TrackedResource : ResourceData
    {
        /// <summary> Initializes a new instance of TrackedResource. </summary>
        /// <param name="location"> The Geo-location where the resource lives. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="location"/> is null. </exception>
        public TrackedResource(string location)
        {
            if (location == null)
            {
                throw new ArgumentNullException(nameof(location));
            }

            Location = location;
            Tags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of TrackedResource. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="type"> The type. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="location"> The Geo-location where the resource lives. </param>
        /// <param name="tags"> Resource tags. </param>
        internal TrackedResource(ResourceIdentifier id, string name, ResourceType type, SystemData systemData, string location, IDictionary<string, string> tags) : base(id, name, type, systemData)
        {
            Location = location;
            Tags = tags;
        }

        /// <summary> The Geo-location where the resource lives. </summary>
        public string Location { get; set; }
        /// <summary> Resource tags. </summary>
        public IDictionary<string, string> Tags { get; }
    }
}
