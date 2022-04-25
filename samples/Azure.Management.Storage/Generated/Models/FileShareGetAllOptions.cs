// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Management.Storage.Models
{
    /// <summary> A class representing the optional parameters in FileShares GetAll method. </summary>
    public partial class FileShareGetAllOptions
    {
        /// <summary> Initializes a new instance of FileShareGetAllOptions. </summary>
        public FileShareGetAllOptions()
        {
        }

        /// <summary> Optional. Specified maximum number of shares that can be included in the list. </summary>
        public int? Maxpagesize { get; set; }
        /// <summary> Optional. When specified, only share names starting with the filter will be listed. </summary>
        public string Filter { get; set; }
        /// <summary> Optional, used to expand the properties within share&apos;s properties. Valid values are: deleted, snapshots. Should be passed as a string with delimiter &apos;,&apos;. </summary>
        public string Expand { get; set; }
    }
}
