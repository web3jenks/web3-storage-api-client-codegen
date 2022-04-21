# Web3Stroage

This documentation describes the HTTP API for [**Web3.Storage**](https://web3.storage), which allows you to quickly and easily build applications using decentralized data storage persisted by [Filecoin](https://filecoin.io) and available over [IPFS](https://ipfs.io).

You can also interact with this API using client libraries. See [**docs.web3.storage**](https://docs.web3.storage) for more information on using a client library, as well as a variety of other guides and how-tos for Web3.Storage as a whole.

## API endpoint URL

The main public API endpoint URL for Web3.Storage is `https://api.web3.storage`. All endpoints described in this document should be made relative to this root URL. For example, to post to the `/car` endpoint, send your request to `https://api.web3.storage/car`.

### Rate limits

This API imposes rate limits to ensure quality of service. You may receive a 429 \"Too many requests\" error if you make more than 30 requests with the same API token within a ten second window. Upon receiving a response with a 429 status, clients should retry the failed request after a small delay. To avoid 429 responses, you may wish to implement client-side request throttling to stay within the limits.



## Installation & Usage

### Requirements

PHP 7.3 and later.
Should also work with PHP 8.0 but has not been tested.

### Composer

To install the bindings via [Composer](https://getcomposer.org/), add the following to `composer.json`:

```json
{
  "repositories": [
    {
      "type": "vcs",
      "url": "https://github.com/GIT_USER_ID/GIT_REPO_ID.git"
    }
  ],
  "require": {
    "GIT_USER_ID/GIT_REPO_ID": "*@dev"
  }
}
```

Then run `composer install`

### Manual Installation

Download the files and include `autoload.php`:

```php
<?php
require_once('/path/to/Web3Stroage/vendor/autoload.php');
```

## Getting Started

Please follow the [installation procedure](#installation--usage) and then run the following:

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

## API Endpoints

All URIs are relative to *https://api.web3.storage*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*Web3StorageHTTPAPIApi* | [**deletePinsRequestid**](docs/Api/Web3StorageHTTPAPIApi.md#deletepinsrequestid) | **DELETE** /pins/{requestid} | Remove pin object
*Web3StorageHTTPAPIApi* | [**getCarCid**](docs/Api/Web3StorageHTTPAPIApi.md#getcarcid) | **GET** /car/{cid} | Retrieve a CAR
*Web3StorageHTTPAPIApi* | [**getPins**](docs/Api/Web3StorageHTTPAPIApi.md#getpins) | **GET** /pins | List pin objects
*Web3StorageHTTPAPIApi* | [**getPinsRequestid**](docs/Api/Web3StorageHTTPAPIApi.md#getpinsrequestid) | **GET** /pins/{requestid} | Get pin object
*Web3StorageHTTPAPIApi* | [**getStatusCid**](docs/Api/Web3StorageHTTPAPIApi.md#getstatuscid) | **GET** /status/{cid} | Retrieve information about an upload
*Web3StorageHTTPAPIApi* | [**getUserUploads**](docs/Api/Web3StorageHTTPAPIApi.md#getuseruploads) | **GET** /user/uploads | List previous uploads
*Web3StorageHTTPAPIApi* | [**headCarCid**](docs/Api/Web3StorageHTTPAPIApi.md#headcarcid) | **HEAD** /car/{cid} | Retrieve HTTP headers regarding a CAR
*Web3StorageHTTPAPIApi* | [**postCar**](docs/Api/Web3StorageHTTPAPIApi.md#postcar) | **POST** /car | Upload a CAR
*Web3StorageHTTPAPIApi* | [**postPins**](docs/Api/Web3StorageHTTPAPIApi.md#postpins) | **POST** /pins | Add pin object
*Web3StorageHTTPAPIApi* | [**postPinsRequestid**](docs/Api/Web3StorageHTTPAPIApi.md#postpinsrequestid) | **POST** /pins/{requestid} | Replace pin object
*Web3StorageHTTPAPIApi* | [**postUpload**](docs/Api/Web3StorageHTTPAPIApi.md#postupload) | **POST** /upload | Upload and store one or more files

## Models

- [Deal](docs/Model/Deal.md)
- [ErrorResponse](docs/Model/ErrorResponse.md)
- [Failure](docs/Model/Failure.md)
- [FailureError](docs/Model/FailureError.md)
- [ForbiddenErrorResponse](docs/Model/ForbiddenErrorResponse.md)
- [PSAPin](docs/Model/PSAPin.md)
- [Pin](docs/Model/Pin.md)
- [PinResults](docs/Model/PinResults.md)
- [PinStatus](docs/Model/PinStatus.md)
- [PinStatusPin](docs/Model/PinStatusPin.md)
- [Status](docs/Model/Status.md)
- [TextMatchingStrategy](docs/Model/TextMatchingStrategy.md)
- [UnauthorizedErrorResponse](docs/Model/UnauthorizedErrorResponse.md)
- [UploadResponse](docs/Model/UploadResponse.md)

## Authorization

### bearerAuth

- **Type**: Bearer authentication (JWT)

## Tests

To run the tests, use:

```bash
composer install
vendor/bin/phpunit
```

## Author



## About this package

This PHP package is automatically generated by the [OpenAPI Generator](https://openapi-generator.tech) project:

- API version: `1.0`
- Build package: `org.openapitools.codegen.languages.PhpClientCodegen`
