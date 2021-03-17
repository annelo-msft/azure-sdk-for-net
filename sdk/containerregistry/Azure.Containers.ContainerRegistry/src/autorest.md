# Generated code configuration

Run `dotnet build /t:GenerateCode` to generate code.

``` yaml
input-file:
    -  https://github.com/Azure/azure-sdk-for-js/blob/959b343e0979f4e87b9e22ff3e0128c17283ef3d/sdk/containerregistry/container-registry/swagger/containerregistry.json
model-namespace: false
public-clients: true
```

#``` yaml
#directive:
#  from: swagger-document
#  where: $.definitions.*
#  transform: >
#    $["x-accessibility"] = "internal"
#```
