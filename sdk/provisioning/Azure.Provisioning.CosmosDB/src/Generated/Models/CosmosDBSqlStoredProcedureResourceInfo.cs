// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.CosmosDB;

/// <summary>
/// Cosmos DB SQL storedProcedure resource object.
/// </summary>
public partial class CosmosDBSqlStoredProcedureResourceInfo : ProvisionableConstruct
{
    /// <summary>
    /// Name of the Cosmos DB SQL storedProcedure.
    /// </summary>
    public BicepValue<string> StoredProcedureName 
    {
        get { Initialize(); return _storedProcedureName!; }
        set { Initialize(); _storedProcedureName!.Assign(value); }
    }
    private BicepValue<string>? _storedProcedureName;

    /// <summary>
    /// Body of the Stored Procedure.
    /// </summary>
    public BicepValue<string> Body 
    {
        get { Initialize(); return _body!; }
        set { Initialize(); _body!.Assign(value); }
    }
    private BicepValue<string>? _body;

    /// <summary>
    /// Creates a new CosmosDBSqlStoredProcedureResourceInfo.
    /// </summary>
    public CosmosDBSqlStoredProcedureResourceInfo()
    {
    }

    /// <summary>
    /// Define all the provisionable properties of
    /// CosmosDBSqlStoredProcedureResourceInfo.
    /// </summary>
    protected override void DefineProvisionableProperties()
    {
        base.DefineProvisionableProperties();
        _storedProcedureName = DefineProperty<string>("StoredProcedureName", ["id"]);
        _body = DefineProperty<string>("Body", ["body"]);
    }
}
