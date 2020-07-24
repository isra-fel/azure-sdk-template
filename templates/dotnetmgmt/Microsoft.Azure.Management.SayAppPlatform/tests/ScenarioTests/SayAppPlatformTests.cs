using Microsoft.Azure.Management.Resources;
using Microsoft.Rest.ClientRuntime.Azure.TestFramework;
using Xunit;

namespace Microsoft.Azure.Management.SayAppPlatform.Tests.ScenarioTests
{
    public class SayAppPlatformTests
    {
        // Here is a sample case testing the creation of an app configuration store
        // As the number of your test cases grows, you might want to refactor them by for example extracting a base class, or a helper class

        // For how to record the tests and how to run them in playback mode, refer to: https://github.com/Azure/azure-sdk-for-net/blob/master/doc/dev/Using-Azure-TestFramework.md

        // [Fact]
        // public void TestCreateAppConfigurationStore()
        // {
        //     using (MockContext context = MockContext.Start(this.GetType()))
        //     {
        //         var resourceManagementClient = context.GetServiceClient<ResourceManagementClient>();
        //         var appConfigurationClient = context.GetServiceClient<AppConfigurationManagementClient>();

        //         const string rgName = "randomrg";

        //         try
        //         {
        //             var resourceGroup = resourceManagementClient.ResourceGroups.CreateOrUpdate(rgName, new Resources.Models.ResourceGroup
        //             {
        //                 Location = "eastus"
        //             });

        //             const string storeName = "randomstore";
        //             var store = appConfigurationClient.ConfigurationStores.Create(rgName, storeName, new Models.ConfigurationStore
        //             {
        //                 Location = "eastus",
        //                 Sku = new Models.Sku("Premium")
        //             });

        //             Assert.NotNull(store);
        //             Assert.Equal(store.Name, storeName);
        //         }
        //         finally
        //         {
        //             resourceManagementClient.ResourceGroups.Delete(rgName);
        //         }
        //     }
        // }
    }
}
