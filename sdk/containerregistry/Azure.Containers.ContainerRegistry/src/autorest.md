# Generated code configuration

Run `dotnet build /t:GenerateCode` to generate code.

``` yaml
input-file:
    -  https://github.com/Azure/azure-sdk-for-js/blob/f9de8723d6522eab4d198703e23a465d04a65703/sdk/containerregistry/container-registry/swagger/containerregistry.json
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
