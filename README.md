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
