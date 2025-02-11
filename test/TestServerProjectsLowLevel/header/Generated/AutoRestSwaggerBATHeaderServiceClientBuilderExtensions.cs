// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure;
using Azure.Core.Extensions;
using header_LowLevel;

namespace Microsoft.Extensions.Azure
{
    /// <summary> Extension methods to add <see cref="HeaderClient"/> to client builder. </summary>
    public static partial class AutoRestSwaggerBATHeaderServiceClientBuilderExtensions
    {
        /// <summary> Registers a <see cref="HeaderClient"/> instance. </summary>
        /// <param name="builder"> The builder to register with. </param>
        /// <param name="credential"> A credential used to authenticate to an Azure Service. </param>
        /// <param name="endpoint"> server parameter. </param>
        public static IAzureClientBuilder<HeaderClient, HeaderClientOptions> AddHeaderClient<TBuilder>(this TBuilder builder, AzureKeyCredential credential, Uri endpoint)
        where TBuilder : IAzureClientFactoryBuilder
        {
            return builder.RegisterClientFactory<HeaderClient, HeaderClientOptions>((options) => new HeaderClient(credential, endpoint, options));
        }

        /// <summary> Registers a <see cref="HeaderClient"/> instance. </summary>
        /// <param name="builder"> The builder to register with. </param>
        /// <param name="configuration"> The configuration values. </param>
        public static IAzureClientBuilder<HeaderClient, HeaderClientOptions> AddHeaderClient<TBuilder, TConfiguration>(this TBuilder builder, TConfiguration configuration)
        where TBuilder : IAzureClientFactoryBuilderWithConfiguration<TConfiguration>
        {
            return builder.RegisterClientFactory<HeaderClient, HeaderClientOptions>(configuration);
        }
    }
}
