// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#nullable disable

namespace Azure.AI.OpenAI.Assistants;

/*
 * CUSTOM CODE DESCRIPTION:
 *
 * These changes facilitate the merging of superficial types introduced by the underlying REST wire format. The goal
 * is to avoid having types that contain nothing meaningful beyond a property to another type.
 */

public partial class MessageImageFileContent
{
    /// <inheritdoc cref="InternalMessageImageFileDetails.InternalDetails"/>
    public string FileId => InternalDetails.InternalDetails;

    internal InternalMessageImageFileDetails InternalDetails { get; }
}
