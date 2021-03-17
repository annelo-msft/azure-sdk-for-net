# Generated code configuration

Run `dotnet build /t:GenerateCode` to generate code.

``` yaml
input-file:
    -  https://github.com/Azure/azure-sdk-for-js/blob/382e4bdcc84a26331edb154851123ee274bf48d2/sdk/containerregistry/container-registry/swagger/containerregistry.json
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
