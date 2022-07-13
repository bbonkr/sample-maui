
```bash
$ dotnet build SampleLayoutApp.csproj -t:Run -f net6.0-android
$ dotnet build SampleLayoutApp.csproj -t:Run -f net6.0-ios -p:_DeviceName=:v2:udid=6DBC1A4C-174B-4288-8417-95A30E2748C2
$ dotnet build SampleLayoutApp.csproj -t:Run -f net6.0-maccatalyst
$ dotnet build SampleLayoutApp.csproj -t:Run -f net6.0-windows10.0.19041.0
```