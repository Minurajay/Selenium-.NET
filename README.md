# TestProject1

## Overview
A Selenium .NET automated test suite for saucedemo.com using the Page Object Model and NUnit.

## Structure
- **Drivers/**: WebDriver creation
- **Pages/**: Page objects
- **Tests/**: NUnit test classes
- **Utils/**: Helpers for config and test data

## Run Tests
```bash
dotnet test
```

## Configuration
Update `appsettings.json` for environment details.

// TestProject1.csproj
<Project Sdk="Microsoft.NET.Sdk">
  <PropertyGroup>
    <OutputType>Exe</OutputType>
    <TargetFramework>net6.0</TargetFramework>
  </PropertyGroup>

  <ItemGroup>
    <PackageReference Include="Microsoft.NET.Test.Sdk" Version="17.6.3" />
    <PackageReference Include="NUnit" Version="3.13.3" />
    <PackageReference Include="NUnit3TestAdapter" Version="4.5.0" />
    <PackageReference Include="Selenium.WebDriver" Version="4.18.0" />
    <PackageReference Include="Selenium.WebDriver.ChromeDriver" Version="124.0.6367.60" />
    <PackageReference Include="Newtonsoft.Json" Version="13.0.3" />
  </ItemGroup>
</Project>

// .gitattributes
* text=auto