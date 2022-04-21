# Web3Storage.Web3StorageHTTPAPIApi

All URIs are relative to *https://api.web3.storage*

Method | HTTP request | Description
------------- | ------------- | -------------
[**delete_pins_requestid**](Web3StorageHTTPAPIApi.md#delete_pins_requestid) | **DELETE** /pins/{requestid} | Remove pin object
[**get_car_cid**](Web3StorageHTTPAPIApi.md#get_car_cid) | **GET** /car/{cid} | Retrieve a CAR
[**get_pins**](Web3StorageHTTPAPIApi.md#get_pins) | **GET** /pins | List pin objects
[**get_pins_requestid**](Web3StorageHTTPAPIApi.md#get_pins_requestid) | **GET** /pins/{requestid} | Get pin object
[**get_status_cid**](Web3StorageHTTPAPIApi.md#get_status_cid) | **GET** /status/{cid} | Retrieve information about an upload
[**get_user_uploads**](Web3StorageHTTPAPIApi.md#get_user_uploads) | **GET** /user/uploads | List previous uploads
[**head_car_cid**](Web3StorageHTTPAPIApi.md#head_car_cid) | **HEAD** /car/{cid} | Retrieve HTTP headers regarding a CAR
[**post_car**](Web3StorageHTTPAPIApi.md#post_car) | **POST** /car | Upload a CAR
[**post_pins**](Web3StorageHTTPAPIApi.md#post_pins) | **POST** /pins | Add pin object
[**post_pins_requestid**](Web3StorageHTTPAPIApi.md#post_pins_requestid) | **POST** /pins/{requestid} | Replace pin object
[**post_upload**](Web3StorageHTTPAPIApi.md#post_upload) | **POST** /upload | Upload and store one or more files


# **delete_pins_requestid**
> delete_pins_requestid(requestid)

Remove pin object

Remove a pin object

### Example

* Bearer (JWT) Authentication (bearerAuth):
```python
import time
import Web3Storage
from Web3Storage.api import web3_storage_http_api_api
from Web3Storage.model.failure import Failure
from pprint import pprint
# Defining the host is optional and defaults to https://api.web3.storage
# See configuration.py for a list of all supported configuration parameters.
configuration = Web3Storage.Configuration(
    host = "https://api.web3.storage"
)

# The client must configure the authentication and authorization parameters
# in accordance with the API server security policy.
# Examples for each auth method are provided below, use the example that
# satisfies your auth use case.

# Configure Bearer authorization (JWT): bearerAuth
configuration = Web3Storage.Configuration(
    access_token = 'YOUR_BEARER_TOKEN'
)

# Enter a context with an instance of the API client
with Web3Storage.ApiClient(configuration) as api_client:
    # Create an instance of the API class
    api_instance = web3_storage_http_api_api.Web3StorageHTTPAPIApi(api_client)
    requestid = "requestid_example" # str | 

    # example passing only required values which don't have defaults set
    try:
        # Remove pin object
        api_instance.delete_pins_requestid(requestid)
    except Web3Storage.ApiException as e:
        print("Exception when calling Web3StorageHTTPAPIApi->delete_pins_requestid: %s\n" % e)
```


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **requestid** | **str**|  |

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
**202** | Successful response (no body, pin removed) |  -  |
**400** | Error response (Bad request) |  -  |
**401** | Error response (Unauthorized; access token is missing or invalid) |  -  |
**404** | Error response (The specified resource was not found) |  -  |
**409** | Error response (Insufficient funds) |  -  |
**4XX** | Error response (Custom service error) |  -  |
**5XX** | Error response (Unexpected internal server error) |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **get_car_cid**
> file_type get_car_cid(cid)

Retrieve a CAR

Retrieve an [IPFS DAG](https://docs.ipfs.io/concepts/merkle-dag/) (Directed Acyclic Graph) packaged in a CAR file by using `/car/{cid}`, supplying the CID of the data you are interested in.

### Example

```python
import time
import Web3Storage
from Web3Storage.api import web3_storage_http_api_api
from Web3Storage.model.error_response import ErrorResponse
from pprint import pprint
# Defining the host is optional and defaults to https://api.web3.storage
# See configuration.py for a list of all supported configuration parameters.
configuration = Web3Storage.Configuration(
    host = "https://api.web3.storage"
)


# Enter a context with an instance of the API client
with Web3Storage.ApiClient() as api_client:
    # Create an instance of the API class
    api_instance = web3_storage_http_api_api.Web3StorageHTTPAPIApi(api_client)
    cid = "bafkreidivzimqfqtoqxkrpge6bjyhlvxqs3rhe73owtmdulaxr5do5in7u" # str | 

    # example passing only required values which don't have defaults set
    try:
        # Retrieve a CAR
        api_response = api_instance.get_car_cid(cid)
        pprint(api_response)
    except Web3Storage.ApiException as e:
        print("Exception when calling Web3StorageHTTPAPIApi->get_car_cid: %s\n" % e)
```


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **cid** | **str**|  |

### Return type

**file_type**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/car, application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** | OK |  -  |
**400** | Bad Request |  -  |
**5XX** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **get_pins**
> PinResults get_pins()

List pin objects

List all the pin objects, matching optional filters; when no filter is provided, only successful pins are returned

### Example

* Bearer (JWT) Authentication (bearerAuth):
```python
import time
import Web3Storage
from Web3Storage.api import web3_storage_http_api_api
from Web3Storage.model.pin_results import PinResults
from Web3Storage.model.failure import Failure
from Web3Storage.model.pin_meta import PinMeta
from Web3Storage.model.text_matching_strategy import TextMatchingStrategy
from pprint import pprint
# Defining the host is optional and defaults to https://api.web3.storage
# See configuration.py for a list of all supported configuration parameters.
configuration = Web3Storage.Configuration(
    host = "https://api.web3.storage"
)

# The client must configure the authentication and authorization parameters
# in accordance with the API server security policy.
# Examples for each auth method are provided below, use the example that
# satisfies your auth use case.

# Configure Bearer authorization (JWT): bearerAuth
configuration = Web3Storage.Configuration(
    access_token = 'YOUR_BEARER_TOKEN'
)

# Enter a context with an instance of the API client
with Web3Storage.ApiClient(configuration) as api_client:
    # Create an instance of the API class
    api_instance = web3_storage_http_api_api.Web3StorageHTTPAPIApi(api_client)
    cid = ["Qm1","Qm2","bafy3"] # [str] | Return pin objects responsible for pinning the specified CID(s); be aware that using longer hash functions introduces further constraints on the number of CIDs that will fit under the limit of 2000 characters per URL  in browser contexts (optional)
    name = "PreciousData.pdf" # str | Return pin objects with specified name (by default a case-sensitive, exact match) (optional)
    match = TextMatchingStrategy("exact") # TextMatchingStrategy | Customize the text matching strategy applied when the name filter is present; exact (the default) is a case-sensitive exact match, partial matches anywhere in the name, iexact and ipartial are case-insensitive versions of the exact and partial strategies (optional)
    status = ["queued","pinning"] # [str] | Return pin objects for pins with the specified status (optional)
    before = dateutil_parser('2020-07-27T17:32:28Z') # datetime | Return results created (queued) before provided timestamp (optional)
    after = dateutil_parser('2020-07-27T17:32:28Z') # datetime | Return results created (queued) after provided timestamp (optional)
    limit = 10 # int | Max records to return (optional) if omitted the server will use the default value of 10
    meta =  # PinMeta | Return pin objects that match specified metadata keys passed as a string representation of a JSON object; when implementing a client library, make sure the parameter is URL-encoded to ensure safe transport (optional)

    # example passing only required values which don't have defaults set
    # and optional values
    try:
        # List pin objects
        api_response = api_instance.get_pins(cid=cid, name=name, match=match, status=status, before=before, after=after, limit=limit, meta=meta)
        pprint(api_response)
    except Web3Storage.ApiException as e:
        print("Exception when calling Web3StorageHTTPAPIApi->get_pins: %s\n" % e)
```


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **cid** | **[str]**| Return pin objects responsible for pinning the specified CID(s); be aware that using longer hash functions introduces further constraints on the number of CIDs that will fit under the limit of 2000 characters per URL  in browser contexts | [optional]
 **name** | **str**| Return pin objects with specified name (by default a case-sensitive, exact match) | [optional]
 **match** | **TextMatchingStrategy**| Customize the text matching strategy applied when the name filter is present; exact (the default) is a case-sensitive exact match, partial matches anywhere in the name, iexact and ipartial are case-insensitive versions of the exact and partial strategies | [optional]
 **status** | **[str]**| Return pin objects for pins with the specified status | [optional]
 **before** | **datetime**| Return results created (queued) before provided timestamp | [optional]
 **after** | **datetime**| Return results created (queued) after provided timestamp | [optional]
 **limit** | **int**| Max records to return | [optional] if omitted the server will use the default value of 10
 **meta** | **PinMeta**| Return pin objects that match specified metadata keys passed as a string representation of a JSON object; when implementing a client library, make sure the parameter is URL-encoded to ensure safe transport | [optional]

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
**200** | Successful response (PinResults object) |  -  |
**400** | Error response (Bad request) |  -  |
**401** | Error response (Unauthorized; access token is missing or invalid) |  -  |
**404** | Error response (The specified resource was not found) |  -  |
**409** | Error response (Insufficient funds) |  -  |
**4XX** | Error response (Custom service error) |  -  |
**5XX** | Error response (Unexpected internal server error) |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **get_pins_requestid**
> PinStatus get_pins_requestid(requestid)

Get pin object

Get a pin object and its status

### Example

* Bearer (JWT) Authentication (bearerAuth):
```python
import time
import Web3Storage
from Web3Storage.api import web3_storage_http_api_api
from Web3Storage.model.failure import Failure
from Web3Storage.model.pin_status import PinStatus
from pprint import pprint
# Defining the host is optional and defaults to https://api.web3.storage
# See configuration.py for a list of all supported configuration parameters.
configuration = Web3Storage.Configuration(
    host = "https://api.web3.storage"
)

# The client must configure the authentication and authorization parameters
# in accordance with the API server security policy.
# Examples for each auth method are provided below, use the example that
# satisfies your auth use case.

# Configure Bearer authorization (JWT): bearerAuth
configuration = Web3Storage.Configuration(
    access_token = 'YOUR_BEARER_TOKEN'
)

# Enter a context with an instance of the API client
with Web3Storage.ApiClient(configuration) as api_client:
    # Create an instance of the API class
    api_instance = web3_storage_http_api_api.Web3StorageHTTPAPIApi(api_client)
    requestid = "requestid_example" # str | 

    # example passing only required values which don't have defaults set
    try:
        # Get pin object
        api_response = api_instance.get_pins_requestid(requestid)
        pprint(api_response)
    except Web3Storage.ApiException as e:
        print("Exception when calling Web3StorageHTTPAPIApi->get_pins_requestid: %s\n" % e)
```


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **requestid** | **str**|  |

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
**200** | Successful response (PinStatus object) |  -  |
**400** | Error response (Bad request) |  -  |
**401** | Error response (Unauthorized; access token is missing or invalid) |  -  |
**404** | Error response (The specified resource was not found) |  -  |
**409** | Error response (Insufficient funds) |  -  |
**4XX** | Error response (Custom service error) |  -  |
**5XX** | Error response (Unexpected internal server error) |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **get_status_cid**
> Status get_status_cid(cid)

Retrieve information about an upload

Retrieve metadata about a specific file by using `/status/{cid}`, supplying the CID of the file you are interested in. This metadata includes the creation date and file size, as well as details about how the network is storing your data. Using this information, you can identify peers on the [IPFS (InterPlanetary File System)](https://ipfs.io) network that are pinning the data, and [Filecoin](https://filecoin.io) storage providers that have accepted deals to store the data.

### Example

```python
import time
import Web3Storage
from Web3Storage.api import web3_storage_http_api_api
from Web3Storage.model.status import Status
from Web3Storage.model.error_response import ErrorResponse
from pprint import pprint
# Defining the host is optional and defaults to https://api.web3.storage
# See configuration.py for a list of all supported configuration parameters.
configuration = Web3Storage.Configuration(
    host = "https://api.web3.storage"
)


# Enter a context with an instance of the API client
with Web3Storage.ApiClient() as api_client:
    # Create an instance of the API class
    api_instance = web3_storage_http_api_api.Web3StorageHTTPAPIApi(api_client)
    cid = "bafkreidivzimqfqtoqxkrpge6bjyhlvxqs3rhe73owtmdulaxr5do5in7u" # str | 

    # example passing only required values which don't have defaults set
    try:
        # Retrieve information about an upload
        api_response = api_instance.get_status_cid(cid)
        pprint(api_response)
    except Web3Storage.ApiException as e:
        print("Exception when calling Web3StorageHTTPAPIApi->get_status_cid: %s\n" % e)
```


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **cid** | **str**|  |

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
**200** | OK |  -  |
**400** | Bad Request |  -  |
**5XX** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **get_user_uploads**
> [Status] get_user_uploads()

List previous uploads

Lists all previous uploads for the account ordered by creation date, newest first. These results can be paginated by specifying `before` and `size` parameters in the query string, using the creation date associated with the oldest upload returned in each batch as the value of `before` in subsequent calls.  Note this endpoint returns all uploads for the account not just the API key in use.  The information returned includes the creation date and file size, as well as details about how the network is storing your data. Using this information, you can identify peers on the [IPFS (InterPlanetary File System)](https://ipfs.io) network that are pinning the data, and [Filecoin](https://filecoin.io) storage providers that have accepted deals to store the data. 

### Example

* Bearer (JWT) Authentication (bearerAuth):
```python
import time
import Web3Storage
from Web3Storage.api import web3_storage_http_api_api
from Web3Storage.model.unauthorized_error_response import UnauthorizedErrorResponse
from Web3Storage.model.status import Status
from Web3Storage.model.error_response import ErrorResponse
from Web3Storage.model.forbidden_error_response import ForbiddenErrorResponse
from pprint import pprint
# Defining the host is optional and defaults to https://api.web3.storage
# See configuration.py for a list of all supported configuration parameters.
configuration = Web3Storage.Configuration(
    host = "https://api.web3.storage"
)

# The client must configure the authentication and authorization parameters
# in accordance with the API server security policy.
# Examples for each auth method are provided below, use the example that
# satisfies your auth use case.

# Configure Bearer authorization (JWT): bearerAuth
configuration = Web3Storage.Configuration(
    access_token = 'YOUR_BEARER_TOKEN'
)

# Enter a context with an instance of the API client
with Web3Storage.ApiClient(configuration) as api_client:
    # Create an instance of the API class
    api_instance = web3_storage_http_api_api.Web3StorageHTTPAPIApi(api_client)
    before = dateutil_parser('2020-07-27T17:32:28Z') # datetime | Specifies a date, in ISO 8601 format. Ensures that the call to `/list` will not return any results newer than the given date. (optional)
    size = 25 # int | Specifies the maximum number of uploads to return. (optional) if omitted the server will use the default value of 25

    # example passing only required values which don't have defaults set
    # and optional values
    try:
        # List previous uploads
        api_response = api_instance.get_user_uploads(before=before, size=size)
        pprint(api_response)
    except Web3Storage.ApiException as e:
        print("Exception when calling Web3StorageHTTPAPIApi->get_user_uploads: %s\n" % e)
```


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **before** | **datetime**| Specifies a date, in ISO 8601 format. Ensures that the call to &#x60;/list&#x60; will not return any results newer than the given date. | [optional]
 **size** | **int**| Specifies the maximum number of uploads to return. | [optional] if omitted the server will use the default value of 25

### Return type

[**[Status]**](Status.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** | OK |  -  |
**400** | Bad Request |  -  |
**401** | Unauthorized |  -  |
**403** | Forbidden |  -  |
**5XX** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **head_car_cid**
> head_car_cid(cid)

Retrieve HTTP headers regarding a CAR

This method is useful for doing a dry run of a call to `/car/{cid}`. Because it only returns HTTP header information, it is far more lightweight and can be used to get only the metadata about the given CAR file without retrieving a whole payload in the body of the HTTP response. 

### Example

```python
import time
import Web3Storage
from Web3Storage.api import web3_storage_http_api_api
from Web3Storage.model.error_response import ErrorResponse
from pprint import pprint
# Defining the host is optional and defaults to https://api.web3.storage
# See configuration.py for a list of all supported configuration parameters.
configuration = Web3Storage.Configuration(
    host = "https://api.web3.storage"
)


# Enter a context with an instance of the API client
with Web3Storage.ApiClient() as api_client:
    # Create an instance of the API class
    api_instance = web3_storage_http_api_api.Web3StorageHTTPAPIApi(api_client)
    cid = "bafkreidivzimqfqtoqxkrpge6bjyhlvxqs3rhe73owtmdulaxr5do5in7u" # str | 

    # example passing only required values which don't have defaults set
    try:
        # Retrieve HTTP headers regarding a CAR
        api_instance.head_car_cid(cid)
    except Web3Storage.ApiException as e:
        print("Exception when calling Web3StorageHTTPAPIApi->head_car_cid: %s\n" % e)
```


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **cid** | **str**|  |

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
**200** | OK |  -  |
**400** | Bad Request |  -  |
**5XX** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **post_car**
> UploadResponse post_car(body)

Upload a CAR

Upload a [CAR](https://ipld.io/specs/transport/car/) (Content Addressable aRchive) file and store the [IPFS DAG](https://docs.ipfs.io/concepts/merkle-dag/) (Directed Acyclic Graph) it contains.  See the [Working with Content Archives guide](https://docs.web3.storage/how-tos/work-with-car-files) for details on creating CARs and splitting them into chunks for upload using the [carbites JavaScript API](https://github.com/nftstorage/carbites), [command line tool](https://github.com/nftstorage/carbites-cli/), or [Go library](https://github.com/alanshaw/go-carbites).  Requests to this endpoint have a maximum payload size of 100MB but partial DAGs are supported, so multiple CAR files with the same root but with different sub-trees can be sent. This enables uploading of files that are bigger than the maximum payload size.  Note that only one CAR can be uploaded at a time, and only CAR files are accepted. This is in contrast to [`/upload`](#operation/post-upload), which can upload multiple files at once and accepts both CAR files and files from the client.  You can also provide a name for the file using the header `X-NAME`, but be sure to encode the filename first. For example `LICENSE–MIT` should be sent as `LICENSE%E2%80%93MIT`. 

### Example

* Bearer (JWT) Authentication (bearerAuth):
```python
import time
import Web3Storage
from Web3Storage.api import web3_storage_http_api_api
from Web3Storage.model.unauthorized_error_response import UnauthorizedErrorResponse
from Web3Storage.model.upload_response import UploadResponse
from Web3Storage.model.error_response import ErrorResponse
from Web3Storage.model.forbidden_error_response import ForbiddenErrorResponse
from pprint import pprint
# Defining the host is optional and defaults to https://api.web3.storage
# See configuration.py for a list of all supported configuration parameters.
configuration = Web3Storage.Configuration(
    host = "https://api.web3.storage"
)

# The client must configure the authentication and authorization parameters
# in accordance with the API server security policy.
# Examples for each auth method are provided below, use the example that
# satisfies your auth use case.

# Configure Bearer authorization (JWT): bearerAuth
configuration = Web3Storage.Configuration(
    access_token = 'YOUR_BEARER_TOKEN'
)

# Enter a context with an instance of the API client
with Web3Storage.ApiClient(configuration) as api_client:
    # Create an instance of the API class
    api_instance = web3_storage_http_api_api.Web3StorageHTTPAPIApi(api_client)
    body = open('/path/to/file', 'rb') # file_type | 

    # example passing only required values which don't have defaults set
    try:
        # Upload a CAR
        api_response = api_instance.post_car(body)
        pprint(api_response)
    except Web3Storage.ApiException as e:
        print("Exception when calling Web3StorageHTTPAPIApi->post_car: %s\n" % e)
```


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | **file_type**|  |

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
**200** | OK |  -  |
**400** | Bad Request |  -  |
**401** | Unauthorized |  -  |
**403** | Forbidden |  -  |
**5XX** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **post_pins**
> PinStatus post_pins(psa_pin)

Add pin object

Add a new pin object for the current access token

### Example

* Bearer (JWT) Authentication (bearerAuth):
```python
import time
import Web3Storage
from Web3Storage.api import web3_storage_http_api_api
from Web3Storage.model.psa_pin import PSAPin
from Web3Storage.model.failure import Failure
from Web3Storage.model.pin_status import PinStatus
from pprint import pprint
# Defining the host is optional and defaults to https://api.web3.storage
# See configuration.py for a list of all supported configuration parameters.
configuration = Web3Storage.Configuration(
    host = "https://api.web3.storage"
)

# The client must configure the authentication and authorization parameters
# in accordance with the API server security policy.
# Examples for each auth method are provided below, use the example that
# satisfies your auth use case.

# Configure Bearer authorization (JWT): bearerAuth
configuration = Web3Storage.Configuration(
    access_token = 'YOUR_BEARER_TOKEN'
)

# Enter a context with an instance of the API client
with Web3Storage.ApiClient(configuration) as api_client:
    # Create an instance of the API class
    api_instance = web3_storage_http_api_api.Web3StorageHTTPAPIApi(api_client)
    psa_pin = PSAPin(
        cid="QmCIDToBePinned",
        name="PreciousData.pdf",
        origins=Origins(["/ip4/203.0.113.142/tcp/4001/p2p/QmSourcePeerId","/ip4/203.0.113.114/udp/4001/quic/p2p/QmSourcePeerId"]),
        meta=PinMeta(
            key="key_example",
        ),
    ) # PSAPin | 

    # example passing only required values which don't have defaults set
    try:
        # Add pin object
        api_response = api_instance.post_pins(psa_pin)
        pprint(api_response)
    except Web3Storage.ApiException as e:
        print("Exception when calling Web3StorageHTTPAPIApi->post_pins: %s\n" % e)
```


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **psa_pin** | [**PSAPin**](PSAPin.md)|  |

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
**202** | Successful response (PinStatus object) |  -  |
**400** | Error response (Bad request) |  -  |
**401** | Error response (Unauthorized; access token is missing or invalid) |  -  |
**404** | Error response (The specified resource was not found) |  -  |
**409** | Error response (Insufficient funds) |  -  |
**4XX** | Error response (Custom service error) |  -  |
**5XX** | Error response (Unexpected internal server error) |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **post_pins_requestid**
> PinStatus post_pins_requestid(requestid, psa_pin)

Replace pin object

Replace an existing pin object (shortcut for executing remove and add operations in one step to avoid unnecessary garbage collection of blocks present in both recursive pins)

### Example

* Bearer (JWT) Authentication (bearerAuth):
```python
import time
import Web3Storage
from Web3Storage.api import web3_storage_http_api_api
from Web3Storage.model.psa_pin import PSAPin
from Web3Storage.model.failure import Failure
from Web3Storage.model.pin_status import PinStatus
from pprint import pprint
# Defining the host is optional and defaults to https://api.web3.storage
# See configuration.py for a list of all supported configuration parameters.
configuration = Web3Storage.Configuration(
    host = "https://api.web3.storage"
)

# The client must configure the authentication and authorization parameters
# in accordance with the API server security policy.
# Examples for each auth method are provided below, use the example that
# satisfies your auth use case.

# Configure Bearer authorization (JWT): bearerAuth
configuration = Web3Storage.Configuration(
    access_token = 'YOUR_BEARER_TOKEN'
)

# Enter a context with an instance of the API client
with Web3Storage.ApiClient(configuration) as api_client:
    # Create an instance of the API class
    api_instance = web3_storage_http_api_api.Web3StorageHTTPAPIApi(api_client)
    requestid = "requestid_example" # str | 
    psa_pin = PSAPin(
        cid="QmCIDToBePinned",
        name="PreciousData.pdf",
        origins=Origins(["/ip4/203.0.113.142/tcp/4001/p2p/QmSourcePeerId","/ip4/203.0.113.114/udp/4001/quic/p2p/QmSourcePeerId"]),
        meta=PinMeta(
            key="key_example",
        ),
    ) # PSAPin | 

    # example passing only required values which don't have defaults set
    try:
        # Replace pin object
        api_response = api_instance.post_pins_requestid(requestid, psa_pin)
        pprint(api_response)
    except Web3Storage.ApiException as e:
        print("Exception when calling Web3StorageHTTPAPIApi->post_pins_requestid: %s\n" % e)
```


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **requestid** | **str**|  |
 **psa_pin** | [**PSAPin**](PSAPin.md)|  |

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
**202** | Successful response (PinStatus object) |  -  |
**400** | Error response (Bad request) |  -  |
**401** | Error response (Unauthorized; access token is missing or invalid) |  -  |
**404** | Error response (The specified resource was not found) |  -  |
**409** | Error response (Insufficient funds) |  -  |
**4XX** | Error response (Custom service error) |  -  |
**5XX** | Error response (Unexpected internal server error) |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **post_upload**
> UploadResponse post_upload()

Upload and store one or more files

Store files using Web3.Storage. You can upload either a single file or multiple files.  Send the POST request with one of the following: - a single file, with a single blob/file object as the body - multiple files, as `FormData` with `Content-Disposition` headers for each part to specify filenames and the request header `Content-Type: multipart/form-data`  Requests to this endpoint have a maximum payload size of 100MB. To upload larger files, see the documentation for the `/car` endpoint.  You can also provide a name for the file using the header `X-NAME`, but be sure to encode the filename first. For example `LICENSE–MIT` should be sent as `LICENSE%E2%80%93MIT`. 

### Example

* Bearer (JWT) Authentication (bearerAuth):
```python
import time
import Web3Storage
from Web3Storage.api import web3_storage_http_api_api
from Web3Storage.model.unauthorized_error_response import UnauthorizedErrorResponse
from Web3Storage.model.upload_response import UploadResponse
from Web3Storage.model.error_response import ErrorResponse
from Web3Storage.model.forbidden_error_response import ForbiddenErrorResponse
from pprint import pprint
# Defining the host is optional and defaults to https://api.web3.storage
# See configuration.py for a list of all supported configuration parameters.
configuration = Web3Storage.Configuration(
    host = "https://api.web3.storage"
)

# The client must configure the authentication and authorization parameters
# in accordance with the API server security policy.
# Examples for each auth method are provided below, use the example that
# satisfies your auth use case.

# Configure Bearer authorization (JWT): bearerAuth
configuration = Web3Storage.Configuration(
    access_token = 'YOUR_BEARER_TOKEN'
)

# Enter a context with an instance of the API client
with Web3Storage.ApiClient(configuration) as api_client:
    # Create an instance of the API class
    api_instance = web3_storage_http_api_api.Web3StorageHTTPAPIApi(api_client)
    file = open('/path/to/file', 'rb') # [file_type] |  (optional)

    # example passing only required values which don't have defaults set
    # and optional values
    try:
        # Upload and store one or more files
        api_response = api_instance.post_upload(file=file)
        pprint(api_response)
    except Web3Storage.ApiException as e:
        print("Exception when calling Web3StorageHTTPAPIApi->post_upload: %s\n" % e)
```


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **file** | **[file_type]**|  | [optional]

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
**200** | OK |  -  |
**400** | Bad Request |  -  |
**401** | Unauthorized |  -  |
**403** | Forbidden |  -  |
**5XX** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

