
# Web3.storage polyglot SDK codegen project

## Background
Web3.Storage is a popular free tool for dapp developers to upload and manage files on IPFS & Filecoin. Web3.Storage currently supports a javascript client and a go client. Web3.Storage's openapi specification provided a way for developers to generate their own client in any languages however such a generation could take some effort.

## Projec goals

This project aims to create more languages for Web3.Storage SDKS to encourage the usage of the tool in developer communities otherthan JS & Go. The project uses the power of [OpenAPI Generator](https://openapi-generator.tech) and it's commuinity templates to generate SDK clients in [manage languages](https://openapi-generator.tech/docs/generators) with `openapi-generator-cli` tools.

Developers are encouraged to fork this repositiory and generate languages that is currently missing for Web3.Storage.

## Quick links

- [Adding new languages](#adding-new-languages)
- [Adding custom templates](#adding-custom-templates)
- [Generate code locally](#generate-code-locally)
- [Generate via Github Action](generate-via-github-action)

## Latest generated SDKs

- [Java]()
- [PHP]()
- [Python]()
- [Ruby]()
- [C#]() <= work in progress

## Adding new languages

We can add support for new language SDKs by following these steps:
- Find the generator name for the language [here](https://openapi-generator.tech/docs/generators)
- Add a configuration file under `config/{generatorName}.yml` (most or all generators require at least `packageName`)
- Find available configuration options by viewing the page for the generator [here](https://openapi-generator.tech/docs/generators)
- Add the desired configuration values
- Create a separate git repository for the new SDK
- Add a new entry to the matrix in `.github/workflows/generate.yml`: `{ repo: "{repoName}", openapi_generator: "{generatorName}" }`. The next time the workflow is ran a PR will be created in the new repo with the generated SDK
- Optionally add language templates by creating a directory `templates/{generatorName}` and placing the `.moustache` files in here (see [Adding custom templates](#adding-custom-templates))
- Optionally add a new npm command to `package.json` (see existing scripts) for generation and update the `gen:all` npm script

## Adding custom templates

OpenApi geneartor uses [`mustache`](https://mustache.github.io/) as its templating engine.

As an example lets use a custom `python` template:

- Create a directory with the name of the generator under the `templates` directory (i.e `./templates/python`)
- Find the default template that we are updating in the [`openapi-generator` codebase](https://github.com/OpenAPITools/openapi-generator/tree/master/modules/openapi-generator/src/main/resources/python), lets use `README.mustache` for our example
- Create `./templates/python/README.mustache`
- Copy+paste the default template from the `openapi-generator` codebase in the `./templates/python/README.mustache` file
- Make any changes to our custom template, we can add new configuration values using `{{configValue}}` and then setting the value in the language configuration file `./config/python.yml` like so `configValue: Hello`
- Run generation `npm run gen:py`, our template changes will be observable in the produced file: `out/python/README.md`

## Generate code locally

Before you start, install dependencies:
- `docker`, make sure your docker daemon is running before generating
- `nodejs` & `npm`

Now perform the following:
- the location of the openapi spec is locked web3.storage documenation repo at https://raw.githubusercontent.com/web3-storage/docs/95e09d5097f17b9612dd38369e1f36114f353150/static/schema.yml (so it will always pull the latest version and generate the latest SDKs when you run)
- `npm run build`
- `npm run gen:all` to generate all language SDKs OR
- `npm run gen:py` to generate the python SDK for example

## Generate via github action

[automiation via Github Action (using release tagging) coming soon, including publishing to package centers]

## Generated SDKs & Documentation
All generated SDKs can be viewed and tested in `/out` folder under their respective languages. Test files templates are generated so are the documentation of the SDK methods along with demo code snippets. 