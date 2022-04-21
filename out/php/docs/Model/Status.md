# # Status

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**cid** | **string** | Self-describing content-addressed identifiers for distributed systems. Check the [CID (Content IDentifier) Specification](https://github.com/multiformats/cid) for more info. | [optional]
**dag_size** | **float** | Total size of the DAG in bytes. | [optional] [default to 132614]
**created** | [**\DateTime**](\DateTime.md) | This is a timestamp in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format: YYYY-MM-DDTHH:MM:SSZ. | [optional]
**pins** | [**\OpenAPI\Client\Model\Pin[]**](Pin.md) |  | [optional]
**deals** | [**\OpenAPI\Client\Model\Deal[]**](Deal.md) |  | [optional]

[[Back to Model list]](../../README.md#models) [[Back to API list]](../../README.md#endpoints) [[Back to README]](../../README.md)
