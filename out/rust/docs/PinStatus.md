# PinStatus

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**requestid** | **String** | Globally unique identifier of the pin request; can be used to check the status of ongoing pinning, or pin removal | 
**status** | **String** | Status a pin object can have at a pinning service | 
**created** | **String** | Immutable timestamp indicating when a pin request entered a pinning service; can be used for filtering results and pagination | 
**pin** | [**crate::models::PinStatusPin**](PinStatus_pin.md) |  | 
**delegates** | **Vec<String>** | List of multiaddrs designated by pinning service for transferring any new data from external peers | 
**info** | Option<**::std::collections::HashMap<String, String>**> | Optional info for PinStatus response | [optional]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


