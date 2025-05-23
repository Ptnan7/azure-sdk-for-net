// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Resources;
using Azure.ResourceManager.WeightsAndBiases.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.WeightsAndBiases.Samples
{
    public partial class Sample_WeightsAndBiasesInstanceCollection
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_InstancesCreateOrUpdateGeneratedByMaximumSetRule()
        {
            // Generated from example definition: 2024-09-18-preview/Instances_CreateOrUpdate_MaximumSet_Gen.json
            // this example is just showing the usage of "InstanceResource_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "0BCB047F-CB71-4DFE-B0BD-88519F411C2F";
            string resourceGroupName = "rgopenapi";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this WeightsAndBiasesInstanceResource
            WeightsAndBiasesInstanceCollection collection = resourceGroupResource.GetWeightsAndBiasesInstances();

            // invoke the operation
            string instancename = "myinstance";
            WeightsAndBiasesInstanceData data = new WeightsAndBiasesInstanceData(new AzureLocation("pudewmshbcvbt"))
            {
                Properties = new WeightsAndBiasesInstanceProperties(new WeightsAndBiasesMarketplaceDetails(new WeightsAndBiasesOfferDetails("kf", "rfgoevxeke", "ufopn")
                {
                    PlanName = "adysakgqlryufffz",
                    TermUnit = "dgrkojow",
                    TermId = "kklscqq",
                })
                {
                    SubscriptionId = "00000000-0000-0000-0000-000000000000",
                }, new WeightsAndBiasesUserDetails
                {
                    FirstName = "kiiehcojcldrlndoid",
                    LastName = "zhkvsfqvthwkfkvgxcruyud",
                    EmailAddress = "user@outlook.com",
                    Upn = "rmjpgqchpbw",
                    PhoneNumber = "cogmqmuwfcpstkwbzgkgo",
                })
                {
                    PartnerProperties = new WeightsAndBiasesPartnerProperties(WeightsAndBiasesRegion.EastUS, "xkecokwnwtkwnkxfgucmzybzzb"),
                    SingleSignOnProperties = new WeightsAndBiasesSingleSignOnPropertiesV2(WeightsAndBiasesSingleSignOnType.Saml)
                    {
                        State = WeightsAndBiasesSingleSignOnState.Initial,
                        EnterpriseAppId = "hkxtmpv",
                        Uri = "iqlemoksqdygqyxpp",
                        AadDomains = { "mxnw" },
                    },
                },
                Identity = new ManagedServiceIdentity("None")
                {
                    UserAssignedIdentities = { },
                },
                Tags = { },
            };
            ArmOperation<WeightsAndBiasesInstanceResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, instancename, data);
            WeightsAndBiasesInstanceResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            WeightsAndBiasesInstanceData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_InstancesGetGeneratedByMaximumSetRule()
        {
            // Generated from example definition: 2024-09-18-preview/Instances_Get_MaximumSet_Gen.json
            // this example is just showing the usage of "InstanceResource_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "0BCB047F-CB71-4DFE-B0BD-88519F411C2F";
            string resourceGroupName = "rgopenapi";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this WeightsAndBiasesInstanceResource
            WeightsAndBiasesInstanceCollection collection = resourceGroupResource.GetWeightsAndBiasesInstances();

            // invoke the operation
            string instancename = "myinstance";
            WeightsAndBiasesInstanceResource result = await collection.GetAsync(instancename);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            WeightsAndBiasesInstanceData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetAll_InstancesListByResourceGroupGeneratedByMaximumSetRule()
        {
            // Generated from example definition: 2024-09-18-preview/Instances_ListByResourceGroup_MaximumSet_Gen.json
            // this example is just showing the usage of "InstanceResource_ListByResourceGroup" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "0BCB047F-CB71-4DFE-B0BD-88519F411C2F";
            string resourceGroupName = "rgopenapi";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this WeightsAndBiasesInstanceResource
            WeightsAndBiasesInstanceCollection collection = resourceGroupResource.GetWeightsAndBiasesInstances();

            // invoke the operation and iterate over the result
            await foreach (WeightsAndBiasesInstanceResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                WeightsAndBiasesInstanceData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetAll_InstancesListByResourceGroupGeneratedByMinimumSetRule()
        {
            // Generated from example definition: 2024-09-18-preview/Instances_ListByResourceGroup_MinimumSet_Gen.json
            // this example is just showing the usage of "InstanceResource_ListByResourceGroup" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "0BCB047F-CB71-4DFE-B0BD-88519F411C2F";
            string resourceGroupName = "rgopenapi";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this WeightsAndBiasesInstanceResource
            WeightsAndBiasesInstanceCollection collection = resourceGroupResource.GetWeightsAndBiasesInstances();

            // invoke the operation and iterate over the result
            await foreach (WeightsAndBiasesInstanceResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                WeightsAndBiasesInstanceData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Exists_InstancesGetGeneratedByMaximumSetRule()
        {
            // Generated from example definition: 2024-09-18-preview/Instances_Get_MaximumSet_Gen.json
            // this example is just showing the usage of "InstanceResource_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "0BCB047F-CB71-4DFE-B0BD-88519F411C2F";
            string resourceGroupName = "rgopenapi";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this WeightsAndBiasesInstanceResource
            WeightsAndBiasesInstanceCollection collection = resourceGroupResource.GetWeightsAndBiasesInstances();

            // invoke the operation
            string instancename = "myinstance";
            bool result = await collection.ExistsAsync(instancename);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetIfExists_InstancesGetGeneratedByMaximumSetRule()
        {
            // Generated from example definition: 2024-09-18-preview/Instances_Get_MaximumSet_Gen.json
            // this example is just showing the usage of "InstanceResource_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "0BCB047F-CB71-4DFE-B0BD-88519F411C2F";
            string resourceGroupName = "rgopenapi";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this WeightsAndBiasesInstanceResource
            WeightsAndBiasesInstanceCollection collection = resourceGroupResource.GetWeightsAndBiasesInstances();

            // invoke the operation
            string instancename = "myinstance";
            NullableResponse<WeightsAndBiasesInstanceResource> response = await collection.GetIfExistsAsync(instancename);
            WeightsAndBiasesInstanceResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine("Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                WeightsAndBiasesInstanceData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }
    }
}
