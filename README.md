# azure-sdk-template

Tempates of dotnet commandline to quickly onboard Azure SDK.

## Supported templates

- Azure .NET(C#) SDK (management plane, track 1)

## Usage

1. Download the nupkg from the [releases page](https://github.com/isra-fel/azure-sdk-template/releases)
1. Install (or update) the template `dotnet new -i .\AzureSDK.Templates.x.y.z.nupkg`
1. Create your project
    ```cmd
    cd azure-sdk-for-net\sdk
    mkdir appconfiguration
    cd appconfiguration
    dotnet new azurecsmgmtsdk -R AppConfiguration -r appconfiguration
    ```
    `-R` will be used in your project name. It should be in PascalCase; `-r` will be used to retrieve swagger. It should be in lowercase.

## Help

```cmd
dotnet new azurecsmgmtsdk -h
```

## Build & Debug

```cmd
dotnet pack
dotnet i .\bin\Debug\AzureSDK.Templates.0.1.0.nupkg
```

## Reference

- [How to create your own templates for dotnet new](https://devblogs.microsoft.com/dotnet/how-to-create-your-own-templates-for-dotnet-new/)
- [Available Parameter Generators](https://docs.microsoft.com/en-us/dotnet/core/tools/custom-templates)
- https://github.com/dotnet/templating/issues/1238
- [template json schema](http://json.schemastore.org/template)
