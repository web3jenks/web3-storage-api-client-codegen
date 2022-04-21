# # PinStatus

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**requestid** | **string** | Globally unique identifier of the pin request; can be used to check the status of ongoing pinning, or pin removal |
**status** | **string** | Status a pin object can have at a pinning service |
**created** | [**\DateTime**](\DateTime.md) | Immutable timestamp indicating when a pin request entered a pinning service; can be used for filtering results and pagination |
**pin** | [**\OpenAPI\Client\Model\PinStatusPin**](PinStatusPin.md) |  |
**delegates** | **string[]** | List of multiaddrs designated by pinning service for transferring any new data from external peers |
**info** | **array<string,string>** | Optional info for PinStatus response | [optional]

[[Back to Model list]](../../README.md#models) [[Back to API list]](../../README.md#endpoints) [[Back to README]](../../README.md)
