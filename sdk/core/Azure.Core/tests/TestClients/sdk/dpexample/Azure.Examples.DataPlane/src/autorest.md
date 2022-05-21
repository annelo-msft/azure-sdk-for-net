# Azure SDK Code Generation for Data Plane

Run `dotnet build /t:GenerateCode` to generate code.

### AutoRest Configuration
> see https://aka.ms/autorest

``` yaml
input-file: 
- C:\src\azure-sdk-for-net\sdk\core\Azure.Core\tests\TestClients\sdk\dpexample\Azure.Examples.DataPlane\src\swagger\dpexample.json
namespace: Azure.Examples.DataPlane
security: AADToken
security-scopes: https://dpexample.azure.com/.default
 
```
