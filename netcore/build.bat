:: Generated by: https://openapi-generator.tech
::

@echo off

dotnet restore src\OpenWealth
dotnet build src\OpenWealth
echo Now, run the following to start the project: dotnet run -p src\OpenWealth\OpenWealth.csproj --launch-profile web.
echo.
