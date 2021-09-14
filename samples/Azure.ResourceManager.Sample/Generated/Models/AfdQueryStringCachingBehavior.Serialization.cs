// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Sample.Models
{
    internal static partial class AfdQueryStringCachingBehaviorExtensions
    {
        public static string ToSerialString(this AfdQueryStringCachingBehavior value) => value switch
        {
            AfdQueryStringCachingBehavior.IgnoreQueryString => "IgnoreQueryString",
            AfdQueryStringCachingBehavior.UseQueryString => "UseQueryString",
            AfdQueryStringCachingBehavior.NotSet => "NotSet",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown AfdQueryStringCachingBehavior value.")
        };

        public static AfdQueryStringCachingBehavior ToAfdQueryStringCachingBehavior(this string value)
        {
            if (string.Equals(value, "IgnoreQueryString", StringComparison.InvariantCultureIgnoreCase)) return AfdQueryStringCachingBehavior.IgnoreQueryString;
            if (string.Equals(value, "UseQueryString", StringComparison.InvariantCultureIgnoreCase)) return AfdQueryStringCachingBehavior.UseQueryString;
            if (string.Equals(value, "NotSet", StringComparison.InvariantCultureIgnoreCase)) return AfdQueryStringCachingBehavior.NotSet;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown AfdQueryStringCachingBehavior value.");
        }
    }
}
