﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

extern alias DMBlobs;
extern alias BaseBlobs;

using System.IO;
using System.Threading;
using System.Threading.Tasks;
using BaseBlobs::Azure.Storage.Blobs;
using BaseBlobs::Azure.Storage.Blobs.Models;
using BaseBlobs::Azure.Storage.Blobs.Specialized;
using DMBlobs::Azure.Storage.DataMovement.Blobs;

namespace Azure.Storage.DataMovement.Blobs.Tests
{
    [DataMovementBlobsClientTestFixture]
    public class BlockBlobDirectoryToPageBlobDirectoryTests :
        StartTransferBlobDirectoryCopyTestBase<BlockBlobClient, PageBlobClient>
    {
        public BlockBlobDirectoryToPageBlobDirectoryTests(
            bool async,
            object serviceVersion)
        : base(async, serviceVersion)
        {
        }
        protected override Task CreateObjectInDestinationAsync(
            BlobContainerClient container,
            long? objectLength = null,
            string objectName = null,
            Stream contents = null,
            CancellationToken cancellationToken = default)
            => CreatePageBlobAsync(container, objectLength, objectName, contents, cancellationToken);

        protected override Task CreateObjectInSourceAsync(
            BlobContainerClient container,
            long? objectLength = null,
            string objectName = null,
            Stream contents = null,
            TransferPropertiesTestType propertiesTestType = TransferPropertiesTestType.Default,
            CancellationToken cancellationToken = default)
            => CreateBlockBlobAsync(container, objectLength, objectName, contents, cancellationToken);

        protected override StorageResourceContainer GetDestinationStorageResourceContainer(
            BlobContainerClient containerClient,
            string directoryPath,
            TransferPropertiesTestType propertiesTestType = TransferPropertiesTestType.Default)
        {
            PageBlobStorageResourceOptions options = default;
            if (propertiesTestType == TransferPropertiesTestType.NewProperties)
            {
                options = new PageBlobStorageResourceOptions(GetSetValuesResourceOptions());
            }
            else if (propertiesTestType == TransferPropertiesTestType.NoPreserve)
            {
                options = new PageBlobStorageResourceOptions
                {
                    ContentDisposition = default,
                    ContentLanguage = default,
                    CacheControl = default,
                    ContentType = default,
                    Metadata = default
                };
            }
            return new BlobStorageResourceContainer(containerClient, new BlobStorageResourceContainerOptions()
            {
                BlobPrefix = directoryPath,
                BlobType = BlobType.Page,
                BlobOptions = options
            });
        }

        protected override StorageResourceContainer GetSourceStorageResourceContainer(
            BlobContainerClient containerClient,
            string directoryPath)
            => new BlobStorageResourceContainer(
                containerClient,
                new BlobStorageResourceContainerOptions() {
                    BlobPrefix = directoryPath,
                    BlobType = BlobType.Block });

        protected internal override PageBlobClient GetDestinationBlob(BlobContainerClient containerClient, string blobName)
            => containerClient.GetPageBlobClient(blobName);

        protected internal override BlockBlobClient GetSourceBlob(BlobContainerClient containerClient, string blobName)
            => containerClient.GetBlockBlobClient(blobName);
    }
}
