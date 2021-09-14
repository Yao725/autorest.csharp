// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Sample.Models
{
    /// <summary> The JSON object containing endpoint update parameters. </summary>
    internal partial class EndpointPropertiesUpdateParameters
    {
        /// <summary> Initializes a new instance of EndpointPropertiesUpdateParameters. </summary>
        internal EndpointPropertiesUpdateParameters()
        {
            ContentTypesToCompress = new ChangeTrackingList<string>();
            GeoFilters = new ChangeTrackingList<GeoFilter>();
            UrlSigningKeys = new ChangeTrackingList<UrlSigningKey>();
        }

        /// <summary> A directory path on the origin that CDN can use to retrieve content from, e.g. contoso.cloudapp.net/originpath. </summary>
        public string OriginPath { get; }
        /// <summary> List of content types on which compression applies. The value should be a valid MIME type. </summary>
        public IReadOnlyList<string> ContentTypesToCompress { get; }
        /// <summary> The host header value sent to the origin with each request. This property at Endpoint is only allowed when endpoint uses single origin and can be overridden by the same property specified at origin.If you leave this blank, the request hostname determines this value. Azure CDN origins, such as Web Apps, Blob Storage, and Cloud Services require this host header value to match the origin hostname by default. </summary>
        public string OriginHostHeader { get; }
        /// <summary> Indicates whether content compression is enabled on CDN. Default value is false. If compression is enabled, content will be served as compressed if user requests for a compressed version. Content won&apos;t be compressed on CDN when requested content is smaller than 1 byte or larger than 1 MB. </summary>
        public bool? IsCompressionEnabled { get; }
        /// <summary> Indicates whether HTTP traffic is allowed on the endpoint. Default value is true. At least one protocol (HTTP or HTTPS) must be allowed. </summary>
        public bool? IsHttpAllowed { get; }
        /// <summary> Indicates whether HTTPS traffic is allowed on the endpoint. Default value is true. At least one protocol (HTTP or HTTPS) must be allowed. </summary>
        public bool? IsHttpsAllowed { get; }
        /// <summary> Defines how CDN caches requests that include query strings. You can ignore any query strings when caching, bypass caching to prevent requests that contain query strings from being cached, or cache every request with a unique URL. </summary>
        public QueryStringCachingBehavior? QueryStringCachingBehavior { get; }
        /// <summary> Specifies what scenario the customer wants this CDN endpoint to optimize for, e.g. Download, Media services. With this information, CDN can apply scenario driven optimization. </summary>
        public OptimizationType? OptimizationType { get; }
        /// <summary> Path to a file hosted on the origin which helps accelerate delivery of the dynamic content and calculate the most optimal routes for the CDN. This is relative to the origin path. This property is only relevant when using a single origin. </summary>
        public string ProbePath { get; }
        /// <summary> List of rules defining the user&apos;s geo access within a CDN endpoint. Each geo filter defines an access rule to a specified path or content, e.g. block APAC for path /pictures/. </summary>
        public IReadOnlyList<GeoFilter> GeoFilters { get; }
        /// <summary> A reference to the origin group. </summary>
        public ResourceReference DefaultOriginGroup { get; }
        /// <summary> List of keys used to validate the signed URL hashes. </summary>
        public IReadOnlyList<UrlSigningKey> UrlSigningKeys { get; }
        /// <summary> A policy that specifies the delivery rules to be used for an endpoint. </summary>
        public EndpointPropertiesUpdateParametersDeliveryPolicy DeliveryPolicy { get; }
        /// <summary> Defines the Web Application Firewall policy for the endpoint (if applicable). </summary>
        public EndpointPropertiesUpdateParametersWebApplicationFirewallPolicyLink WebApplicationFirewallPolicyLink { get; }
    }
}
