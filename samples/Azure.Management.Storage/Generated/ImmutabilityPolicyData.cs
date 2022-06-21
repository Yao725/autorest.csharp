// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure;
using Azure.Core;
using Azure.Management.Storage.Models;
using Azure.ResourceManager.Models;

namespace Azure.Management.Storage
{
    /// <summary> A class representing the ImmutabilityPolicy data model. </summary>
    public partial class ImmutabilityPolicyData : AzureEntityResource
    {
        /// <summary> Initializes a new instance of ImmutabilityPolicyData. </summary>
        public ImmutabilityPolicyData()
        {
        }

        /// <summary> Initializes a new instance of ImmutabilityPolicyData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="etag"> Resource Etag. </param>
        /// <param name="immutabilityPeriodSinceCreationInDays"> The immutability period for the blobs in the container since the policy creation, in days. </param>
        /// <param name="state"> The ImmutabilityPolicy state of a blob container, possible values include: Locked and Unlocked. </param>
        /// <param name="allowProtectedAppendWrites"> This property can only be changed for unlocked time-based retention policies. When enabled, new blocks can be written to an append blob while maintaining immutability protection and compliance. Only new blocks can be added and any existing blocks cannot be modified or deleted. This property cannot be changed with ExtendImmutabilityPolicy API. </param>
        /// <param name="allowProtectedAppendWritesAll"> This property can only be changed for unlocked time-based retention policies. When enabled, new blocks can be written to both &apos;Append and Bock Blobs&apos; while maintaining immutability protection and compliance. Only new blocks can be added and any existing blocks cannot be modified or deleted. This property cannot be changed with ExtendImmutabilityPolicy API. The &apos;allowProtectedAppendWrites&apos; and &apos;allowProtectedAppendWritesAll&apos; properties are mutually exclusive. </param>
        internal ImmutabilityPolicyData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, ETag? etag, int? immutabilityPeriodSinceCreationInDays, ImmutabilityPolicyState? state, bool? allowProtectedAppendWrites, bool? allowProtectedAppendWritesAll) : base(id, name, resourceType, systemData, etag)
        {
            ImmutabilityPeriodSinceCreationInDays = immutabilityPeriodSinceCreationInDays;
            State = state;
            AllowProtectedAppendWrites = allowProtectedAppendWrites;
            AllowProtectedAppendWritesAll = allowProtectedAppendWritesAll;
        }

        /// <summary> The immutability period for the blobs in the container since the policy creation, in days. </summary>
        public int? ImmutabilityPeriodSinceCreationInDays { get; set; }
        /// <summary> The ImmutabilityPolicy state of a blob container, possible values include: Locked and Unlocked. </summary>
        public ImmutabilityPolicyState? State { get; }
        /// <summary> This property can only be changed for unlocked time-based retention policies. When enabled, new blocks can be written to an append blob while maintaining immutability protection and compliance. Only new blocks can be added and any existing blocks cannot be modified or deleted. This property cannot be changed with ExtendImmutabilityPolicy API. </summary>
        public bool? AllowProtectedAppendWrites { get; set; }
        /// <summary> This property can only be changed for unlocked time-based retention policies. When enabled, new blocks can be written to both &apos;Append and Bock Blobs&apos; while maintaining immutability protection and compliance. Only new blocks can be added and any existing blocks cannot be modified or deleted. This property cannot be changed with ExtendImmutabilityPolicy API. The &apos;allowProtectedAppendWrites&apos; and &apos;allowProtectedAppendWritesAll&apos; properties are mutually exclusive. </summary>
        public bool? AllowProtectedAppendWritesAll { get; set; }
    }
}
