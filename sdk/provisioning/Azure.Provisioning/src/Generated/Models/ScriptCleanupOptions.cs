// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

namespace Azure.Provisioning.Resources;

/// <summary>
/// The clean up preference when the script execution gets in a terminal state.
/// Default setting is &apos;Always&apos;.
/// </summary>
public enum ScriptCleanupOptions
{
    /// <summary>
    /// Always.
    /// </summary>
    Always,

    /// <summary>
    /// OnSuccess.
    /// </summary>
    OnSuccess,

    /// <summary>
    /// OnExpiration.
    /// </summary>
    OnExpiration,
}
