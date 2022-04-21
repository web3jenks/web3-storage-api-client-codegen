# Web3.Storage.Model.Deal

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DealId** | **decimal** | On-chain ID of the deal. | [optional] 
**StorageProvider** | **string** | Address of the provider storing this data. | [optional] 
**Status** | **string** | Current deal status. | 
**PieceCid** | **string** | Filecoin [Piece CID](https://spec.filecoin.io/systems/filecoin_files/piece/) of the data in the deal. | [optional] 
**DataCid** | **string** | CID of the data aggregated in this deal. | [optional] 
**DataModelSelector** | **string** | Selector for extracting stored data from the aggregated data root. | [optional] 
**Activation** | **string** | Date when the deal will become active in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format. | [optional] 
**Created** | **string** | Creation date in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format. | 
**Updated** | **string** | Updated date in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

