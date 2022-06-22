# Azure SDK Code Generation for Data Plane

Run `dotnet build /t:GenerateCode` to generate code.

### AutoRest Configuration
> see https://aka.ms/autorest

``` yaml
input-file:
- $(this-folder)/swagger/openapi.json
namespace: Azure.Template
security: AADToken
security-scopes: https://example.azure.net/.default
generation1-convenience-client: true
#azure-arm: true
```
