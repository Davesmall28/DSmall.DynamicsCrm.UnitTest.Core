SET packageVersion=1.1.0

NuGet.exe pack ../Springboard365.Xrm.UnitTest.Core.csproj -Build -symbols -Version %packageVersion%

NuGet.exe push Springboard365.Xrm.UnitTest.Core.%packageVersion%.nupkg

pause