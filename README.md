# openwealth-openapi

## Code creation

Creation of aspnetcore project

```console
openapi-generator-cli generate -i API.yaml -g aspnetcore -o OpenWealth --package-name OpenWealth --output netcore --additional-properties=useNewtonsoft=false,useSeparateModelProject=true,aspnetCoreVersion=6.0,nullableReferenceTypes=true,useSwashbuckle=false,enumValueSuffix=EnumValueSuffix 
```
