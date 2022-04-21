# Deal


## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**status** | **str** | Current deal status. | 
**created** | **str** | Creation date in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format. | 
**updated** | **str** | Updated date in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format. | 
**deal_id** | **float** | On-chain ID of the deal. | [optional] 
**storage_provider** | **str** | Address of the provider storing this data. | [optional] 
**piece_cid** | **str** | Filecoin [Piece CID](https://spec.filecoin.io/systems/filecoin_files/piece/) of the data in the deal. | [optional] 
**data_cid** | **str** | CID of the data aggregated in this deal. | [optional] 
**data_model_selector** | **str** | Selector for extracting stored data from the aggregated data root. | [optional] 
**activation** | **str** | Date when the deal will become active in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format. | [optional] 
**any string name** | **bool, date, datetime, dict, float, int, list, str, none_type** | any string name can be used but the value must be the correct type | [optional]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


