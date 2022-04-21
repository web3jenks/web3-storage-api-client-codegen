# Web3.Storage - the C# library for the Web3.Storage API

This documentation describes the HTTP API for [**Web3.Storage**](https://web3.storage), which allows you to quickly and easily build applications using decentralized data storage persisted by [Filecoin](https://filecoin.io) and available over [IPFS](https://ipfs.io).

You can also interact with this API using client libraries. See [**docs.web3.storage**](https://docs.web3.storage) for more information on using a client library, as well as a variety of other guides and how-tos for Web3.Storage as a whole.

## API endpoint URL

The main public API endpoint URL for Web3.Storage is `https://api.web3.storage`. All endpoints described in this document should be made relative to this root URL. For example, to post to the `/car` endpoint, send your request to `https://api.web3.storage/car`.

### Rate limits

This API imposes rate limits to ensure quality of service. You may receive a 429 \"Too many requests\" error if you make more than 30 requests with the same API token within a ten second window. Upon receiving a response with a 429 status, clients should retry the failed request after a small delay. To avoid 429 responses, you may wish to implement client-side request throttling to stay within the limits.


This C# SDK is automatically generated by the [OpenAPI Generator](https://openapi-generator.tech) project:

- API version: 1.0
- SDK version: 1.0.0
- Build package: org.openapitools.codegen.languages.CSharpNetCoreClientCodegen

<a name="frameworks-supported"></a>
## Frameworks supported
- .NET Core >=1.0
- .NET Framework >=4.6
- Mono/Xamarin >=vNext

<a name="dependencies"></a>
## Dependencies

- [RestSharp](https://www.nuget.org/packages/RestSharp) - 106.11.7 or later
- [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json/) - 12.0.3 or later
- [JsonSubTypes](https://www.nuget.org/packages/JsonSubTypes/) - 1.8.0 or later
- [System.ComponentModel.Annotations](https://www.nuget.org/packages/System.ComponentModel.Annotations) - 5.0.0 or later

The DLLs included in the package may not be the latest version. We recommend using [NuGet](https://docs.nuget.org/consume/installing-nuget) to obtain the latest version of the packages:
```
Install-Package RestSharp
Install-Package Newtonsoft.Json
Install-Package JsonSubTypes
Install-Package System.ComponentModel.Annotations
```

NOTE: RestSharp versions greater than 105.1.0 have a bug which causes file uploads to fail. See [RestSharp#742](https://github.com/restsharp/RestSharp/issues/742).
NOTE: RestSharp for .Net Core creates a new socket for each api call, which can lead to a socket exhaustion problem. See [RestSharp#1406](https://github.com/restsharp/RestSharp/issues/1406).

<a name="installation"></a>
## Installation
Generate the DLL using your preferred tool (e.g. `dotnet build`)

Then include the DLL (under the `bin` folder) in the C# project, and use the namespaces:
```csharp
using Web3.Storage.Api;
using Web3.Storage.Client;
using Web3.Storage.Model;
```
<a name="usage"></a>
## Usage

To use the API client with a HTTP proxy, setup a `System.Net.WebProxy`
```csharp
Configuration c = new Configuration();
System.Net.WebProxy webProxy = new System.Net.WebProxy("http://myProxyUrl:80/");
webProxy.Credentials = System.Net.CredentialCache.DefaultCredentials;
c.Proxy = webProxy;
```

<a name="getting-started"></a>
## Getting Started

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Web3.Storage.Api;
using Web3.Storage.Client;
using Web3.Storage.Model;

namespace Example
{
    public class Example
    {
        public static void Main()
        {

            Configuration config = new Configuration();
            config.BasePath = "https://api.web3.storage";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new Web3StorageHTTPAPIApi(config);
            var requestid = requestid_example;  // string | 

            try
            {
                // Remove pin object
                apiInstance.DeletePinsRequestid(requestid);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling Web3StorageHTTPAPIApi.DeletePinsRequestid: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }

        }
    }
}
```

<a name="documentation-for-api-endpoints"></a>
## Documentation for API Endpoints

All URIs are relative to *https://api.web3.storage*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*Web3StorageHTTPAPIApi* | [**DeletePinsRequestid**](docs/Web3StorageHTTPAPIApi.md#deletepinsrequestid) | **DELETE** /pins/{requestid} | Remove pin object
*Web3StorageHTTPAPIApi* | [**GetCarCid**](docs/Web3StorageHTTPAPIApi.md#getcarcid) | **GET** /car/{cid} | Retrieve a CAR
*Web3StorageHTTPAPIApi* | [**GetPins**](docs/Web3StorageHTTPAPIApi.md#getpins) | **GET** /pins | List pin objects
*Web3StorageHTTPAPIApi* | [**GetPinsRequestid**](docs/Web3StorageHTTPAPIApi.md#getpinsrequestid) | **GET** /pins/{requestid} | Get pin object
*Web3StorageHTTPAPIApi* | [**GetStatusCid**](docs/Web3StorageHTTPAPIApi.md#getstatuscid) | **GET** /status/{cid} | Retrieve information about an upload
*Web3StorageHTTPAPIApi* | [**GetUserUploads**](docs/Web3StorageHTTPAPIApi.md#getuseruploads) | **GET** /user/uploads | List previous uploads
*Web3StorageHTTPAPIApi* | [**HeadCarCid**](docs/Web3StorageHTTPAPIApi.md#headcarcid) | **HEAD** /car/{cid} | Retrieve HTTP headers regarding a CAR
*Web3StorageHTTPAPIApi* | [**PostCar**](docs/Web3StorageHTTPAPIApi.md#postcar) | **POST** /car | Upload a CAR
*Web3StorageHTTPAPIApi* | [**PostPins**](docs/Web3StorageHTTPAPIApi.md#postpins) | **POST** /pins | Add pin object
*Web3StorageHTTPAPIApi* | [**PostPinsRequestid**](docs/Web3StorageHTTPAPIApi.md#postpinsrequestid) | **POST** /pins/{requestid} | Replace pin object
*Web3StorageHTTPAPIApi* | [**PostUpload**](docs/Web3StorageHTTPAPIApi.md#postupload) | **POST** /upload | Upload and store one or more files


<a name="documentation-for-models"></a>
## Documentation for Models

 - [Model.Deal](docs/Deal.md)
 - [Model.ErrorResponse](docs/ErrorResponse.md)
 - [Model.Failure](docs/Failure.md)
 - [Model.FailureError](docs/FailureError.md)
 - [Model.ForbiddenErrorResponse](docs/ForbiddenErrorResponse.md)
 - [Model.PSAPin](docs/PSAPin.md)
 - [Model.Pin](docs/Pin.md)
 - [Model.PinResults](docs/PinResults.md)
 - [Model.PinStatus](docs/PinStatus.md)
 - [Model.PinStatusPin](docs/PinStatusPin.md)
 - [Model.Status](docs/Status.md)
 - [Model.TextMatchingStrategy](docs/TextMatchingStrategy.md)
 - [Model.UnauthorizedErrorResponse](docs/UnauthorizedErrorResponse.md)
 - [Model.UploadResponse](docs/UploadResponse.md)


<a name="documentation-for-authorization"></a>
## Documentation for Authorization

<a name="bearerAuth"></a>
### bearerAuth

- **Type**: Bearer Authentication
