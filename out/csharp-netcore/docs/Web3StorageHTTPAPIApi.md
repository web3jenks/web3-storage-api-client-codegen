# Web3.Storage.Api.Web3StorageHTTPAPIApi

All URIs are relative to *https://api.web3.storage*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeletePinsRequestid**](Web3StorageHTTPAPIApi.md#deletepinsrequestid) | **DELETE** /pins/{requestid} | Remove pin object
[**GetCarCid**](Web3StorageHTTPAPIApi.md#getcarcid) | **GET** /car/{cid} | Retrieve a CAR
[**GetPins**](Web3StorageHTTPAPIApi.md#getpins) | **GET** /pins | List pin objects
[**GetPinsRequestid**](Web3StorageHTTPAPIApi.md#getpinsrequestid) | **GET** /pins/{requestid} | Get pin object
[**GetStatusCid**](Web3StorageHTTPAPIApi.md#getstatuscid) | **GET** /status/{cid} | Retrieve information about an upload
[**GetUserUploads**](Web3StorageHTTPAPIApi.md#getuseruploads) | **GET** /user/uploads | List previous uploads
[**HeadCarCid**](Web3StorageHTTPAPIApi.md#headcarcid) | **HEAD** /car/{cid} | Retrieve HTTP headers regarding a CAR
[**PostCar**](Web3StorageHTTPAPIApi.md#postcar) | **POST** /car | Upload a CAR
[**PostPins**](Web3StorageHTTPAPIApi.md#postpins) | **POST** /pins | Add pin object
[**PostPinsRequestid**](Web3StorageHTTPAPIApi.md#postpinsrequestid) | **POST** /pins/{requestid} | Replace pin object
[**PostUpload**](Web3StorageHTTPAPIApi.md#postupload) | **POST** /upload | Upload and store one or more files


<a name="deletepinsrequestid"></a>
# **DeletePinsRequestid**
> void DeletePinsRequestid (string requestid)

Remove pin object

Remove a pin object

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Web3.Storage.Api;
using Web3.Storage.Client;
using Web3.Storage.Model;

namespace Example
{
    public class DeletePinsRequestidExample
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
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Web3StorageHTTPAPIApi.DeletePinsRequestid: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **requestid** | **string**|  | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **202** | Successful response (no body, pin removed) |  -  |
| **400** | Error response (Bad request) |  -  |
| **401** | Error response (Unauthorized; access token is missing or invalid) |  -  |
| **404** | Error response (The specified resource was not found) |  -  |
| **409** | Error response (Insufficient funds) |  -  |
| **4XX** | Error response (Custom service error) |  -  |
| **5XX** | Error response (Unexpected internal server error) |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcarcid"></a>
# **GetCarCid**
> System.IO.Stream GetCarCid (string cid)

Retrieve a CAR

Retrieve an [IPFS DAG](https://docs.ipfs.io/concepts/merkle-dag/) (Directed Acyclic Graph) packaged in a CAR file by using `/car/{cid}`, supplying the CID of the data you are interested in.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Web3.Storage.Api;
using Web3.Storage.Client;
using Web3.Storage.Model;

namespace Example
{
    public class GetCarCidExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.web3.storage";
            var apiInstance = new Web3StorageHTTPAPIApi(config);
            var cid = cid_example;  // string | 

            try
            {
                // Retrieve a CAR
                System.IO.Stream result = apiInstance.GetCarCid(cid);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Web3StorageHTTPAPIApi.GetCarCid: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **cid** | **string**|  | 

### Return type

**System.IO.Stream**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/car, application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |
| **5XX** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpins"></a>
# **GetPins**
> PinResults GetPins (List<string> cid = null, string name = null, TextMatchingStrategy? match = null, List<string> status = null, DateTime? before = null, DateTime? after = null, int? limit = null, Dictionary<string, string> meta = null)

List pin objects

List all the pin objects, matching optional filters; when no filter is provided, only successful pins are returned

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Web3.Storage.Api;
using Web3.Storage.Client;
using Web3.Storage.Model;

namespace Example
{
    public class GetPinsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.web3.storage";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new Web3StorageHTTPAPIApi(config);
            var cid = new List<string>(); // List<string> | Return pin objects responsible for pinning the specified CID(s); be aware that using longer hash functions introduces further constraints on the number of CIDs that will fit under the limit of 2000 characters per URL  in browser contexts (optional) 
            var name = PreciousData.pdf;  // string | Return pin objects with specified name (by default a case-sensitive, exact match) (optional) 
            var match = exact;  // TextMatchingStrategy? | Customize the text matching strategy applied when the name filter is present; exact (the default) is a case-sensitive exact match, partial matches anywhere in the name, iexact and ipartial are case-insensitive versions of the exact and partial strategies (optional) 
            var status = ["queued","pinning"];  // List<string> | Return pin objects for pins with the specified status (optional) 
            var before = 2020-07-27T17:32:28Z;  // DateTime? | Return results created (queued) before provided timestamp (optional) 
            var after = 2020-07-27T17:32:28Z;  // DateTime? | Return results created (queued) after provided timestamp (optional) 
            var limit = 56;  // int? | Max records to return (optional)  (default to 10)
            var meta = new Dictionary<string, string>(); // Dictionary<string, string> | Return pin objects that match specified metadata keys passed as a string representation of a JSON object; when implementing a client library, make sure the parameter is URL-encoded to ensure safe transport (optional) 

            try
            {
                // List pin objects
                PinResults result = apiInstance.GetPins(cid, name, match, status, before, after, limit, meta);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Web3StorageHTTPAPIApi.GetPins: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **cid** | [**List&lt;string&gt;**](string.md)| Return pin objects responsible for pinning the specified CID(s); be aware that using longer hash functions introduces further constraints on the number of CIDs that will fit under the limit of 2000 characters per URL  in browser contexts | [optional] 
 **name** | **string**| Return pin objects with specified name (by default a case-sensitive, exact match) | [optional] 
 **match** | **TextMatchingStrategy?**| Customize the text matching strategy applied when the name filter is present; exact (the default) is a case-sensitive exact match, partial matches anywhere in the name, iexact and ipartial are case-insensitive versions of the exact and partial strategies | [optional] 
 **status** | **List&lt;string&gt;**| Return pin objects for pins with the specified status | [optional] 
 **before** | **DateTime?**| Return results created (queued) before provided timestamp | [optional] 
 **after** | **DateTime?**| Return results created (queued) after provided timestamp | [optional] 
 **limit** | **int?**| Max records to return | [optional] [default to 10]
 **meta** | [**Dictionary&lt;string, string&gt;**](string.md)| Return pin objects that match specified metadata keys passed as a string representation of a JSON object; when implementing a client library, make sure the parameter is URL-encoded to ensure safe transport | [optional] 

### Return type

[**PinResults**](PinResults.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response (PinResults object) |  -  |
| **400** | Error response (Bad request) |  -  |
| **401** | Error response (Unauthorized; access token is missing or invalid) |  -  |
| **404** | Error response (The specified resource was not found) |  -  |
| **409** | Error response (Insufficient funds) |  -  |
| **4XX** | Error response (Custom service error) |  -  |
| **5XX** | Error response (Unexpected internal server error) |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpinsrequestid"></a>
# **GetPinsRequestid**
> PinStatus GetPinsRequestid (string requestid)

Get pin object

Get a pin object and its status

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Web3.Storage.Api;
using Web3.Storage.Client;
using Web3.Storage.Model;

namespace Example
{
    public class GetPinsRequestidExample
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
                // Get pin object
                PinStatus result = apiInstance.GetPinsRequestid(requestid);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Web3StorageHTTPAPIApi.GetPinsRequestid: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **requestid** | **string**|  | 

### Return type

[**PinStatus**](PinStatus.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response (PinStatus object) |  -  |
| **400** | Error response (Bad request) |  -  |
| **401** | Error response (Unauthorized; access token is missing or invalid) |  -  |
| **404** | Error response (The specified resource was not found) |  -  |
| **409** | Error response (Insufficient funds) |  -  |
| **4XX** | Error response (Custom service error) |  -  |
| **5XX** | Error response (Unexpected internal server error) |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getstatuscid"></a>
# **GetStatusCid**
> Status GetStatusCid (string cid)

Retrieve information about an upload

Retrieve metadata about a specific file by using `/status/{cid}`, supplying the CID of the file you are interested in. This metadata includes the creation date and file size, as well as details about how the network is storing your data. Using this information, you can identify peers on the [IPFS (InterPlanetary File System)](https://ipfs.io) network that are pinning the data, and [Filecoin](https://filecoin.io) storage providers that have accepted deals to store the data.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Web3.Storage.Api;
using Web3.Storage.Client;
using Web3.Storage.Model;

namespace Example
{
    public class GetStatusCidExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.web3.storage";
            var apiInstance = new Web3StorageHTTPAPIApi(config);
            var cid = cid_example;  // string | 

            try
            {
                // Retrieve information about an upload
                Status result = apiInstance.GetStatusCid(cid);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Web3StorageHTTPAPIApi.GetStatusCid: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **cid** | **string**|  | 

### Return type

[**Status**](Status.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |
| **5XX** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getuseruploads"></a>
# **GetUserUploads**
> List&lt;Status&gt; GetUserUploads (DateTime? before = null, int? size = null)

List previous uploads

Lists all previous uploads for the account ordered by creation date, newest first. These results can be paginated by specifying `before` and `size` parameters in the query string, using the creation date associated with the oldest upload returned in each batch as the value of `before` in subsequent calls.  Note this endpoint returns all uploads for the account not just the API key in use.  The information returned includes the creation date and file size, as well as details about how the network is storing your data. Using this information, you can identify peers on the [IPFS (InterPlanetary File System)](https://ipfs.io) network that are pinning the data, and [Filecoin](https://filecoin.io) storage providers that have accepted deals to store the data. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Web3.Storage.Api;
using Web3.Storage.Client;
using Web3.Storage.Model;

namespace Example
{
    public class GetUserUploadsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.web3.storage";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new Web3StorageHTTPAPIApi(config);
            var before = 2020-07-27T17:32:28Z;  // DateTime? | Specifies a date, in ISO 8601 format. Ensures that the call to `/list` will not return any results newer than the given date. (optional) 
            var size = 56;  // int? | Specifies the maximum number of uploads to return. (optional)  (default to 25)

            try
            {
                // List previous uploads
                List<Status> result = apiInstance.GetUserUploads(before, size);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Web3StorageHTTPAPIApi.GetUserUploads: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **before** | **DateTime?**| Specifies a date, in ISO 8601 format. Ensures that the call to &#x60;/list&#x60; will not return any results newer than the given date. | [optional] 
 **size** | **int?**| Specifies the maximum number of uploads to return. | [optional] [default to 25]

### Return type

[**List&lt;Status&gt;**](Status.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |
| **5XX** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="headcarcid"></a>
# **HeadCarCid**
> void HeadCarCid (string cid)

Retrieve HTTP headers regarding a CAR

This method is useful for doing a dry run of a call to `/car/{cid}`. Because it only returns HTTP header information, it is far more lightweight and can be used to get only the metadata about the given CAR file without retrieving a whole payload in the body of the HTTP response. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Web3.Storage.Api;
using Web3.Storage.Client;
using Web3.Storage.Model;

namespace Example
{
    public class HeadCarCidExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.web3.storage";
            var apiInstance = new Web3StorageHTTPAPIApi(config);
            var cid = cid_example;  // string | 

            try
            {
                // Retrieve HTTP headers regarding a CAR
                apiInstance.HeadCarCid(cid);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Web3StorageHTTPAPIApi.HeadCarCid: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **cid** | **string**|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |
| **5XX** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postcar"></a>
# **PostCar**
> UploadResponse PostCar (System.IO.Stream body)

Upload a CAR

Upload a [CAR](https://ipld.io/specs/transport/car/) (Content Addressable aRchive) file and store the [IPFS DAG](https://docs.ipfs.io/concepts/merkle-dag/) (Directed Acyclic Graph) it contains.  See the [Working with Content Archives guide](https://docs.web3.storage/how-tos/work-with-car-files) for details on creating CARs and splitting them into chunks for upload using the [carbites JavaScript API](https://github.com/nftstorage/carbites), [command line tool](https://github.com/nftstorage/carbites-cli/), or [Go library](https://github.com/alanshaw/go-carbites).  Requests to this endpoint have a maximum payload size of 100MB but partial DAGs are supported, so multiple CAR files with the same root but with different sub-trees can be sent. This enables uploading of files that are bigger than the maximum payload size.  Note that only one CAR can be uploaded at a time, and only CAR files are accepted. This is in contrast to [`/upload`](#operation/post-upload), which can upload multiple files at once and accepts both CAR files and files from the client.  You can also provide a name for the file using the header `X-NAME`, but be sure to encode the filename first. For example `LICENSE–MIT` should be sent as `LICENSE%E2%80%93MIT`. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Web3.Storage.Api;
using Web3.Storage.Client;
using Web3.Storage.Model;

namespace Example
{
    public class PostCarExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.web3.storage";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new Web3StorageHTTPAPIApi(config);
            var body = BINARY_DATA_HERE;  // System.IO.Stream | 

            try
            {
                // Upload a CAR
                UploadResponse result = apiInstance.PostCar(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Web3StorageHTTPAPIApi.PostCar: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | **System.IO.Stream****System.IO.Stream**|  | 

### Return type

[**UploadResponse**](UploadResponse.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/car, application/octet-stream
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |
| **5XX** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postpins"></a>
# **PostPins**
> PinStatus PostPins (PSAPin pSAPin)

Add pin object

Add a new pin object for the current access token

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Web3.Storage.Api;
using Web3.Storage.Client;
using Web3.Storage.Model;

namespace Example
{
    public class PostPinsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.web3.storage";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new Web3StorageHTTPAPIApi(config);
            var pSAPin = new PSAPin(); // PSAPin | 

            try
            {
                // Add pin object
                PinStatus result = apiInstance.PostPins(pSAPin);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Web3StorageHTTPAPIApi.PostPins: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **pSAPin** | [**PSAPin**](PSAPin.md)|  | 

### Return type

[**PinStatus**](PinStatus.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **202** | Successful response (PinStatus object) |  -  |
| **400** | Error response (Bad request) |  -  |
| **401** | Error response (Unauthorized; access token is missing or invalid) |  -  |
| **404** | Error response (The specified resource was not found) |  -  |
| **409** | Error response (Insufficient funds) |  -  |
| **4XX** | Error response (Custom service error) |  -  |
| **5XX** | Error response (Unexpected internal server error) |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postpinsrequestid"></a>
# **PostPinsRequestid**
> PinStatus PostPinsRequestid (string requestid, PSAPin pSAPin)

Replace pin object

Replace an existing pin object (shortcut for executing remove and add operations in one step to avoid unnecessary garbage collection of blocks present in both recursive pins)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Web3.Storage.Api;
using Web3.Storage.Client;
using Web3.Storage.Model;

namespace Example
{
    public class PostPinsRequestidExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.web3.storage";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new Web3StorageHTTPAPIApi(config);
            var requestid = requestid_example;  // string | 
            var pSAPin = new PSAPin(); // PSAPin | 

            try
            {
                // Replace pin object
                PinStatus result = apiInstance.PostPinsRequestid(requestid, pSAPin);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Web3StorageHTTPAPIApi.PostPinsRequestid: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **requestid** | **string**|  | 
 **pSAPin** | [**PSAPin**](PSAPin.md)|  | 

### Return type

[**PinStatus**](PinStatus.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **202** | Successful response (PinStatus object) |  -  |
| **400** | Error response (Bad request) |  -  |
| **401** | Error response (Unauthorized; access token is missing or invalid) |  -  |
| **404** | Error response (The specified resource was not found) |  -  |
| **409** | Error response (Insufficient funds) |  -  |
| **4XX** | Error response (Custom service error) |  -  |
| **5XX** | Error response (Unexpected internal server error) |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postupload"></a>
# **PostUpload**
> UploadResponse PostUpload (List<System.IO.Stream> file = null)

Upload and store one or more files

Store files using Web3.Storage. You can upload either a single file or multiple files.  Send the POST request with one of the following: - a single file, with a single blob/file object as the body - multiple files, as `FormData` with `Content-Disposition` headers for each part to specify filenames and the request header `Content-Type: multipart/form-data`  Requests to this endpoint have a maximum payload size of 100MB. To upload larger files, see the documentation for the `/car` endpoint.  You can also provide a name for the file using the header `X-NAME`, but be sure to encode the filename first. For example `LICENSE–MIT` should be sent as `LICENSE%E2%80%93MIT`. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Web3.Storage.Api;
using Web3.Storage.Client;
using Web3.Storage.Model;

namespace Example
{
    public class PostUploadExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.web3.storage";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new Web3StorageHTTPAPIApi(config);
            var file = new List<System.IO.Stream>(); // List<System.IO.Stream> |  (optional) 

            try
            {
                // Upload and store one or more files
                UploadResponse result = apiInstance.PostUpload(file);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Web3StorageHTTPAPIApi.PostUpload: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **file** | **List&lt;System.IO.Stream&gt;**|  | [optional] 

### Return type

[**UploadResponse**](UploadResponse.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |
| **5XX** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

