// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.ResourceManager.Resources;

namespace MgmtScopeResource
{
    /// <summary> A class to add extension methods to Tenant. </summary>
    public static partial class ArmClientExtensions
    {
        #region PolicyAssignment
        /// <summary> Gets an object representing a PolicyAssignmentContainer along with the instance operations that can be performed on it. </summary>
        /// <param name="tenant"> The <see cref="Tenant" /> instance the method will execute against. </param>
        /// <returns> Returns a <see cref="PolicyAssignmentContainer" /> object. </returns>
        public static PolicyAssignmentContainer GetPolicyAssignments(this Tenant tenant)
        {
            return new PolicyAssignmentContainer(tenant);
        }
        #endregion

        #region DeploymentExtended
        /// <summary> Gets an object representing a DeploymentExtendedContainer along with the instance operations that can be performed on it. </summary>
        /// <param name="tenant"> The <see cref="Tenant" /> instance the method will execute against. </param>
        /// <returns> Returns a <see cref="DeploymentExtendedContainer" /> object. </returns>
        public static DeploymentExtendedContainer GetDeploymentExtendeds(this Tenant tenant)
        {
            return new DeploymentExtendedContainer(tenant);
        }
        #endregion
    }
}
