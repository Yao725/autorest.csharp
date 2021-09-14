// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Sample.Models
{
    /// <summary> The validation token. </summary>
    public partial class ValidationToken
    {
        /// <summary> Initializes a new instance of ValidationToken. </summary>
        internal ValidationToken()
        {
        }

        /// <summary> Initializes a new instance of ValidationToken. </summary>
        /// <param name="token"></param>
        internal ValidationToken(string token)
        {
            Token = token;
        }

        public string Token { get; }
    }
}
