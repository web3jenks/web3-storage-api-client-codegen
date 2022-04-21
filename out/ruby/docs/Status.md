# Web3Storage::Status

## Properties

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **cid** | **String** | Self-describing content-addressed identifiers for distributed systems. Check the [CID (Content IDentifier) Specification](https://github.com/multiformats/cid) for more info. | [optional] |
| **dag_size** | **Float** | Total size of the DAG in bytes. | [optional][default to 132614] |
| **created** | **Time** | This is a timestamp in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format: YYYY-MM-DDTHH:MM:SSZ. | [optional] |
| **pins** | [**Array&lt;Pin&gt;**](Pin.md) |  | [optional] |
| **deals** | [**Array&lt;Deal&gt;**](Deal.md) |  | [optional] |

## Example

```ruby
require 'web3_storage'

instance = Web3Storage::Status.new(
  cid: bafkreidivzimqfqtoqxkrpge6bjyhlvxqs3rhe73owtmdulaxr5do5in7u,
  dag_size: null,
  created: 2021-03-12T17:03:07.787Z,
  pins: null,
  deals: null
)
```

