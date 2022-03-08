# Azure SDK Code Generation for Data Plane

Run `dotnet build /t:GenerateCode` to generate code.

### AutoRest Configuration
> see https://aka.ms/autorest

``` yaml
input-file:
- https://github.com/krishna1s/azure-rest-api-specs/blob/21f82e6866591ebcea0456eb4a692107b902568d/specification/loadtestservice/data-plane/Microsoft.LoadTestService/preview/2021-07-01-preview/loadtestservice.json
namespace: Azure.Test.LoadTest
public-clients: true
data-plane: true

 
 
```
