# Microsoft.Azure.Synapse.Artifacts

Run `dotnet build /t:GenerateCode` to generate code.

### AutoRest Configuration
> see https://aka.ms/autorest

``` yaml
tag: package-artifacts-2020-12-01
require:
    - https://github.com/Azure/azure-rest-api-specs/blob/3d6211cf28f83236cdf78e7cfc50efd3fb7cba72/specification/synapse/data-plane/readme.md
namespace: Azure.Analytics.Synapse.Artifacts
public-clients: true
security: AADToken
security-scopes: https://dev.azuresynapse.net/.default
modelerfour:
  lenient-model-deduplication: true
```

### Make Endpoint type as Uri

``` yaml
directive:
  from: swagger-document
  where: $.parameters.Endpoint
  transform: $.format = "url"
```

### Make expression object types into strings

``` yaml
directive:
  from: swagger-document
  where: $.definitions.DatasetCompression
  transform: $.type = "string"
```

``` yaml
directive:
  from: swagger-document
  where: $.definitions.DatasetBZip2Compression
  transform: $.type = "string"
```

``` yaml
directive:
  from: swagger-document
  where: $.definitions.DatasetGZipCompression
  transform: $.type = "string"
```

``` yaml
directive:
  from: swagger-document
  where: $.definitions.DatasetDeflateCompression
  transform: $.type = "string"
```

``` yaml
directive:
  from: swagger-document
  where: $.definitions.DatasetZipDeflateCompression
  transform: $.type = "string"
```

``` yaml
directive:
  from: swagger-document
  where: $.definitions.DatasetTarCompression
  transform: $.type = "string"
```

``` yaml
directive:
  from: swagger-document
  where: $.definitions.DatasetTarGZipCompression
  transform: $.type = "string"
```

### Expose serialization and deserialization methods and internal models

``` yaml
directive:
- from: swagger-document
  where: $.definitions
  transform: >
    for (var path in $)
    {
      if (path.endsWith("AvroFormat") ||
          path.endsWith("AdditionalColumns") ||
          path.endsWith("CreateDataFlowDebugSessionRequest") ||
          path.endsWith("CopyBehaviorType") ||
          path.endsWith("CopyTranslator") ||
          path.endsWith("DataFlowDebugPreviewDataRequest") ||
          path.endsWith("DataFlowDebugQueryResponse") ||
          path.endsWith("DataFlowDebugResultResponse") ||
          path.endsWith("DataFlowDebugStatisticsRequest") ||
          path.endsWith("DataFlowDebugPackage") ||
          path.endsWith("DatasetDataElement") ||
          path.endsWith("DatasetSchemaDataElement") ||
          path.endsWith("DatasetStorageFormat") ||
          path.endsWith("EvaluateDataFlowExpressionRequest") ||
          path.endsWith("ExposureControlRequest") ||
          path.endsWith("ExposureControlResponse") ||
          path.endsWith("GetSsisObjectMetadataRequest") ||
          path.endsWith("JsonFormat") ||
          path.endsWith("JsonFormatFilePattern") ||
          path.endsWith("OrcFormat") ||
          path.endsWith("ParquetFormat") ||
          path.endsWith("RerunTriggerListResponse") ||
          path.endsWith("RerunTumblingWindowTriggerActionParameter") ||
          path.endsWith("SsisObjectMetadataStatusResponse") ||
          path.endsWith("StartDataFlowDebugSessionRequest") ||
          path.endsWith("StartDataFlowDebugSessionResponse") ||
          path.endsWith("TabularTranslator") ||
          path.endsWith("TextFormat") ||
          path.endsWith("TriggerDependencyProvisioningStatus") ||
          path.endsWith("TypeConversionSettings") ||
          path.endsWith("WorkspaceIdentity") ||
          path.endsWith("WorkspaceUpdateParameters"))
      {
        $[path]["x-csharp-usage"] = "model,input,output,converter";
        $[path]["x-csharp-formats"] = "json";
      }
      else
      {
        $[path]["x-csharp-usage"] = "converter";
      }
    }
```
