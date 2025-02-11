// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace TenantOnly
{
    /// <summary>
    /// A class representing a collection of <see cref="AgreementResource" /> and their operations.
    /// Each <see cref="AgreementResource" /> in the collection will belong to the same instance of <see cref="BillingAccountResource" />.
    /// To get an <see cref="AgreementCollection" /> instance call the GetAgreements method from an instance of <see cref="BillingAccountResource" />.
    /// </summary>
    public partial class AgreementCollection : ArmCollection, IEnumerable<AgreementResource>, IAsyncEnumerable<AgreementResource>
    {
        private readonly ClientDiagnostics _agreementClientDiagnostics;
        private readonly AgreementsRestOperations _agreementRestClient;

        /// <summary> Initializes a new instance of the <see cref="AgreementCollection"/> class for mocking. </summary>
        protected AgreementCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="AgreementCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal AgreementCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _agreementClientDiagnostics = new ClientDiagnostics("TenantOnly", AgreementResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(AgreementResource.ResourceType, out string agreementApiVersion);
            _agreementRestClient = new AgreementsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, agreementApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != BillingAccountResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, BillingAccountResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Gets an agreement by ID.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Billing/billingAccounts/{billingAccountName}/agreements/{agreementName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Agreements_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="agreementName"> The ID that uniquely identifies an agreement. </param>
        /// <param name="expand"> May be used to expand the participants. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="agreementName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="agreementName"/> is null. </exception>
        public virtual async Task<Response<AgreementResource>> GetAsync(string agreementName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(agreementName, nameof(agreementName));

            using var scope = _agreementClientDiagnostics.CreateScope("AgreementCollection.Get");
            scope.Start();
            try
            {
                var response = await _agreementRestClient.GetAsync(Id.Name, agreementName, expand, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AgreementResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets an agreement by ID.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Billing/billingAccounts/{billingAccountName}/agreements/{agreementName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Agreements_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="agreementName"> The ID that uniquely identifies an agreement. </param>
        /// <param name="expand"> May be used to expand the participants. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="agreementName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="agreementName"/> is null. </exception>
        public virtual Response<AgreementResource> Get(string agreementName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(agreementName, nameof(agreementName));

            using var scope = _agreementClientDiagnostics.CreateScope("AgreementCollection.Get");
            scope.Start();
            try
            {
                var response = _agreementRestClient.Get(Id.Name, agreementName, expand, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AgreementResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets an agreement by ID.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Billing/billingAccounts/{billingAccountName}/agreements</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Agreements_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="expand"> May be used to expand the participants. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="AgreementResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<AgreementResource> GetAllAsync(string expand = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _agreementRestClient.CreateListRequest(Id.Name, expand);
            return PageableHelpers.CreateAsyncPageable(FirstPageRequest, null, e => new AgreementResource(Client, AgreementData.DeserializeAgreementData(e)), _agreementClientDiagnostics, Pipeline, "AgreementCollection.GetAll", "value", null, cancellationToken);
        }

        /// <summary>
        /// Gets an agreement by ID.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Billing/billingAccounts/{billingAccountName}/agreements</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Agreements_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="expand"> May be used to expand the participants. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="AgreementResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<AgreementResource> GetAll(string expand = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _agreementRestClient.CreateListRequest(Id.Name, expand);
            return PageableHelpers.CreatePageable(FirstPageRequest, null, e => new AgreementResource(Client, AgreementData.DeserializeAgreementData(e)), _agreementClientDiagnostics, Pipeline, "AgreementCollection.GetAll", "value", null, cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Billing/billingAccounts/{billingAccountName}/agreements/{agreementName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Agreements_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="agreementName"> The ID that uniquely identifies an agreement. </param>
        /// <param name="expand"> May be used to expand the participants. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="agreementName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="agreementName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string agreementName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(agreementName, nameof(agreementName));

            using var scope = _agreementClientDiagnostics.CreateScope("AgreementCollection.Exists");
            scope.Start();
            try
            {
                var response = await _agreementRestClient.GetAsync(Id.Name, agreementName, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Billing/billingAccounts/{billingAccountName}/agreements/{agreementName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Agreements_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="agreementName"> The ID that uniquely identifies an agreement. </param>
        /// <param name="expand"> May be used to expand the participants. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="agreementName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="agreementName"/> is null. </exception>
        public virtual Response<bool> Exists(string agreementName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(agreementName, nameof(agreementName));

            using var scope = _agreementClientDiagnostics.CreateScope("AgreementCollection.Exists");
            scope.Start();
            try
            {
                var response = _agreementRestClient.Get(Id.Name, agreementName, expand, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<AgreementResource> IEnumerable<AgreementResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<AgreementResource> IAsyncEnumerable<AgreementResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
