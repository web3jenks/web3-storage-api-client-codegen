# Web3Storage::Pin

## Properties

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **peer_id** | **String** | Libp2p peer ID of the node pinning the data. | [optional] |
| **peer_name** | **String** | Human readable name for the peer pinning the data. | [optional] |
| **region** | **String** | Approximate geographical region of the node pinning the data. | [optional] |
| **status** | **String** |  | [optional] |
| **updated** | **Time** | This is a timestamp in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format: YYYY-MM-DDTHH:MM:SSZ. | [optional] |

## Example

```ruby
require 'web3_storage'

instance = Web3Storage::Pin.new(
  peer_id: 12D3KooWMbibcXHwkSjgV7VZ8TMfDKi6pZvmi97P83ZwHm9LEsvV,
  peer_name: web3-storage-dc13,
  region: US-DC,
  status: null,
  updated: 2021-03-12T17:03:07.787Z
)
```

