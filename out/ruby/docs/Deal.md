# Web3Storage::Deal

## Properties

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **deal_id** | **Float** | On-chain ID of the deal. | [optional] |
| **storage_provider** | **String** | Address of the provider storing this data. | [optional] |
| **status** | **String** | Current deal status. |  |
| **piece_cid** | **String** | Filecoin [Piece CID](https://spec.filecoin.io/systems/filecoin_files/piece/) of the data in the deal. | [optional] |
| **data_cid** | **String** | CID of the data aggregated in this deal. | [optional] |
| **data_model_selector** | **String** | Selector for extracting stored data from the aggregated data root. | [optional] |
| **activation** | **String** | Date when the deal will become active in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format. | [optional] |
| **created** | **String** | Creation date in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format. |  |
| **updated** | **String** | Updated date in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format. |  |

## Example

```ruby
require 'web3_storage'

instance = Web3Storage::Deal.new(
  deal_id: 138,
  storage_provider: f05678,
  status: null,
  piece_cid: bafkreidivzimqfqtoqxkrpge6bjyhlvxqs3rhe73owtmdulaxr5do5in7u,
  data_cid: bafkreidivzimqfqtoqxkrpge6bjyhlvxqs3rhe73owtmdulaxr5do5in7u,
  data_model_selector: Links/100/Hash/Links/0/Hash/Links/0/Hash,
  activation: 2021-03-18T11:46:50.000Z,
  created: 2021-03-18T11:46:50.000Z,
  updated: 2021-03-18T11:46:50.000Z
)
```

