// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.Compute.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.Compute.Samples
{
    public partial class Sample_VirtualMachineScaleSetVmExtensionResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetVirtualMachineScaleSetVMExtension()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/ComputeRP/stable/2024-11-01/examples/virtualMachineScaleSetExamples/VirtualMachineScaleSetVMExtension_Get.json
            // this example is just showing the usage of "VirtualMachineScaleSetVMExtensions_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this VirtualMachineScaleSetVmExtensionResource created on azure
            // for more information of creating VirtualMachineScaleSetVmExtensionResource, please refer to the document of VirtualMachineScaleSetVmExtensionResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "myResourceGroup";
            string virtualMachineScaleSetName = "myvmScaleSet";
            string instanceId = "0";
            string vmExtensionName = "myVMExtension";
            ResourceIdentifier virtualMachineScaleSetVmExtensionResourceId = VirtualMachineScaleSetVmExtensionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, virtualMachineScaleSetName, instanceId, vmExtensionName);
            VirtualMachineScaleSetVmExtensionResource virtualMachineScaleSetVmExtension = client.GetVirtualMachineScaleSetVmExtensionResource(virtualMachineScaleSetVmExtensionResourceId);

            // invoke the operation
            VirtualMachineScaleSetVmExtensionResource result = await virtualMachineScaleSetVmExtension.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            VirtualMachineScaleSetVmExtensionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Delete_DeleteVirtualMachineScaleSetVMExtension()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/ComputeRP/stable/2024-11-01/examples/virtualMachineScaleSetExamples/VirtualMachineScaleSetVMExtension_Delete.json
            // this example is just showing the usage of "VirtualMachineScaleSetVMExtensions_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this VirtualMachineScaleSetVmExtensionResource created on azure
            // for more information of creating VirtualMachineScaleSetVmExtensionResource, please refer to the document of VirtualMachineScaleSetVmExtensionResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "myResourceGroup";
            string virtualMachineScaleSetName = "myvmScaleSet";
            string instanceId = "0";
            string vmExtensionName = "myVMExtension";
            ResourceIdentifier virtualMachineScaleSetVmExtensionResourceId = VirtualMachineScaleSetVmExtensionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, virtualMachineScaleSetName, instanceId, vmExtensionName);
            VirtualMachineScaleSetVmExtensionResource virtualMachineScaleSetVmExtension = client.GetVirtualMachineScaleSetVmExtensionResource(virtualMachineScaleSetVmExtensionResourceId);

            // invoke the operation
            await virtualMachineScaleSetVmExtension.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_UpdateVirtualMachineScaleSetVMExtension()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/ComputeRP/stable/2024-11-01/examples/virtualMachineScaleSetExamples/VirtualMachineScaleSetVMExtension_Update.json
            // this example is just showing the usage of "VirtualMachineScaleSetVMExtensions_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this VirtualMachineScaleSetVmExtensionResource created on azure
            // for more information of creating VirtualMachineScaleSetVmExtensionResource, please refer to the document of VirtualMachineScaleSetVmExtensionResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "myResourceGroup";
            string virtualMachineScaleSetName = "myvmScaleSet";
            string instanceId = "0";
            string vmExtensionName = "myVMExtension";
            ResourceIdentifier virtualMachineScaleSetVmExtensionResourceId = VirtualMachineScaleSetVmExtensionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, virtualMachineScaleSetName, instanceId, vmExtensionName);
            VirtualMachineScaleSetVmExtensionResource virtualMachineScaleSetVmExtension = client.GetVirtualMachineScaleSetVmExtensionResource(virtualMachineScaleSetVmExtensionResourceId);

            // invoke the operation
            VirtualMachineScaleSetVmExtensionPatch patch = new VirtualMachineScaleSetVmExtensionPatch
            {
                Publisher = "extPublisher",
                ExtensionType = "extType",
                TypeHandlerVersion = "1.2",
                AutoUpgradeMinorVersion = true,
                Settings = BinaryData.FromObjectAsJson(new
                {
                    UserName = "xyz@microsoft.com",
                }),
            };
            ArmOperation<VirtualMachineScaleSetVmExtensionResource> lro = await virtualMachineScaleSetVmExtension.UpdateAsync(WaitUntil.Completed, patch);
            VirtualMachineScaleSetVmExtensionResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            VirtualMachineScaleSetVmExtensionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
