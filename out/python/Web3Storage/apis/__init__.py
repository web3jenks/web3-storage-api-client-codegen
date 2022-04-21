
# flake8: noqa

# Import all APIs into this package.
# If you have many APIs here with many many models used in each API this may
# raise a `RecursionError`.
# In order to avoid this, import only the API that you directly need like:
#
#   from .api.web3_storage_http_api_api import Web3StorageHTTPAPIApi
#
# or import this package, but before doing it, use:
#
#   import sys
#   sys.setrecursionlimit(n)

# Import APIs into API package:
from Web3Storage.api.web3_storage_http_api_api import Web3StorageHTTPAPIApi
