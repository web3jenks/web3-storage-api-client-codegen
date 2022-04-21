# OpenAPI\Client\Web3StorageHTTPAPIApi

All URIs are relative to https://api.web3.storage.

Method | HTTP request | Description
------------- | ------------- | -------------
[**deletePinsRequestid()**](Web3StorageHTTPAPIApi.md#deletePinsRequestid) | **DELETE** /pins/{requestid} | Remove pin object
[**getCarCid()**](Web3StorageHTTPAPIApi.md#getCarCid) | **GET** /car/{cid} | Retrieve a CAR
[**getPins()**](Web3StorageHTTPAPIApi.md#getPins) | **GET** /pins | List pin objects
[**getPinsRequestid()**](Web3StorageHTTPAPIApi.md#getPinsRequestid) | **GET** /pins/{requestid} | Get pin object
[**getStatusCid()**](Web3StorageHTTPAPIApi.md#getStatusCid) | **GET** /status/{cid} | Retrieve information about an upload
[**getUserUploads()**](Web3StorageHTTPAPIApi.md#getUserUploads) | **GET** /user/uploads | List previous uploads
[**headCarCid()**](Web3StorageHTTPAPIApi.md#headCarCid) | **HEAD** /car/{cid} | Retrieve HTTP headers regarding a CAR
[**postCar()**](Web3StorageHTTPAPIApi.md#postCar) | **POST** /car | Upload a CAR
[**postPins()**](Web3StorageHTTPAPIApi.md#postPins) | **POST** /pins | Add pin object
[**postPinsRequestid()**](Web3StorageHTTPAPIApi.md#postPinsRequestid) | **POST** /pins/{requestid} | Replace pin object
[**postUpload()**](Web3StorageHTTPAPIApi.md#postUpload) | **POST** /upload | Upload and store one or more files


## `deletePinsRequestid()`

```php
deletePinsRequestid($requestid)
```

Remove pin object

Remove a pin object

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer (JWT) authorization: bearerAuth
$config = OpenAPI\Client\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OpenAPI\Client\Api\Web3StorageHTTPAPIApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$requestid = 'requestid_example'; // string

try {
    $apiInstance->deletePinsRequestid($requestid);
} catch (Exception $e) {
    echo 'Exception when calling Web3StorageHTTPAPIApi->deletePinsRequestid: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **requestid** | **string**|  |

### Return type

void (empty response body)

### Authorization

[bearerAuth](../../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `getCarCid()`

```php
getCarCid($cid): \SplFileObject
```

Retrieve a CAR

Retrieve an [IPFS DAG](https://docs.ipfs.io/concepts/merkle-dag/) (Directed Acyclic Graph) packaged in a CAR file by using `/car/{cid}`, supplying the CID of the data you are interested in.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');



$apiInstance = new OpenAPI\Client\Api\Web3StorageHTTPAPIApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$cid = 'cid_example'; // string

try {
    $result = $apiInstance->getCarCid($cid);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling Web3StorageHTTPAPIApi->getCarCid: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **cid** | **string**|  |

### Return type

[**\SplFileObject**](../Model/\SplFileObject.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/car`, `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `getPins()`

```php
getPins($cid, $name, $match, $status, $before, $after, $limit, $meta): \OpenAPI\Client\Model\PinResults
```

List pin objects

List all the pin objects, matching optional filters; when no filter is provided, only successful pins are returned

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer (JWT) authorization: bearerAuth
$config = OpenAPI\Client\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OpenAPI\Client\Api\Web3StorageHTTPAPIApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$cid = ["Qm1","Qm2","bafy3"]; // string[] | Return pin objects responsible for pinning the specified CID(s); be aware that using longer hash functions introduces further constraints on the number of CIDs that will fit under the limit of 2000 characters per URL  in browser contexts
$name = PreciousData.pdf; // string | Return pin objects with specified name (by default a case-sensitive, exact match)
$match = exact; // \OpenAPI\Client\Model\TextMatchingStrategy | Customize the text matching strategy applied when the name filter is present; exact (the default) is a case-sensitive exact match, partial matches anywhere in the name, iexact and ipartial are case-insensitive versions of the exact and partial strategies
$status = ["queued","pinning"]; // string[] | Return pin objects for pins with the specified status
$before = 2020-07-27T17:32:28Z; // \DateTime | Return results created (queued) before provided timestamp
$after = 2020-07-27T17:32:28Z; // \DateTime | Return results created (queued) after provided timestamp
$limit = 10; // int | Max records to return
$meta = array('key' => 'meta_example'); // array<string,string> | Return pin objects that match specified metadata keys passed as a string representation of a JSON object; when implementing a client library, make sure the parameter is URL-encoded to ensure safe transport

try {
    $result = $apiInstance->getPins($cid, $name, $match, $status, $before, $after, $limit, $meta);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling Web3StorageHTTPAPIApi->getPins: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **cid** | [**string[]**](../Model/string.md)| Return pin objects responsible for pinning the specified CID(s); be aware that using longer hash functions introduces further constraints on the number of CIDs that will fit under the limit of 2000 characters per URL  in browser contexts | [optional]
 **name** | **string**| Return pin objects with specified name (by default a case-sensitive, exact match) | [optional]
 **match** | [**\OpenAPI\Client\Model\TextMatchingStrategy**](../Model/.md)| Customize the text matching strategy applied when the name filter is present; exact (the default) is a case-sensitive exact match, partial matches anywhere in the name, iexact and ipartial are case-insensitive versions of the exact and partial strategies | [optional]
 **status** | [**string[]**](../Model/string.md)| Return pin objects for pins with the specified status | [optional]
 **before** | **\DateTime**| Return results created (queued) before provided timestamp | [optional]
 **after** | **\DateTime**| Return results created (queued) after provided timestamp | [optional]
 **limit** | **int**| Max records to return | [optional] [default to 10]
 **meta** | [**array<string,string>**](../Model/string.md)| Return pin objects that match specified metadata keys passed as a string representation of a JSON object; when implementing a client library, make sure the parameter is URL-encoded to ensure safe transport | [optional]

### Return type

[**\OpenAPI\Client\Model\PinResults**](../Model/PinResults.md)

### Authorization

[bearerAuth](../../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `getPinsRequestid()`

```php
getPinsRequestid($requestid): \OpenAPI\Client\Model\PinStatus
```

Get pin object

Get a pin object and its status

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer (JWT) authorization: bearerAuth
$config = OpenAPI\Client\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OpenAPI\Client\Api\Web3StorageHTTPAPIApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$requestid = 'requestid_example'; // string

try {
    $result = $apiInstance->getPinsRequestid($requestid);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling Web3StorageHTTPAPIApi->getPinsRequestid: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **requestid** | **string**|  |

### Return type

[**\OpenAPI\Client\Model\PinStatus**](../Model/PinStatus.md)

### Authorization

[bearerAuth](../../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `getStatusCid()`

```php
getStatusCid($cid): \OpenAPI\Client\Model\Status
```

Retrieve information about an upload

Retrieve metadata about a specific file by using `/status/{cid}`, supplying the CID of the file you are interested in. This metadata includes the creation date and file size, as well as details about how the network is storing your data. Using this information, you can identify peers on the [IPFS (InterPlanetary File System)](https://ipfs.io) network that are pinning the data, and [Filecoin](https://filecoin.io) storage providers that have accepted deals to store the data.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');



$apiInstance = new OpenAPI\Client\Api\Web3StorageHTTPAPIApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$cid = 'cid_example'; // string

try {
    $result = $apiInstance->getStatusCid($cid);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling Web3StorageHTTPAPIApi->getStatusCid: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **cid** | **string**|  |

### Return type

[**\OpenAPI\Client\Model\Status**](../Model/Status.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `getUserUploads()`

```php
getUserUploads($before, $size): \OpenAPI\Client\Model\Status[]
```

List previous uploads

Lists all previous uploads for the account ordered by creation date, newest first. These results can be paginated by specifying `before` and `size` parameters in the query string, using the creation date associated with the oldest upload returned in each batch as the value of `before` in subsequent calls.  Note this endpoint returns all uploads for the account not just the API key in use.  The information returned includes the creation date and file size, as well as details about how the network is storing your data. Using this information, you can identify peers on the [IPFS (InterPlanetary File System)](https://ipfs.io) network that are pinning the data, and [Filecoin](https://filecoin.io) storage providers that have accepted deals to store the data.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer (JWT) authorization: bearerAuth
$config = OpenAPI\Client\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OpenAPI\Client\Api\Web3StorageHTTPAPIApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$before = 2020-07-27T17:32:28Z; // \DateTime | Specifies a date, in ISO 8601 format. Ensures that the call to `/list` will not return any results newer than the given date.
$size = 25; // int | Specifies the maximum number of uploads to return.

try {
    $result = $apiInstance->getUserUploads($before, $size);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling Web3StorageHTTPAPIApi->getUserUploads: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **before** | **\DateTime**| Specifies a date, in ISO 8601 format. Ensures that the call to &#x60;/list&#x60; will not return any results newer than the given date. | [optional]
 **size** | **int**| Specifies the maximum number of uploads to return. | [optional] [default to 25]

### Return type

[**\OpenAPI\Client\Model\Status[]**](../Model/Status.md)

### Authorization

[bearerAuth](../../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `headCarCid()`

```php
headCarCid($cid)
```

Retrieve HTTP headers regarding a CAR

This method is useful for doing a dry run of a call to `/car/{cid}`. Because it only returns HTTP header information, it is far more lightweight and can be used to get only the metadata about the given CAR file without retrieving a whole payload in the body of the HTTP response.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');



$apiInstance = new OpenAPI\Client\Api\Web3StorageHTTPAPIApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$cid = 'cid_example'; // string

try {
    $apiInstance->headCarCid($cid);
} catch (Exception $e) {
    echo 'Exception when calling Web3StorageHTTPAPIApi->headCarCid: ', $e->getMessage(), PHP_EOL;
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
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `postCar()`

```php
postCar($body): \OpenAPI\Client\Model\UploadResponse
```

Upload a CAR

Upload a [CAR](https://ipld.io/specs/transport/car/) (Content Addressable aRchive) file and store the [IPFS DAG](https://docs.ipfs.io/concepts/merkle-dag/) (Directed Acyclic Graph) it contains.  See the [Working with Content Archives guide](https://docs.web3.storage/how-tos/work-with-car-files) for details on creating CARs and splitting them into chunks for upload using the [carbites JavaScript API](https://github.com/nftstorage/carbites), [command line tool](https://github.com/nftstorage/carbites-cli/), or [Go library](https://github.com/alanshaw/go-carbites).  Requests to this endpoint have a maximum payload size of 100MB but partial DAGs are supported, so multiple CAR files with the same root but with different sub-trees can be sent. This enables uploading of files that are bigger than the maximum payload size.  Note that only one CAR can be uploaded at a time, and only CAR files are accepted. This is in contrast to [`/upload`](#operation/post-upload), which can upload multiple files at once and accepts both CAR files and files from the client.  You can also provide a name for the file using the header `X-NAME`, but be sure to encode the filename first. For example `LICENSE–MIT` should be sent as `LICENSE%E2%80%93MIT`.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer (JWT) authorization: bearerAuth
$config = OpenAPI\Client\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OpenAPI\Client\Api\Web3StorageHTTPAPIApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$body = "/path/to/file.txt"; // \SplFileObject

try {
    $result = $apiInstance->postCar($body);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling Web3StorageHTTPAPIApi->postCar: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | **\SplFileObject****\SplFileObject**|  |

### Return type

[**\OpenAPI\Client\Model\UploadResponse**](../Model/UploadResponse.md)

### Authorization

[bearerAuth](../../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: `application/car`, `application/octet-stream`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `postPins()`

```php
postPins($psa_pin): \OpenAPI\Client\Model\PinStatus
```

Add pin object

Add a new pin object for the current access token

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer (JWT) authorization: bearerAuth
$config = OpenAPI\Client\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OpenAPI\Client\Api\Web3StorageHTTPAPIApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$psa_pin = new \OpenAPI\Client\Model\PSAPin(); // \OpenAPI\Client\Model\PSAPin

try {
    $result = $apiInstance->postPins($psa_pin);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling Web3StorageHTTPAPIApi->postPins: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **psa_pin** | [**\OpenAPI\Client\Model\PSAPin**](../Model/PSAPin.md)|  |

### Return type

[**\OpenAPI\Client\Model\PinStatus**](../Model/PinStatus.md)

### Authorization

[bearerAuth](../../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `postPinsRequestid()`

```php
postPinsRequestid($requestid, $psa_pin): \OpenAPI\Client\Model\PinStatus
```

Replace pin object

Replace an existing pin object (shortcut for executing remove and add operations in one step to avoid unnecessary garbage collection of blocks present in both recursive pins)

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer (JWT) authorization: bearerAuth
$config = OpenAPI\Client\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OpenAPI\Client\Api\Web3StorageHTTPAPIApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$requestid = 'requestid_example'; // string
$psa_pin = new \OpenAPI\Client\Model\PSAPin(); // \OpenAPI\Client\Model\PSAPin

try {
    $result = $apiInstance->postPinsRequestid($requestid, $psa_pin);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling Web3StorageHTTPAPIApi->postPinsRequestid: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **requestid** | **string**|  |
 **psa_pin** | [**\OpenAPI\Client\Model\PSAPin**](../Model/PSAPin.md)|  |

### Return type

[**\OpenAPI\Client\Model\PinStatus**](../Model/PinStatus.md)

### Authorization

[bearerAuth](../../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `postUpload()`

```php
postUpload($file): \OpenAPI\Client\Model\UploadResponse
```

Upload and store one or more files

Store files using Web3.Storage. You can upload either a single file or multiple files.  Send the POST request with one of the following: - a single file, with a single blob/file object as the body - multiple files, as `FormData` with `Content-Disposition` headers for each part to specify filenames and the request header `Content-Type: multipart/form-data`  Requests to this endpoint have a maximum payload size of 100MB. To upload larger files, see the documentation for the `/car` endpoint.  You can also provide a name for the file using the header `X-NAME`, but be sure to encode the filename first. For example `LICENSE–MIT` should be sent as `LICENSE%E2%80%93MIT`.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer (JWT) authorization: bearerAuth
$config = OpenAPI\Client\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OpenAPI\Client\Api\Web3StorageHTTPAPIApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$file = "/path/to/file.txt"; // \SplFileObject[]

try {
    $result = $apiInstance->postUpload($file);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling Web3StorageHTTPAPIApi->postUpload: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **file** | **\SplFileObject[]**|  | [optional]

### Return type

[**\OpenAPI\Client\Model\UploadResponse**](../Model/UploadResponse.md)

### Authorization

[bearerAuth](../../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: `multipart/form-data`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)
