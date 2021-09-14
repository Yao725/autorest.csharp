// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Sample.Models
{
    /// <summary> Input of CheckNameAvailability API. </summary>
    public partial class CheckNameAvailabilityInput
    {
        /// <summary> Initializes a new instance of CheckNameAvailabilityInput. </summary>
        /// <param name="name"> The resource name to validate. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public CheckNameAvailabilityInput(string name)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }

            Name = name;
            Type = "Microsoft.Cdn/Profiles/Endpoints";
        }

        /// <summary> The resource name to validate. </summary>
        public string Name { get; }
        /// <summary> The type of the resource whose name is to be validated. </summary>
        public string Type { get; }
    }
}
