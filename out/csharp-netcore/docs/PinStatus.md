# Web3.Storage.Model.PinStatus
Pin object with status

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Requestid** | **string** | Globally unique identifier of the pin request; can be used to check the status of ongoing pinning, or pin removal | 
**Status** | **string** | Status a pin object can have at a pinning service | 
**Created** | **DateTime** | Immutable timestamp indicating when a pin request entered a pinning service; can be used for filtering results and pagination | 
**Pin** | [**PinStatusPin**](PinStatusPin.md) |  | 
**Delegates** | **List&lt;string&gt;** | List of multiaddrs designated by pinning service for transferring any new data from external peers | 
**Info** | **Dictionary&lt;string, string&gt;** | Optional info for PinStatus response | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

