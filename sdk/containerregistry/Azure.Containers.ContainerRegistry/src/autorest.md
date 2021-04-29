# Generated code configuration

Run `dotnet build /t:GenerateCode` to generate code.

``` yaml
input-file:
    -  https://github.com/Azure/azure-rest-api-specs/blob/146f0bbcfa7b7600a782976e2fe29d7cf20030ab/specification/containerregistry/data-plane/Microsoft.ContainerRegistry/preview/2019-08-15/containerregistry.json
model-namespace: false
```

``` yaml
directive:
  from: swagger-document
  where: $.definitions.ManifestAttributes_manifest_references
  transform: >
    $["x-accessibility"] = "internal"
```
