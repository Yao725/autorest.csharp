using System.Linq;
using System.Reflection;
using NUnit.Framework;

namespace AutoRest.TestServer.Tests.Mgmt.TestProjects
{
    public class TenantExtensionsTests : TestProjectTests
    {
        public TenantExtensionsTests() : base("TenantExtensions") { }

        [TestCase("ArmClientExtensions", "GetApples", true)]
        [TestCase("ArmClientExtensions", "GetPolicyDefinitions", true)]
        [TestCase("ManagementGroupExtensions", "GetPolicyDefinitions", true)]
        [TestCase("SubscriptionExtensions", "GetPolicyDefinitions", true)]
        [TestCase("ResourceGroupExtensions", "GetPolicyDefinitions", false)]
        [TestCase("AppleContainer", "CreateOrUpdate", true)]
        [TestCase("AppleContainer", "Get", true)]
        [TestCase("AppleContainer", "GetAll", true)]
        [TestCase("AppleContainer", "GetBuiltIn", false)]
        [TestCase("Apple", "Get", true)]
        [TestCase("Apple", "Delete", true)]
        [TestCase("PolicyDefinitionContainer", "CreateOrUpdate", true)]
        [TestCase("PolicyDefinitionContainer", "Get", true)]
        [TestCase("PolicyDefinitionContainer", "GetAll", true)]
        [TestCase("PolicyDefinitionContainer", "CreateOrUpdateAtManagementGroup", false)]
        [TestCase("PolicyDefinitionContainer", "GetAtManagementGroup", false)]
        [TestCase("PolicyDefinitionContainer", "GetBuiltIn", false)]
        [TestCase("PolicyDefinition", "Get", true)]
        [TestCase("PolicyDefinition", "Delete", true)]
        [TestCase("PolicyDefinition", "GetAtManagementGroup", false)]
        [TestCase("PolicyDefinition", "GetBuiltIn", false)]
        [TestCase("PolicyDefinition", "DeleteAtManagementGroup", false)]
        public void ValidateTenantExtensionMethods(string className, string methodName, bool exist)
        {
            var armClientExtensions = Assembly.GetExecutingAssembly().GetType("TenantExtensions.ArmClientExtensions");
            var managementGroupExtensions = Assembly.GetExecutingAssembly().GetType("TenantExtensions.ManagementGroupExtensions");
            var subscriptionExtensions = Assembly.GetExecutingAssembly().GetType("TenantExtensions.SubscriptionExtensions");
            var resourceGroupExtensions = Assembly.GetExecutingAssembly().GetType("TenantExtensions.ResourceGroupExtensions");
            var classesToCheck = FindAllContainers().Concat(FindAllResources()).Append(armClientExtensions).Append(managementGroupExtensions).Append(subscriptionExtensions).Append(resourceGroupExtensions);
            var classToCheck = classesToCheck.First(t => t.Name == className);
            Assert.AreEqual(exist, classToCheck.GetMethod(methodName) != null, $"can{(exist ? "not" : string.Empty)} find {className}.{methodName}");
        }

    }
}
