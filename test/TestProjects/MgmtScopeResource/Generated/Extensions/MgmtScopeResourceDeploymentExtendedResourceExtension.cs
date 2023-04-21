// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using MgmtScopeResource;
using MgmtScopeResource.Models;

namespace MgmtScopeResource.Mock
{
    /// <summary> A class to add extension methods to DeploymentExtendedResource. </summary>
    public partial class MgmtScopeResourceDeploymentExtendedResourceExtension : ArmResource
    {
        private ClientDiagnostics _deploymentExtendedDeploymentsClientDiagnostics;
        private DeploymentsRestOperations _deploymentExtendedDeploymentsRestClient;

        /// <summary> Initializes a new instance of the <see cref="MgmtScopeResourceDeploymentExtendedResourceExtension"/> class for mocking. </summary>
        protected MgmtScopeResourceDeploymentExtendedResourceExtension()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MgmtScopeResourceDeploymentExtendedResourceExtension"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MgmtScopeResourceDeploymentExtendedResourceExtension(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private ClientDiagnostics DeploymentExtendedDeploymentsClientDiagnostics => _deploymentExtendedDeploymentsClientDiagnostics ??= new ClientDiagnostics("MgmtScopeResource", DeploymentExtendedResource.ResourceType.Namespace, Diagnostics);
        private DeploymentsRestOperations DeploymentExtendedDeploymentsRestClient => _deploymentExtendedDeploymentsRestClient ??= new DeploymentsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, GetApiVersionOrNull(DeploymentExtendedResource.ResourceType));

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary>
        /// Calculate the hash of the given template.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Resources/calculateTemplateHash</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Deployments_CalculateTemplateHash</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="template"> The template provided to calculate hash. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="template"/> is null. </exception>
        public virtual async Task<Response<TemplateHashResult>> CalculateTemplateHashDeploymentAsync(BinaryData template, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(template, nameof(template));

            using var scope = DeploymentExtendedDeploymentsClientDiagnostics.CreateScope("MgmtScopeResourceDeploymentExtendedResourceExtension.CalculateTemplateHashDeployment");
            scope.Start();
            try
            {
                var response = await DeploymentExtendedDeploymentsRestClient.CalculateTemplateHashAsync(template, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Calculate the hash of the given template.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Resources/calculateTemplateHash</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Deployments_CalculateTemplateHash</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="template"> The template provided to calculate hash. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="template"/> is null. </exception>
        public virtual Response<TemplateHashResult> CalculateTemplateHashDeployment(BinaryData template, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(template, nameof(template));

            using var scope = DeploymentExtendedDeploymentsClientDiagnostics.CreateScope("MgmtScopeResourceDeploymentExtendedResourceExtension.CalculateTemplateHashDeployment");
            scope.Start();
            try
            {
                var response = DeploymentExtendedDeploymentsRestClient.CalculateTemplateHash(template, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
