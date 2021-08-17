// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using AutoRest.CSharp.AutoRest.Plugins;
using AutoRest.CSharp.Generation.Writers;
using AutoRest.CSharp.Input;
using AutoRest.CSharp.Mgmt.AutoRest;
using AutoRest.CSharp.Mgmt.Decorator;
using AutoRest.CSharp.Mgmt.Output;
using AutoRest.CSharp.Output.Models.Requests;
using AutoRest.CSharp.Output.Models.Shared;
using AutoRest.CSharp.Output.Models.Types;
using AutoRest.CSharp.Utilities;
using Azure.ResourceManager;
using Core = Azure.ResourceManager.Core;
using Azure.ResourceManager.Resources;

namespace AutoRest.CSharp.Mgmt.Generation
{
    internal class TenantExtensionsWriter : MgmtExtensionWriter
    {
        protected override string Description => "A class to add extension methods to Tenant.";
        protected override string TypeNameOfThis => ResourceTypeBuilder.TypeToExtensionName[ResourceTypeBuilder.Tenant];
        protected override string ExtensionOperationVariableName => "tenant";

        protected override Type ExtensionOperationVariableType => typeof(Tenant);

        public override void WriteExtension(CodeWriter writer, BuildContext<MgmtOutputLibrary> context)
        {
            using (writer.Namespace(context.DefaultNamespace))
            {
                writer.WriteXmlDocumentationSummary($"{Description}");
                using (writer.Scope($"{Accessibility} static partial class {TypeNameOfThis}"))
                {
                    foreach (var resource in context.Library.ArmResources)
                    {
                        if (ParentDetection.ParentResourceType(resource.OperationGroup, context.Configuration.MgmtConfiguration).Equals(ResourceTypeBuilder.Tenant))
                        {
                            if (resource.OperationGroup.IsSingletonResource(context.Configuration.MgmtConfiguration))
                            {
                                writer.Line($"#region Get {resource.Type.Name} operation");
                                WriteChildSingletonGetOperationMethods(writer, resource);
                                writer.LineRaw("#endregion");
                            }
                            else
                            {
                                writer.Line($"#region {resource.Type.Name}");
                                var resourceContainer = context.Library.GetResourceContainer(resource.OperationGroup);
                                WriteGetResourceContainerMethod(writer, resourceContainer!);
                                writer.LineRaw("#endregion");
                            }
                        }
                        else
                        {
                            if (resource.TenantExtensionsListMethods != null && resource.TenantExtensionsListMethods.Count() > 0)
                            {
                                writer.Line($"#region {resource.Type.Name}");
                                WriteGetRestOperations(writer, resource.RestClient);

                                foreach (var listMethod in resource.TenantExtensionsListMethods)
                                {
                                    var methodName = $"Get{resource.Type.Name.ToPlural()}";
                                    var count = resource.TenantExtensionsListMethods.Count();
                                    if (listMethod.PagingMethod != null)
                                    {
                                        if (count > 1 && listMethod.PagingMethod.Name == "GetByLocation")
                                        {
                                            methodName = $"Get{resource.Type.Name.ToPlural()}ByLocation";
                                        }

                                        WriteListResourceMethod(writer, resource, listMethod.PagingMethod, methodName, context.Configuration.MgmtConfiguration, true);
                                        WriteListResourceMethod(writer, resource, listMethod.PagingMethod, methodName, context.Configuration.MgmtConfiguration, false);
                                    }

                                    if (listMethod.ClientMethod != null)
                                    {
                                        if (count > 1 && listMethod.ClientMethod.Name == "GetByLocation")
                                        {
                                            methodName = $"Get{resource.Type.Name.ToPlural()}ByLocation";
                                        }

                                        WriteExtensionClientMethod(writer, resource.OperationGroup, listMethod.ClientMethod, methodName, context, true, resource.RestClient);
                                        WriteExtensionClientMethod(writer, resource.OperationGroup, listMethod.ClientMethod, methodName, context, false, resource.RestClient);
                                    }

                                }

                                //WriteListResourceByNameMethod(writer, resource, true);
                                //WriteListResourceByNameMethod(writer, resource, false);
                                writer.LineRaw("#endregion");
                            }
                        }
                        writer.Line();
                    }

                    // write the standalone list operations with the parent of a tenant
                    var mgmtExtensionOperations = context.Library.GetNonResourceOperations(ResourceTypeBuilder.Tenant);

                    foreach (var mgmtExtensionOperation in mgmtExtensionOperations)
                    {
                        writer.Line($"#region {mgmtExtensionOperation.SchemaName}");
                        WriteGetRestOperations(writer, mgmtExtensionOperation.RestClient);

                        // despite that we should only have one method, but we still using an IEnumerable
                        foreach (var pagingMethod in mgmtExtensionOperation.PagingMethods)
                        {
                            WriteExtensionPagingMethod(writer, pagingMethod.PagingResponse.ItemType, mgmtExtensionOperation.RestClient, pagingMethod, pagingMethod.Name, $"", true);
                            WriteExtensionPagingMethod(writer, pagingMethod.PagingResponse.ItemType, mgmtExtensionOperation.RestClient, pagingMethod, pagingMethod.Name, $"", false);
                        }

                        foreach (var clientMethod in mgmtExtensionOperation.ClientMethods)
                        {
                            WriteExtensionClientMethod(writer, mgmtExtensionOperation.OperationGroup, clientMethod, clientMethod.Name, context, true, mgmtExtensionOperation.RestClient);
                            WriteExtensionClientMethod(writer, mgmtExtensionOperation.OperationGroup, clientMethod, clientMethod.Name, context, false, mgmtExtensionOperation.RestClient);
                        }

                        writer.LineRaw("#endregion");
                        writer.Line();
                    }
                }
            }
        }

        private void WriteChildSingletonGetOperationMethods(CodeWriter writer, Resource resource)
        {
            // The resourceOperation already has a suffix "Operations" therefore it is already in plural form
            // there we do not need to change it to plural again
            writer.WriteXmlDocumentationSummary($"Gets an object representing a {resource.Type.Name} along with the instance operations that can be performed on it.");
            writer.WriteXmlDocumentationReturns($"Returns a <see cref=\"{resource.Type.Name}\" /> object.");
            using (writer.Scope($"public static {resource.Type} Get{resource.Type.Name}(this {typeof(Tenant)} {ExtensionOperationVariableName})"))
            {
                writer.Line($"return new {resource.Type.Name}({ExtensionOperationVariableName});");
            }
        }

        private void WriteGetResourceContainerMethod(CodeWriter writer, ResourceContainer resourceContainer)
        {
            writer.WriteXmlDocumentationSummary($"Gets an object representing a {resourceContainer.Type.Name} along with the instance operations that can be performed on it.");
            writer.WriteXmlDocumentationParameter(ExtensionOperationVariableName, $"The <see cref=\"{typeof(Tenant)}\" /> instance the method will execute against.");
            writer.WriteXmlDocumentationReturns($"Returns a <see cref=\"{resourceContainer.Type.Name}\" /> object.");

            using (writer.Scope($"public static {resourceContainer.Type} Get{resourceContainer.Resource.Type.Name.ToPlural()}(this {typeof(Tenant)} {ExtensionOperationVariableName})"))
            {
                writer.Line($"return new {resourceContainer.Type.Name}({ExtensionOperationVariableName});");
            }
        }

        private void WriteListResourceMethod(CodeWriter writer, Resource resource, PagingMethod pagingMethod, string methodName, MgmtConfiguration config, bool async)
        {
            if (pagingMethod.PagingResponse.ItemType.Name.Equals(resource.ResourceData.Type.Name))
            {
                WriteExtensionPagingMethod(writer, resource.Type, resource.RestClient, pagingMethod, methodName,
                $".Select(value => new {resource.Type.Name}({ExtensionOperationVariableName}, value))", async);
            }
            else
            {
                WriteExtensionPagingMethod(writer, pagingMethod.PagingResponse.ItemType, resource.RestClient, pagingMethod, methodName,
                $"", async);
            }
        }

        private void WriteListResourceByNameMethod(CodeWriter writer, Resource resource, bool async)
        {
            writer.Line();
            writer.WriteXmlDocumentationSummary($"Filters the list of {resource.ResourceName.ToPlural()} for a <see cref=\"{typeof(Tenant)}\" /> represented as generic resources.");
            writer.WriteXmlDocumentationParameter("tenant", $"The <see cref=\"{typeof(Tenant)}\" /> instance the method will execute against.");
            writer.WriteXmlDocumentationParameter("filter", $"The string to filter the list.");
            writer.WriteXmlDocumentationParameter("expand", $"Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`.");
            writer.WriteXmlDocumentationParameter("top", $"The number of results to return.");
            writer.WriteXmlDocumentationParameter("cancellationToken", $"The cancellation token to use.");
            writer.WriteXmlDocumentationReturns($"A collection of resource operations that may take multiple service requests to iterate over.");

            var responseType = typeof(GenericResource).WrapPageable(async);
            using (writer.Scope($"public static {responseType} {CreateMethodName($"Get{resource.ResourceName}ByName", async)}(this {typeof(Tenant)} tenant, {typeof(string)} filter, {typeof(string)} expand, {typeof(int?)} top, {typeof(CancellationToken)} cancellationToken = default)"))
            {
                var filters = new CodeWriterDeclaration("filters");
                writer.Line($"{typeof(ResourceFilterCollection)} {filters:D} = new({resource.Type}.ResourceType);");
                writer.Line($"{filters}.SubstringFilter = filter;");
                writer.Line($"return {typeof(Core.ResourceListOperations)}.{CreateMethodName("GetAtContext", async)}(tenant, {filters}, expand, top, cancellationToken);");
            }
        }

        protected override bool ShouldPassThrough(ref string dotParent, Stack<string> parentNameStack, Parameter parameter, ref string valueExpression)
        {
            return true;
        }

        protected override void MakeResourceNameParamPassThrough(RestClientMethod method, List<ParameterMapping> parameterMapping, Stack<string> parentNameStack)
        {
        }
    }
}
