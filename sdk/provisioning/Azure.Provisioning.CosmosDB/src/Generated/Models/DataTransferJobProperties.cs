// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.CosmosDB;

/// <summary>
/// The properties of a DataTransfer Job.
/// </summary>
public partial class DataTransferJobProperties : ProvisionableConstruct
{
    /// <summary>
    /// Job Name.
    /// </summary>
    public BicepValue<string> JobName { get => _jobName; }
    private readonly BicepValue<string> _jobName;

    /// <summary>
    /// Source DataStore details             Please note
    /// Azure.ResourceManager.CosmosDB.Models.DataTransferDataSourceSink is
    /// the base class. According to the scenario, a derived class of the base
    /// class might need to be assigned here, or this property needs to be
    /// casted to one of the possible derived classes.             The
    /// available derived classes include
    /// Azure.ResourceManager.CosmosDB.Models.AzureBlobDataTransferDataSourceSink,
    /// Azure.ResourceManager.CosmosDB.Models.BaseCosmosDataTransferDataSourceSink,
    /// Azure.ResourceManager.CosmosDB.Models.CosmosCassandraDataTransferDataSourceSink,
    /// Azure.ResourceManager.CosmosDB.Models.CosmosMongoDataTransferDataSourceSink
    /// and
    /// Azure.ResourceManager.CosmosDB.Models.CosmosSqlDataTransferDataSourceSink.
    /// </summary>
    public BicepValue<DataTransferDataSourceSink> Source { get => _source; set => _source.Assign(value); }
    private readonly BicepValue<DataTransferDataSourceSink> _source;

    /// <summary>
    /// Destination DataStore details             Please note
    /// Azure.ResourceManager.CosmosDB.Models.DataTransferDataSourceSink is
    /// the base class. According to the scenario, a derived class of the base
    /// class might need to be assigned here, or this property needs to be
    /// casted to one of the possible derived classes.             The
    /// available derived classes include
    /// Azure.ResourceManager.CosmosDB.Models.AzureBlobDataTransferDataSourceSink,
    /// Azure.ResourceManager.CosmosDB.Models.BaseCosmosDataTransferDataSourceSink,
    /// Azure.ResourceManager.CosmosDB.Models.CosmosCassandraDataTransferDataSourceSink,
    /// Azure.ResourceManager.CosmosDB.Models.CosmosMongoDataTransferDataSourceSink
    /// and
    /// Azure.ResourceManager.CosmosDB.Models.CosmosSqlDataTransferDataSourceSink.
    /// </summary>
    public BicepValue<DataTransferDataSourceSink> Destination { get => _destination; set => _destination.Assign(value); }
    private readonly BicepValue<DataTransferDataSourceSink> _destination;

    /// <summary>
    /// Job Status.
    /// </summary>
    public BicepValue<string> Status { get => _status; }
    private readonly BicepValue<string> _status;

    /// <summary>
    /// Processed Count.
    /// </summary>
    public BicepValue<long> ProcessedCount { get => _processedCount; }
    private readonly BicepValue<long> _processedCount;

    /// <summary>
    /// Total Count.
    /// </summary>
    public BicepValue<long> TotalCount { get => _totalCount; }
    private readonly BicepValue<long> _totalCount;

    /// <summary>
    /// Last Updated Time (ISO-8601 format).
    /// </summary>
    public BicepValue<DateTimeOffset> LastUpdatedUtcOn { get => _lastUpdatedUtcOn; }
    private readonly BicepValue<DateTimeOffset> _lastUpdatedUtcOn;

    /// <summary>
    /// Worker count.
    /// </summary>
    public BicepValue<int> WorkerCount { get => _workerCount; set => _workerCount.Assign(value); }
    private readonly BicepValue<int> _workerCount;

    /// <summary>
    /// Error response for Faulted job.
    /// </summary>
    public BicepValue<ErrorResponse> Error { get => _error; }
    private readonly BicepValue<ErrorResponse> _error;

    /// <summary>
    /// Total Duration of Job.
    /// </summary>
    public BicepValue<TimeSpan> Duration { get => _duration; }
    private readonly BicepValue<TimeSpan> _duration;

    /// <summary>
    /// Mode of job execution.
    /// </summary>
    public BicepValue<DataTransferJobMode> Mode { get => _mode; set => _mode.Assign(value); }
    private readonly BicepValue<DataTransferJobMode> _mode;

    /// <summary>
    /// Creates a new DataTransferJobProperties.
    /// </summary>
    public DataTransferJobProperties()
    {
        _jobName = BicepValue<string>.DefineProperty(this, "JobName", ["jobName"], isOutput: true);
        _source = BicepValue<DataTransferDataSourceSink>.DefineProperty(this, "Source", ["source"]);
        _destination = BicepValue<DataTransferDataSourceSink>.DefineProperty(this, "Destination", ["destination"]);
        _status = BicepValue<string>.DefineProperty(this, "Status", ["status"], isOutput: true);
        _processedCount = BicepValue<long>.DefineProperty(this, "ProcessedCount", ["processedCount"], isOutput: true);
        _totalCount = BicepValue<long>.DefineProperty(this, "TotalCount", ["totalCount"], isOutput: true);
        _lastUpdatedUtcOn = BicepValue<DateTimeOffset>.DefineProperty(this, "LastUpdatedUtcOn", ["lastUpdatedUtcTime"], isOutput: true);
        _workerCount = BicepValue<int>.DefineProperty(this, "WorkerCount", ["workerCount"]);
        _error = BicepValue<ErrorResponse>.DefineProperty(this, "Error", ["error"], isOutput: true);
        _duration = BicepValue<TimeSpan>.DefineProperty(this, "Duration", ["duration"], isOutput: true);
        _mode = BicepValue<DataTransferJobMode>.DefineProperty(this, "Mode", ["mode"]);
    }
}
