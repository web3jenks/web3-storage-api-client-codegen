# Status


## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**cid** | **str** | Self-describing content-addressed identifiers for distributed systems. Check the [CID (Content IDentifier) Specification](https://github.com/multiformats/cid) for more info. | [optional] 
**dag_size** | **float** | Total size of the DAG in bytes. | [optional]  if omitted the server will use the default value of 132614
**created** | **datetime** | This is a timestamp in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format: YYYY-MM-DDTHH:MM:SSZ. | [optional] 
**pins** | [**[Pin]**](Pin.md) |  | [optional] 
**deals** | [**[Deal]**](Deal.md) |  | [optional] 
**any string name** | **bool, date, datetime, dict, float, int, list, str, none_type** | any string name can be used but the value must be the correct type | [optional]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


