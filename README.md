# azure-sdk-template

## Supported templates

- Azure .NET(C#) SDK (management plane, track 1 only)

## Usage:

```
dotnet pack
dotnet new -i .\bin\Debug\AzureSDK.Templates.0.1.0.nupkg
# cd to azure-sdk-for-net/sdk
# mkdir moonbucks
# cd moonbucks
dotnet new azurecsmgmtsdk -R Moonbucks -r moonbucks
```

## Help

```
dotnet new azurecsmgmtsdk -h
```

## Reference

- [How to create your own templates for dotnet new](https://devblogs.microsoft.com/dotnet/how-to-create-your-own-templates-for-dotnet-new/)
- [Available Parameter Generators](https://docs.microsoft.com/en-us/dotnet/core/tools/custom-templates)
- https://github.com/dotnet/templating/issues/1238
- [template json schema](http://json.schemastore.org/template)
