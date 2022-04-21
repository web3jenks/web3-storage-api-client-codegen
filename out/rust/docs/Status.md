# Status

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**cid** | Option<**String**> | Self-describing content-addressed identifiers for distributed systems. Check the [CID (Content IDentifier) Specification](https://github.com/multiformats/cid) for more info. | [optional]
**dag_size** | Option<**f32**> | Total size of the DAG in bytes. | [optional][default to 132614]
**created** | Option<**String**> | This is a timestamp in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format: YYYY-MM-DDTHH:MM:SSZ. | [optional]
**pins** | Option<[**Vec<crate::models::Pin>**](Pin.md)> |  | [optional]
**deals** | Option<[**Vec<crate::models::Deal>**](Deal.md)> |  | [optional]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


