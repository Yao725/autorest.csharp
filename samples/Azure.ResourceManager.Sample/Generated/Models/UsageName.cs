// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Sample.Models
{
    /// <summary> The usage names. </summary>
    public partial class UsageName
    {
        /// <summary> Initializes a new instance of UsageName. </summary>
        internal UsageName()
        {
        }

        /// <summary> Initializes a new instance of UsageName. </summary>
        /// <param name="value"> A string describing the resource name. </param>
        /// <param name="localizedValue"> A localized string describing the resource name. </param>
        internal UsageName(string value, string localizedValue)
        {
            Value = value;
            LocalizedValue = localizedValue;
        }

        /// <summary> A string describing the resource name. </summary>
        public string Value { get; }
        /// <summary> A localized string describing the resource name. </summary>
        public string LocalizedValue { get; }
    }
}
