# \Web3StorageHTTPAPIApi

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



## delete_pins_requestid

> delete_pins_requestid(requestid)
Remove pin object

Remove a pin object

### Parameters


Name | Type | Description  | Required | Notes
------------- | ------------- | ------------- | ------------- | -------------
**requestid** | **String** |  | [required] |

### Return type

 (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


## get_car_cid

> std::path::PathBuf get_car_cid(cid)
Retrieve a CAR

Retrieve an [IPFS DAG](https://docs.ipfs.io/concepts/merkle-dag/) (Directed Acyclic Graph) packaged in a CAR file by using `/car/{cid}`, supplying the CID of the data you are interested in.

### Parameters


Name | Type | Description  | Required | Notes
------------- | ------------- | ------------- | ------------- | -------------
**cid** | **String** |  | [required] |

### Return type

[**std::path::PathBuf**](std::path::PathBuf.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/car, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


## get_pins

> crate::models::PinResults get_pins(cid, name, _match, status, before, after, limit, meta)
List pin objects

List all the pin objects, matching optional filters; when no filter is provided, only successful pins are returned

### Parameters


Name | Type | Description  | Required | Notes
------------- | ------------- | ------------- | ------------- | -------------
**cid** | Option<[**Vec<String>**](String.md)> | Return pin objects responsible for pinning the specified CID(s); be aware that using longer hash functions introduces further constraints on the number of CIDs that will fit under the limit of 2000 characters per URL  in browser contexts |  |
**name** | Option<**String**> | Return pin objects with specified name (by default a case-sensitive, exact match) |  |
**_match** | Option<[**crate::models::TextMatchingStrategy**](.md)> | Customize the text matching strategy applied when the name filter is present; exact (the default) is a case-sensitive exact match, partial matches anywhere in the name, iexact and ipartial are case-insensitive versions of the exact and partial strategies |  |
**status** | Option<[**Vec<String>**](String.md)> | Return pin objects for pins with the specified status |  |
**before** | Option<**String**> | Return results created (queued) before provided timestamp |  |
**after** | Option<**String**> | Return results created (queued) after provided timestamp |  |
**limit** | Option<**i32**> | Max records to return |  |[default to 10]
**meta** | Option<[**::std::collections::HashMap<String, String>**](String.md)> | Return pin objects that match specified metadata keys passed as a string representation of a JSON object; when implementing a client library, make sure the parameter is URL-encoded to ensure safe transport |  |

### Return type

[**crate::models::PinResults**](PinResults.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


## get_pins_requestid

> crate::models::PinStatus get_pins_requestid(requestid)
Get pin object

Get a pin object and its status

### Parameters


Name | Type | Description  | Required | Notes
------------- | ------------- | ------------- | ------------- | -------------
**requestid** | **String** |  | [required] |

### Return type

[**crate::models::PinStatus**](PinStatus.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


## get_status_cid

> crate::models::Status get_status_cid(cid)
Retrieve information about an upload

Retrieve metadata about a specific file by using `/status/{cid}`, supplying the CID of the file you are interested in. This metadata includes the creation date and file size, as well as details about how the network is storing your data. Using this information, you can identify peers on the [IPFS (InterPlanetary File System)](https://ipfs.io) network that are pinning the data, and [Filecoin](https://filecoin.io) storage providers that have accepted deals to store the data.

### Parameters


Name | Type | Description  | Required | Notes
------------- | ------------- | ------------- | ------------- | -------------
**cid** | **String** |  | [required] |

### Return type

[**crate::models::Status**](Status.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


## get_user_uploads

> Vec<crate::models::Status> get_user_uploads(before, size)
List previous uploads

Lists all previous uploads for the account ordered by creation date, newest first. These results can be paginated by specifying `before` and `size` parameters in the query string, using the creation date associated with the oldest upload returned in each batch as the value of `before` in subsequent calls.  Note this endpoint returns all uploads for the account not just the API key in use.  The information returned includes the creation date and file size, as well as details about how the network is storing your data. Using this information, you can identify peers on the [IPFS (InterPlanetary File System)](https://ipfs.io) network that are pinning the data, and [Filecoin](https://filecoin.io) storage providers that have accepted deals to store the data. 

### Parameters


Name | Type | Description  | Required | Notes
------------- | ------------- | ------------- | ------------- | -------------
**before** | Option<**String**> | Specifies a date, in ISO 8601 format. Ensures that the call to `/list` will not return any results newer than the given date. |  |
**size** | Option<**i32**> | Specifies the maximum number of uploads to return. |  |[default to 25]

### Return type

[**Vec<crate::models::Status>**](Status.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


## head_car_cid

> head_car_cid(cid)
Retrieve HTTP headers regarding a CAR

This method is useful for doing a dry run of a call to `/car/{cid}`. Because it only returns HTTP header information, it is far more lightweight and can be used to get only the metadata about the given CAR file without retrieving a whole payload in the body of the HTTP response. 

### Parameters


Name | Type | Description  | Required | Notes
------------- | ------------- | ------------- | ------------- | -------------
**cid** | **String** |  | [required] |

### Return type

 (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


## post_car

> crate::models::UploadResponse post_car(body)
Upload a CAR

Upload a [CAR](https://ipld.io/specs/transport/car/) (Content Addressable aRchive) file and store the [IPFS DAG](https://docs.ipfs.io/concepts/merkle-dag/) (Directed Acyclic Graph) it contains.  See the [Working with Content Archives guide](https://docs.web3.storage/how-tos/work-with-car-files) for details on creating CARs and splitting them into chunks for upload using the [carbites JavaScript API](https://github.com/nftstorage/carbites), [command line tool](https://github.com/nftstorage/carbites-cli/), or [Go library](https://github.com/alanshaw/go-carbites).  Requests to this endpoint have a maximum payload size of 100MB but partial DAGs are supported, so multiple CAR files with the same root but with different sub-trees can be sent. This enables uploading of files that are bigger than the maximum payload size.  Note that only one CAR can be uploaded at a time, and only CAR files are accepted. This is in contrast to [`/upload`](#operation/post-upload), which can upload multiple files at once and accepts both CAR files and files from the client.  You can also provide a name for the file using the header `X-NAME`, but be sure to encode the filename first. For example `LICENSE–MIT` should be sent as `LICENSE%E2%80%93MIT`. 

### Parameters


Name | Type | Description  | Required | Notes
------------- | ------------- | ------------- | ------------- | -------------
**body** | **std::path::PathBuf** |  | [required] |

### Return type

[**crate::models::UploadResponse**](UploadResponse.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: application/car, application/octet-stream
- **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


## post_pins

> crate::models::PinStatus post_pins(psa_pin)
Add pin object

Add a new pin object for the current access token

### Parameters


Name | Type | Description  | Required | Notes
------------- | ------------- | ------------- | ------------- | -------------
**psa_pin** | [**PsaPin**](PsaPin.md) |  | [required] |

### Return type

[**crate::models::PinStatus**](PinStatus.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


## post_pins_requestid

> crate::models::PinStatus post_pins_requestid(requestid, psa_pin)
Replace pin object

Replace an existing pin object (shortcut for executing remove and add operations in one step to avoid unnecessary garbage collection of blocks present in both recursive pins)

### Parameters


Name | Type | Description  | Required | Notes
------------- | ------------- | ------------- | ------------- | -------------
**requestid** | **String** |  | [required] |
**psa_pin** | [**PsaPin**](PsaPin.md) |  | [required] |

### Return type

[**crate::models::PinStatus**](PinStatus.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


## post_upload

> crate::models::UploadResponse post_upload(file)
Upload and store one or more files

Store files using Web3.Storage. You can upload either a single file or multiple files.  Send the POST request with one of the following: - a single file, with a single blob/file object as the body - multiple files, as `FormData` with `Content-Disposition` headers for each part to specify filenames and the request header `Content-Type: multipart/form-data`  Requests to this endpoint have a maximum payload size of 100MB. To upload larger files, see the documentation for the `/car` endpoint.  You can also provide a name for the file using the header `X-NAME`, but be sure to encode the filename first. For example `LICENSE–MIT` should be sent as `LICENSE%E2%80%93MIT`. 

### Parameters


Name | Type | Description  | Required | Notes
------------- | ------------- | ------------- | ------------- | -------------
**file** | Option<[**Vec<std::path::PathBuf>**](std::path::PathBuf.md)> |  |  |

### Return type

[**crate::models::UploadResponse**](UploadResponse.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: multipart/form-data
- **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

