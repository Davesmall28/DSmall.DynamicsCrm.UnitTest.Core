SET packageVersion=2.1.0

NuGet.exe pack ../Springboard365.Xrm.UnitTest.Core.csproj -Build -Symbols -Version %packageVersion% -Properties Configuration=Release

NuGet.exe push Springboard365.Xrm.UnitTest.Core.%packageVersion%.nupkg -source "https://api.nuget.org/v3/index.json"

pause