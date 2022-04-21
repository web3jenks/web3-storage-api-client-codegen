# Web3Storage::Web3StorageHTTPAPIApi

All URIs are relative to *https://api.web3.storage*

| Method | HTTP request | Description |
| ------ | ------------ | ----------- |
| [**delete_pins_requestid**](Web3StorageHTTPAPIApi.md#delete_pins_requestid) | **DELETE** /pins/{requestid} | Remove pin object |
| [**get_car_cid**](Web3StorageHTTPAPIApi.md#get_car_cid) | **GET** /car/{cid} | Retrieve a CAR |
| [**get_pins**](Web3StorageHTTPAPIApi.md#get_pins) | **GET** /pins | List pin objects |
| [**get_pins_requestid**](Web3StorageHTTPAPIApi.md#get_pins_requestid) | **GET** /pins/{requestid} | Get pin object |
| [**get_status_cid**](Web3StorageHTTPAPIApi.md#get_status_cid) | **GET** /status/{cid} | Retrieve information about an upload |
| [**get_user_uploads**](Web3StorageHTTPAPIApi.md#get_user_uploads) | **GET** /user/uploads | List previous uploads |
| [**head_car_cid**](Web3StorageHTTPAPIApi.md#head_car_cid) | **HEAD** /car/{cid} | Retrieve HTTP headers regarding a CAR |
| [**post_car**](Web3StorageHTTPAPIApi.md#post_car) | **POST** /car | Upload a CAR |
| [**post_pins**](Web3StorageHTTPAPIApi.md#post_pins) | **POST** /pins | Add pin object |
| [**post_pins_requestid**](Web3StorageHTTPAPIApi.md#post_pins_requestid) | **POST** /pins/{requestid} | Replace pin object |
| [**post_upload**](Web3StorageHTTPAPIApi.md#post_upload) | **POST** /upload | Upload and store one or more files |


## delete_pins_requestid

> delete_pins_requestid(requestid)

Remove pin object

Remove a pin object

### Examples

```ruby
require 'time'
require 'web3_storage'
# setup authorization
Web3Storage.configure do |config|
  # Configure Bearer authorization (JWT): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = Web3Storage::Web3StorageHTTPAPIApi.new
requestid = 'requestid_example' # String | 

begin
  # Remove pin object
  api_instance.delete_pins_requestid(requestid)
rescue Web3Storage::ApiError => e
  puts "Error when calling Web3StorageHTTPAPIApi->delete_pins_requestid: #{e}"
end
```

#### Using the delete_pins_requestid_with_http_info variant

This returns an Array which contains the response data (`nil` in this case), status code and headers.

> <Array(nil, Integer, Hash)> delete_pins_requestid_with_http_info(requestid)

```ruby
begin
  # Remove pin object
  data, status_code, headers = api_instance.delete_pins_requestid_with_http_info(requestid)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => nil
rescue Web3Storage::ApiError => e
  puts "Error when calling Web3StorageHTTPAPIApi->delete_pins_requestid_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **requestid** | **String** |  |  |

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## get_car_cid

> File get_car_cid(cid)

Retrieve a CAR

Retrieve an [IPFS DAG](https://docs.ipfs.io/concepts/merkle-dag/) (Directed Acyclic Graph) packaged in a CAR file by using `/car/{cid}`, supplying the CID of the data you are interested in.

### Examples

```ruby
require 'time'
require 'web3_storage'

api_instance = Web3Storage::Web3StorageHTTPAPIApi.new
cid = 'cid_example' # String | 

begin
  # Retrieve a CAR
  result = api_instance.get_car_cid(cid)
  p result
rescue Web3Storage::ApiError => e
  puts "Error when calling Web3StorageHTTPAPIApi->get_car_cid: #{e}"
end
```

#### Using the get_car_cid_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(File, Integer, Hash)> get_car_cid_with_http_info(cid)

```ruby
begin
  # Retrieve a CAR
  data, status_code, headers = api_instance.get_car_cid_with_http_info(cid)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => File
rescue Web3Storage::ApiError => e
  puts "Error when calling Web3StorageHTTPAPIApi->get_car_cid_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **cid** | **String** |  |  |

### Return type

**File**

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/car, application/json


## get_pins

> <PinResults> get_pins(opts)

List pin objects

List all the pin objects, matching optional filters; when no filter is provided, only successful pins are returned

### Examples

```ruby
require 'time'
require 'web3_storage'
# setup authorization
Web3Storage.configure do |config|
  # Configure Bearer authorization (JWT): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = Web3Storage::Web3StorageHTTPAPIApi.new
opts = {
  cid: ['inner_example'], # Array<String> | Return pin objects responsible for pinning the specified CID(s); be aware that using longer hash functions introduces further constraints on the number of CIDs that will fit under the limit of 2000 characters per URL  in browser contexts
  name: 'PreciousData.pdf', # String | Return pin objects with specified name (by default a case-sensitive, exact match)
  match: Web3Storage::TextMatchingStrategy::EXACT, # TextMatchingStrategy | Customize the text matching strategy applied when the name filter is present; exact (the default) is a case-sensitive exact match, partial matches anywhere in the name, iexact and ipartial are case-insensitive versions of the exact and partial strategies
  status: ['queued'], # Array<String> | Return pin objects for pins with the specified status
  before: Time.parse('2020-07-27T17:32:28Z'), # Time | Return results created (queued) before provided timestamp
  after: Time.parse('2020-07-27T17:32:28Z'), # Time | Return results created (queued) after provided timestamp
  limit: 56, # Integer | Max records to return
  meta: { key: 'inner_example'} # Hash<String, String> | Return pin objects that match specified metadata keys passed as a string representation of a JSON object; when implementing a client library, make sure the parameter is URL-encoded to ensure safe transport
}

begin
  # List pin objects
  result = api_instance.get_pins(opts)
  p result
rescue Web3Storage::ApiError => e
  puts "Error when calling Web3StorageHTTPAPIApi->get_pins: #{e}"
end
```

#### Using the get_pins_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<PinResults>, Integer, Hash)> get_pins_with_http_info(opts)

```ruby
begin
  # List pin objects
  data, status_code, headers = api_instance.get_pins_with_http_info(opts)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <PinResults>
rescue Web3Storage::ApiError => e
  puts "Error when calling Web3StorageHTTPAPIApi->get_pins_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **cid** | [**Array&lt;String&gt;**](String.md) | Return pin objects responsible for pinning the specified CID(s); be aware that using longer hash functions introduces further constraints on the number of CIDs that will fit under the limit of 2000 characters per URL  in browser contexts | [optional] |
| **name** | **String** | Return pin objects with specified name (by default a case-sensitive, exact match) | [optional] |
| **match** | [**TextMatchingStrategy**](.md) | Customize the text matching strategy applied when the name filter is present; exact (the default) is a case-sensitive exact match, partial matches anywhere in the name, iexact and ipartial are case-insensitive versions of the exact and partial strategies | [optional][default to &#39;exact&#39;] |
| **status** | [**Array&lt;String&gt;**](String.md) | Return pin objects for pins with the specified status | [optional] |
| **before** | **Time** | Return results created (queued) before provided timestamp | [optional] |
| **after** | **Time** | Return results created (queued) after provided timestamp | [optional] |
| **limit** | **Integer** | Max records to return | [optional][default to 10] |
| **meta** | [**Hash&lt;String, String&gt;**](String.md) | Return pin objects that match specified metadata keys passed as a string representation of a JSON object; when implementing a client library, make sure the parameter is URL-encoded to ensure safe transport | [optional] |

### Return type

[**PinResults**](PinResults.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## get_pins_requestid

> <PinStatus> get_pins_requestid(requestid)

Get pin object

Get a pin object and its status

### Examples

```ruby
require 'time'
require 'web3_storage'
# setup authorization
Web3Storage.configure do |config|
  # Configure Bearer authorization (JWT): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = Web3Storage::Web3StorageHTTPAPIApi.new
requestid = 'requestid_example' # String | 

begin
  # Get pin object
  result = api_instance.get_pins_requestid(requestid)
  p result
rescue Web3Storage::ApiError => e
  puts "Error when calling Web3StorageHTTPAPIApi->get_pins_requestid: #{e}"
end
```

#### Using the get_pins_requestid_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<PinStatus>, Integer, Hash)> get_pins_requestid_with_http_info(requestid)

```ruby
begin
  # Get pin object
  data, status_code, headers = api_instance.get_pins_requestid_with_http_info(requestid)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <PinStatus>
rescue Web3Storage::ApiError => e
  puts "Error when calling Web3StorageHTTPAPIApi->get_pins_requestid_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **requestid** | **String** |  |  |

### Return type

[**PinStatus**](PinStatus.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## get_status_cid

> <Status> get_status_cid(cid)

Retrieve information about an upload

Retrieve metadata about a specific file by using `/status/{cid}`, supplying the CID of the file you are interested in. This metadata includes the creation date and file size, as well as details about how the network is storing your data. Using this information, you can identify peers on the [IPFS (InterPlanetary File System)](https://ipfs.io) network that are pinning the data, and [Filecoin](https://filecoin.io) storage providers that have accepted deals to store the data.

### Examples

```ruby
require 'time'
require 'web3_storage'

api_instance = Web3Storage::Web3StorageHTTPAPIApi.new
cid = 'cid_example' # String | 

begin
  # Retrieve information about an upload
  result = api_instance.get_status_cid(cid)
  p result
rescue Web3Storage::ApiError => e
  puts "Error when calling Web3StorageHTTPAPIApi->get_status_cid: #{e}"
end
```

#### Using the get_status_cid_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<Status>, Integer, Hash)> get_status_cid_with_http_info(cid)

```ruby
begin
  # Retrieve information about an upload
  data, status_code, headers = api_instance.get_status_cid_with_http_info(cid)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <Status>
rescue Web3Storage::ApiError => e
  puts "Error when calling Web3StorageHTTPAPIApi->get_status_cid_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **cid** | **String** |  |  |

### Return type

[**Status**](Status.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## get_user_uploads

> <Array<Status>> get_user_uploads(opts)

List previous uploads

Lists all previous uploads for the account ordered by creation date, newest first. These results can be paginated by specifying `before` and `size` parameters in the query string, using the creation date associated with the oldest upload returned in each batch as the value of `before` in subsequent calls.  Note this endpoint returns all uploads for the account not just the API key in use.  The information returned includes the creation date and file size, as well as details about how the network is storing your data. Using this information, you can identify peers on the [IPFS (InterPlanetary File System)](https://ipfs.io) network that are pinning the data, and [Filecoin](https://filecoin.io) storage providers that have accepted deals to store the data. 

### Examples

```ruby
require 'time'
require 'web3_storage'
# setup authorization
Web3Storage.configure do |config|
  # Configure Bearer authorization (JWT): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = Web3Storage::Web3StorageHTTPAPIApi.new
opts = {
  before: Time.parse('2020-07-27T17:32:28Z'), # Time | Specifies a date, in ISO 8601 format. Ensures that the call to `/list` will not return any results newer than the given date.
  size: 56 # Integer | Specifies the maximum number of uploads to return.
}

begin
  # List previous uploads
  result = api_instance.get_user_uploads(opts)
  p result
rescue Web3Storage::ApiError => e
  puts "Error when calling Web3StorageHTTPAPIApi->get_user_uploads: #{e}"
end
```

#### Using the get_user_uploads_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<Array<Status>>, Integer, Hash)> get_user_uploads_with_http_info(opts)

```ruby
begin
  # List previous uploads
  data, status_code, headers = api_instance.get_user_uploads_with_http_info(opts)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <Array<Status>>
rescue Web3Storage::ApiError => e
  puts "Error when calling Web3StorageHTTPAPIApi->get_user_uploads_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **before** | **Time** | Specifies a date, in ISO 8601 format. Ensures that the call to &#x60;/list&#x60; will not return any results newer than the given date. | [optional] |
| **size** | **Integer** | Specifies the maximum number of uploads to return. | [optional][default to 25] |

### Return type

[**Array&lt;Status&gt;**](Status.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## head_car_cid

> head_car_cid(cid)

Retrieve HTTP headers regarding a CAR

This method is useful for doing a dry run of a call to `/car/{cid}`. Because it only returns HTTP header information, it is far more lightweight and can be used to get only the metadata about the given CAR file without retrieving a whole payload in the body of the HTTP response. 

### Examples

```ruby
require 'time'
require 'web3_storage'

api_instance = Web3Storage::Web3StorageHTTPAPIApi.new
cid = 'cid_example' # String | 

begin
  # Retrieve HTTP headers regarding a CAR
  api_instance.head_car_cid(cid)
rescue Web3Storage::ApiError => e
  puts "Error when calling Web3StorageHTTPAPIApi->head_car_cid: #{e}"
end
```

#### Using the head_car_cid_with_http_info variant

This returns an Array which contains the response data (`nil` in this case), status code and headers.

> <Array(nil, Integer, Hash)> head_car_cid_with_http_info(cid)

```ruby
begin
  # Retrieve HTTP headers regarding a CAR
  data, status_code, headers = api_instance.head_car_cid_with_http_info(cid)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => nil
rescue Web3Storage::ApiError => e
  puts "Error when calling Web3StorageHTTPAPIApi->head_car_cid_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **cid** | **String** |  |  |

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## post_car

> <UploadResponse> post_car(body)

Upload a CAR

Upload a [CAR](https://ipld.io/specs/transport/car/) (Content Addressable aRchive) file and store the [IPFS DAG](https://docs.ipfs.io/concepts/merkle-dag/) (Directed Acyclic Graph) it contains.  See the [Working with Content Archives guide](https://docs.web3.storage/how-tos/work-with-car-files) for details on creating CARs and splitting them into chunks for upload using the [carbites JavaScript API](https://github.com/nftstorage/carbites), [command line tool](https://github.com/nftstorage/carbites-cli/), or [Go library](https://github.com/alanshaw/go-carbites).  Requests to this endpoint have a maximum payload size of 100MB but partial DAGs are supported, so multiple CAR files with the same root but with different sub-trees can be sent. This enables uploading of files that are bigger than the maximum payload size.  Note that only one CAR can be uploaded at a time, and only CAR files are accepted. This is in contrast to [`/upload`](#operation/post-upload), which can upload multiple files at once and accepts both CAR files and files from the client.  You can also provide a name for the file using the header `X-NAME`, but be sure to encode the filename first. For example `LICENSE–MIT` should be sent as `LICENSE%E2%80%93MIT`. 

### Examples

```ruby
require 'time'
require 'web3_storage'
# setup authorization
Web3Storage.configure do |config|
  # Configure Bearer authorization (JWT): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = Web3Storage::Web3StorageHTTPAPIApi.new
body = File.new('/path/to/some/file') # File | 

begin
  # Upload a CAR
  result = api_instance.post_car(body)
  p result
rescue Web3Storage::ApiError => e
  puts "Error when calling Web3StorageHTTPAPIApi->post_car: #{e}"
end
```

#### Using the post_car_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<UploadResponse>, Integer, Hash)> post_car_with_http_info(body)

```ruby
begin
  # Upload a CAR
  data, status_code, headers = api_instance.post_car_with_http_info(body)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <UploadResponse>
rescue Web3Storage::ApiError => e
  puts "Error when calling Web3StorageHTTPAPIApi->post_car_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **body** | **File** |  |  |

### Return type

[**UploadResponse**](UploadResponse.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: application/car, application/octet-stream
- **Accept**: application/json


## post_pins

> <PinStatus> post_pins(psa_pin)

Add pin object

Add a new pin object for the current access token

### Examples

```ruby
require 'time'
require 'web3_storage'
# setup authorization
Web3Storage.configure do |config|
  # Configure Bearer authorization (JWT): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = Web3Storage::Web3StorageHTTPAPIApi.new
psa_pin = Web3Storage::PSAPin.new({cid: 'QmCIDToBePinned'}) # PSAPin | 

begin
  # Add pin object
  result = api_instance.post_pins(psa_pin)
  p result
rescue Web3Storage::ApiError => e
  puts "Error when calling Web3StorageHTTPAPIApi->post_pins: #{e}"
end
```

#### Using the post_pins_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<PinStatus>, Integer, Hash)> post_pins_with_http_info(psa_pin)

```ruby
begin
  # Add pin object
  data, status_code, headers = api_instance.post_pins_with_http_info(psa_pin)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <PinStatus>
rescue Web3Storage::ApiError => e
  puts "Error when calling Web3StorageHTTPAPIApi->post_pins_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **psa_pin** | [**PSAPin**](PSAPin.md) |  |  |

### Return type

[**PinStatus**](PinStatus.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


## post_pins_requestid

> <PinStatus> post_pins_requestid(requestid, psa_pin)

Replace pin object

Replace an existing pin object (shortcut for executing remove and add operations in one step to avoid unnecessary garbage collection of blocks present in both recursive pins)

### Examples

```ruby
require 'time'
require 'web3_storage'
# setup authorization
Web3Storage.configure do |config|
  # Configure Bearer authorization (JWT): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = Web3Storage::Web3StorageHTTPAPIApi.new
requestid = 'requestid_example' # String | 
psa_pin = Web3Storage::PSAPin.new({cid: 'QmCIDToBePinned'}) # PSAPin | 

begin
  # Replace pin object
  result = api_instance.post_pins_requestid(requestid, psa_pin)
  p result
rescue Web3Storage::ApiError => e
  puts "Error when calling Web3StorageHTTPAPIApi->post_pins_requestid: #{e}"
end
```

#### Using the post_pins_requestid_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<PinStatus>, Integer, Hash)> post_pins_requestid_with_http_info(requestid, psa_pin)

```ruby
begin
  # Replace pin object
  data, status_code, headers = api_instance.post_pins_requestid_with_http_info(requestid, psa_pin)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <PinStatus>
rescue Web3Storage::ApiError => e
  puts "Error when calling Web3StorageHTTPAPIApi->post_pins_requestid_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **requestid** | **String** |  |  |
| **psa_pin** | [**PSAPin**](PSAPin.md) |  |  |

### Return type

[**PinStatus**](PinStatus.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


## post_upload

> <UploadResponse> post_upload(opts)

Upload and store one or more files

Store files using Web3.Storage. You can upload either a single file or multiple files.  Send the POST request with one of the following: - a single file, with a single blob/file object as the body - multiple files, as `FormData` with `Content-Disposition` headers for each part to specify filenames and the request header `Content-Type: multipart/form-data`  Requests to this endpoint have a maximum payload size of 100MB. To upload larger files, see the documentation for the `/car` endpoint.  You can also provide a name for the file using the header `X-NAME`, but be sure to encode the filename first. For example `LICENSE–MIT` should be sent as `LICENSE%E2%80%93MIT`. 

### Examples

```ruby
require 'time'
require 'web3_storage'
# setup authorization
Web3Storage.configure do |config|
  # Configure Bearer authorization (JWT): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = Web3Storage::Web3StorageHTTPAPIApi.new
opts = {
  file: [File.new('/path/to/some/file')] # Array<File> | 
}

begin
  # Upload and store one or more files
  result = api_instance.post_upload(opts)
  p result
rescue Web3Storage::ApiError => e
  puts "Error when calling Web3StorageHTTPAPIApi->post_upload: #{e}"
end
```

#### Using the post_upload_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<UploadResponse>, Integer, Hash)> post_upload_with_http_info(opts)

```ruby
begin
  # Upload and store one or more files
  data, status_code, headers = api_instance.post_upload_with_http_info(opts)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <UploadResponse>
rescue Web3Storage::ApiError => e
  puts "Error when calling Web3StorageHTTPAPIApi->post_upload_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **file** | **Array&lt;File&gt;** |  | [optional] |

### Return type

[**UploadResponse**](UploadResponse.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: multipart/form-data
- **Accept**: application/json

