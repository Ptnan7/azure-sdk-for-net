// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using NUnit.Framework;

namespace Azure.ResourceManager.AppService.Samples
{
    public partial class Sample_WorkflowRunCollection
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetARunForAWorkflow()
        {
            // Generated from example definition: specification/web/resource-manager/Microsoft.Web/stable/2024-11-01/examples/WorkflowRuns_Get.json
            // this example is just showing the usage of "WorkflowRuns_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this WebSiteResource created on azure
            // for more information of creating WebSiteResource, please refer to the document of WebSiteResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            string resourceGroupName = "test-resource-group";
            string name = "test-name";
            ResourceIdentifier webSiteResourceId = WebSiteResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, name);
            WebSiteResource webSite = client.GetWebSiteResource(webSiteResourceId);

            // get the collection of this WorkflowRunResource
            string workflowName = "test-workflow";
            WorkflowRunCollection collection = webSite.GetWorkflowRuns(workflowName);

            // invoke the operation
            string runName = "08586676746934337772206998657CU22";
            WorkflowRunResource result = await collection.GetAsync(runName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            WorkflowRunData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetAll_ListWorkflowRuns()
        {
            // Generated from example definition: specification/web/resource-manager/Microsoft.Web/stable/2024-11-01/examples/WorkflowRuns_List.json
            // this example is just showing the usage of "WorkflowRuns_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this WebSiteResource created on azure
            // for more information of creating WebSiteResource, please refer to the document of WebSiteResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            string resourceGroupName = "test-resource-group";
            string name = "test-name";
            ResourceIdentifier webSiteResourceId = WebSiteResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, name);
            WebSiteResource webSite = client.GetWebSiteResource(webSiteResourceId);

            // get the collection of this WorkflowRunResource
            string workflowName = "test-workflow";
            WorkflowRunCollection collection = webSite.GetWorkflowRuns(workflowName);

            // invoke the operation and iterate over the result
            await foreach (WorkflowRunResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                WorkflowRunData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Exists_GetARunForAWorkflow()
        {
            // Generated from example definition: specification/web/resource-manager/Microsoft.Web/stable/2024-11-01/examples/WorkflowRuns_Get.json
            // this example is just showing the usage of "WorkflowRuns_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this WebSiteResource created on azure
            // for more information of creating WebSiteResource, please refer to the document of WebSiteResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            string resourceGroupName = "test-resource-group";
            string name = "test-name";
            ResourceIdentifier webSiteResourceId = WebSiteResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, name);
            WebSiteResource webSite = client.GetWebSiteResource(webSiteResourceId);

            // get the collection of this WorkflowRunResource
            string workflowName = "test-workflow";
            WorkflowRunCollection collection = webSite.GetWorkflowRuns(workflowName);

            // invoke the operation
            string runName = "08586676746934337772206998657CU22";
            bool result = await collection.ExistsAsync(runName);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetIfExists_GetARunForAWorkflow()
        {
            // Generated from example definition: specification/web/resource-manager/Microsoft.Web/stable/2024-11-01/examples/WorkflowRuns_Get.json
            // this example is just showing the usage of "WorkflowRuns_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this WebSiteResource created on azure
            // for more information of creating WebSiteResource, please refer to the document of WebSiteResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            string resourceGroupName = "test-resource-group";
            string name = "test-name";
            ResourceIdentifier webSiteResourceId = WebSiteResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, name);
            WebSiteResource webSite = client.GetWebSiteResource(webSiteResourceId);

            // get the collection of this WorkflowRunResource
            string workflowName = "test-workflow";
            WorkflowRunCollection collection = webSite.GetWorkflowRuns(workflowName);

            // invoke the operation
            string runName = "08586676746934337772206998657CU22";
            NullableResponse<WorkflowRunResource> response = await collection.GetIfExistsAsync(runName);
            WorkflowRunResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine("Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                WorkflowRunData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }
    }
}
