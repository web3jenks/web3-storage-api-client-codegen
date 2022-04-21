# # Deal

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**deal_id** | **float** | On-chain ID of the deal. | [optional]
**storage_provider** | **string** | Address of the provider storing this data. | [optional]
**status** | **string** | Current deal status. |
**piece_cid** | **string** | Filecoin [Piece CID](https://spec.filecoin.io/systems/filecoin_files/piece/) of the data in the deal. | [optional]
**data_cid** | **string** | CID of the data aggregated in this deal. | [optional]
**data_model_selector** | **string** | Selector for extracting stored data from the aggregated data root. | [optional]
**activation** | **string** | Date when the deal will become active in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format. | [optional]
**created** | **string** | Creation date in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format. |
**updated** | **string** | Updated date in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format. |

[[Back to Model list]](../../README.md#models) [[Back to API list]](../../README.md#endpoints) [[Back to README]](../../README.md)
