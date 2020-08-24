# Pairing workshop skeleton solution

## Commands used to create solution
```
dotnet new sln -o GameOfLife
cd GameOfLife

dotnet new console -o GameOfLifeApp
dotnet sln add .\GameOfLifeApp\GameOfLifeApp.csproj

dotnet new xunit -o GameOfLife.Tests
dotnet sln add .\GameOfLife.Tests\GameOfLife.Tests.csproj
dotnet add .\GameOfLife.Tests\GameOfLife.Tests.csproj reference .\GameOfLifeApp\GameOfLifeApp.csproj
```