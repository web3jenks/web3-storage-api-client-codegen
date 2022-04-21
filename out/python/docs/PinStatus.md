# PinStatus

Pin object with status

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**requestid** | **str** | Globally unique identifier of the pin request; can be used to check the status of ongoing pinning, or pin removal | 
**status** | **str** | Status a pin object can have at a pinning service | 
**created** | **datetime** | Immutable timestamp indicating when a pin request entered a pinning service; can be used for filtering results and pagination | 
**pin** | [**PinStatusPin**](PinStatusPin.md) |  | 
**delegates** | [**Delegates**](Delegates.md) |  | 
**info** | [**StatusInfo**](StatusInfo.md) |  | [optional] 
**any string name** | **bool, date, datetime, dict, float, int, list, str, none_type** | any string name can be used but the value must be the correct type | [optional]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


