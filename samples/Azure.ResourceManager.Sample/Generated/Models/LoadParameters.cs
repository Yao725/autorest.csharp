// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.ResourceManager.Sample.Models
{
    /// <summary> Parameters required for content load. </summary>
    public partial class LoadParameters
    {
        /// <summary> Initializes a new instance of LoadParameters. </summary>
        /// <param name="contentPaths"> The path to the content to be loaded. Path should be a relative file URL of the origin. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="contentPaths"/> is null. </exception>
        public LoadParameters(IEnumerable<string> contentPaths)
        {
            if (contentPaths == null)
            {
                throw new ArgumentNullException(nameof(contentPaths));
            }

            ContentPaths = contentPaths.ToList();
        }

        /// <summary> The path to the content to be loaded. Path should be a relative file URL of the origin. </summary>
        public IList<string> ContentPaths { get; }
    }
}
