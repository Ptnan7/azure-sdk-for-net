// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.DevTestLabs.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.DevTestLabs.Samples
{
    public partial class Sample_DevTestLabNotificationChannelResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_NotificationChannelsGet()
        {
            // Generated from example definition: specification/devtestlabs/resource-manager/Microsoft.DevTestLab/stable/2018-09-15/examples/NotificationChannels_Get.json
            // this example is just showing the usage of "NotificationChannels_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DevTestLabNotificationChannelResource created on azure
            // for more information of creating DevTestLabNotificationChannelResource, please refer to the document of DevTestLabNotificationChannelResource
            string subscriptionId = "{subscriptionId}";
            string resourceGroupName = "resourceGroupName";
            string labName = "{labName}";
            string name = "{notificationChannelName}";
            ResourceIdentifier devTestLabNotificationChannelResourceId = DevTestLabNotificationChannelResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, labName, name);
            DevTestLabNotificationChannelResource devTestLabNotificationChannel = client.GetDevTestLabNotificationChannelResource(devTestLabNotificationChannelResourceId);

            // invoke the operation
            DevTestLabNotificationChannelResource result = await devTestLabNotificationChannel.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            DevTestLabNotificationChannelData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Delete_NotificationChannelsDelete()
        {
            // Generated from example definition: specification/devtestlabs/resource-manager/Microsoft.DevTestLab/stable/2018-09-15/examples/NotificationChannels_Delete.json
            // this example is just showing the usage of "NotificationChannels_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DevTestLabNotificationChannelResource created on azure
            // for more information of creating DevTestLabNotificationChannelResource, please refer to the document of DevTestLabNotificationChannelResource
            string subscriptionId = "{subscriptionId}";
            string resourceGroupName = "resourceGroupName";
            string labName = "{labName}";
            string name = "{notificationChannelName}";
            ResourceIdentifier devTestLabNotificationChannelResourceId = DevTestLabNotificationChannelResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, labName, name);
            DevTestLabNotificationChannelResource devTestLabNotificationChannel = client.GetDevTestLabNotificationChannelResource(devTestLabNotificationChannelResourceId);

            // invoke the operation
            await devTestLabNotificationChannel.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_NotificationChannelsUpdate()
        {
            // Generated from example definition: specification/devtestlabs/resource-manager/Microsoft.DevTestLab/stable/2018-09-15/examples/NotificationChannels_Update.json
            // this example is just showing the usage of "NotificationChannels_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DevTestLabNotificationChannelResource created on azure
            // for more information of creating DevTestLabNotificationChannelResource, please refer to the document of DevTestLabNotificationChannelResource
            string subscriptionId = "{subscriptionId}";
            string resourceGroupName = "resourceGroupName";
            string labName = "{labName}";
            string name = "{notificationChannelName}";
            ResourceIdentifier devTestLabNotificationChannelResourceId = DevTestLabNotificationChannelResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, labName, name);
            DevTestLabNotificationChannelResource devTestLabNotificationChannel = client.GetDevTestLabNotificationChannelResource(devTestLabNotificationChannelResourceId);

            // invoke the operation
            DevTestLabNotificationChannelPatch patch = new DevTestLabNotificationChannelPatch();
            DevTestLabNotificationChannelResource result = await devTestLabNotificationChannel.UpdateAsync(patch);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            DevTestLabNotificationChannelData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Notify_NotificationChannelsNotify()
        {
            // Generated from example definition: specification/devtestlabs/resource-manager/Microsoft.DevTestLab/stable/2018-09-15/examples/NotificationChannels_Notify.json
            // this example is just showing the usage of "NotificationChannels_Notify" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DevTestLabNotificationChannelResource created on azure
            // for more information of creating DevTestLabNotificationChannelResource, please refer to the document of DevTestLabNotificationChannelResource
            string subscriptionId = "{subscriptionId}";
            string resourceGroupName = "resourceGroupName";
            string labName = "{labName}";
            string name = "{notificationChannelName}";
            ResourceIdentifier devTestLabNotificationChannelResourceId = DevTestLabNotificationChannelResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, labName, name);
            DevTestLabNotificationChannelResource devTestLabNotificationChannel = client.GetDevTestLabNotificationChannelResource(devTestLabNotificationChannelResourceId);

            // invoke the operation
            DevTestLabNotificationChannelNotifyContent content = new DevTestLabNotificationChannelNotifyContent
            {
                EventName = DevTestLabNotificationChannelEventType.AutoShutdown,
                JsonPayload = "{\"eventType\":\"AutoShutdown\",\"subscriptionId\":\"{subscriptionId}\",\"resourceGroupName\":\"resourceGroupName\",\"labName\":\"{labName}\"}",
            };
            await devTestLabNotificationChannel.NotifyAsync(content);

            Console.WriteLine("Succeeded");
        }
    }
}
