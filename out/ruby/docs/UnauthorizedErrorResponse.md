# Web3Storage::UnauthorizedErrorResponse

## Properties

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **name** | **String** |  | [optional][default to &#39;HTTP Error&#39;] |
| **message** | **String** |  | [optional][default to &#39;Unauthorized&#39;] |

## Example

```ruby
require 'web3_storage'

instance = Web3Storage::UnauthorizedErrorResponse.new(
  name: null,
  message: null
)
```

