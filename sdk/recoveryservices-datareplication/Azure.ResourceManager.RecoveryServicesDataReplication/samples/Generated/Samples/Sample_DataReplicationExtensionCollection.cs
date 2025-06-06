// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.RecoveryServicesDataReplication.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.RecoveryServicesDataReplication.Samples
{
    public partial class Sample_DataReplicationExtensionCollection
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_PutsTheReplicationExtension()
        {
            // Generated from example definition: 2024-09-01/ReplicationExtension_Create.json
            // this example is just showing the usage of "ReplicationExtensionModel_Create" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DataReplicationVaultResource created on azure
            // for more information of creating DataReplicationVaultResource, please refer to the document of DataReplicationVaultResource
            string subscriptionId = "930CEC23-4430-4513-B855-DBA237E2F3BF";
            string resourceGroupName = "rgrecoveryservicesdatareplication";
            string vaultName = "4";
            ResourceIdentifier dataReplicationVaultResourceId = DataReplicationVaultResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, vaultName);
            DataReplicationVaultResource dataReplicationVault = client.GetDataReplicationVaultResource(dataReplicationVaultResourceId);

            // get the collection of this DataReplicationExtensionResource
            DataReplicationExtensionCollection collection = dataReplicationVault.GetDataReplicationExtensions();

            // invoke the operation
            string replicationExtensionName = "g16yjJ";
            DataReplicationExtensionData data = new DataReplicationExtensionData
            {
                Properties = new DataReplicationExtensionProperties(default),
            };
            ArmOperation<DataReplicationExtensionResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, replicationExtensionName, data);
            DataReplicationExtensionResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            DataReplicationExtensionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetsTheReplicationExtension()
        {
            // Generated from example definition: 2024-09-01/ReplicationExtension_Get.json
            // this example is just showing the usage of "ReplicationExtensionModel_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DataReplicationVaultResource created on azure
            // for more information of creating DataReplicationVaultResource, please refer to the document of DataReplicationVaultResource
            string subscriptionId = "930CEC23-4430-4513-B855-DBA237E2F3BF";
            string resourceGroupName = "rgrecoveryservicesdatareplication";
            string vaultName = "4";
            ResourceIdentifier dataReplicationVaultResourceId = DataReplicationVaultResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, vaultName);
            DataReplicationVaultResource dataReplicationVault = client.GetDataReplicationVaultResource(dataReplicationVaultResourceId);

            // get the collection of this DataReplicationExtensionResource
            DataReplicationExtensionCollection collection = dataReplicationVault.GetDataReplicationExtensions();

            // invoke the operation
            string replicationExtensionName = "g16yjJ";
            DataReplicationExtensionResource result = await collection.GetAsync(replicationExtensionName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            DataReplicationExtensionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetAll_ListsTheReplicationExtensions()
        {
            // Generated from example definition: 2024-09-01/ReplicationExtension_List.json
            // this example is just showing the usage of "ReplicationExtensionModel_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DataReplicationVaultResource created on azure
            // for more information of creating DataReplicationVaultResource, please refer to the document of DataReplicationVaultResource
            string subscriptionId = "930CEC23-4430-4513-B855-DBA237E2F3BF";
            string resourceGroupName = "rgrecoveryservicesdatareplication";
            string vaultName = "4";
            ResourceIdentifier dataReplicationVaultResourceId = DataReplicationVaultResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, vaultName);
            DataReplicationVaultResource dataReplicationVault = client.GetDataReplicationVaultResource(dataReplicationVaultResourceId);

            // get the collection of this DataReplicationExtensionResource
            DataReplicationExtensionCollection collection = dataReplicationVault.GetDataReplicationExtensions();

            // invoke the operation and iterate over the result
            await foreach (DataReplicationExtensionResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                DataReplicationExtensionData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Exists_GetsTheReplicationExtension()
        {
            // Generated from example definition: 2024-09-01/ReplicationExtension_Get.json
            // this example is just showing the usage of "ReplicationExtensionModel_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DataReplicationVaultResource created on azure
            // for more information of creating DataReplicationVaultResource, please refer to the document of DataReplicationVaultResource
            string subscriptionId = "930CEC23-4430-4513-B855-DBA237E2F3BF";
            string resourceGroupName = "rgrecoveryservicesdatareplication";
            string vaultName = "4";
            ResourceIdentifier dataReplicationVaultResourceId = DataReplicationVaultResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, vaultName);
            DataReplicationVaultResource dataReplicationVault = client.GetDataReplicationVaultResource(dataReplicationVaultResourceId);

            // get the collection of this DataReplicationExtensionResource
            DataReplicationExtensionCollection collection = dataReplicationVault.GetDataReplicationExtensions();

            // invoke the operation
            string replicationExtensionName = "g16yjJ";
            bool result = await collection.ExistsAsync(replicationExtensionName);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetIfExists_GetsTheReplicationExtension()
        {
            // Generated from example definition: 2024-09-01/ReplicationExtension_Get.json
            // this example is just showing the usage of "ReplicationExtensionModel_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DataReplicationVaultResource created on azure
            // for more information of creating DataReplicationVaultResource, please refer to the document of DataReplicationVaultResource
            string subscriptionId = "930CEC23-4430-4513-B855-DBA237E2F3BF";
            string resourceGroupName = "rgrecoveryservicesdatareplication";
            string vaultName = "4";
            ResourceIdentifier dataReplicationVaultResourceId = DataReplicationVaultResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, vaultName);
            DataReplicationVaultResource dataReplicationVault = client.GetDataReplicationVaultResource(dataReplicationVaultResourceId);

            // get the collection of this DataReplicationExtensionResource
            DataReplicationExtensionCollection collection = dataReplicationVault.GetDataReplicationExtensions();

            // invoke the operation
            string replicationExtensionName = "g16yjJ";
            NullableResponse<DataReplicationExtensionResource> response = await collection.GetIfExistsAsync(replicationExtensionName);
            DataReplicationExtensionResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine("Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                DataReplicationExtensionData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }
    }
}
