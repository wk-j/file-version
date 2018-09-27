## File Version

[![Build Status](https://dev.azure.com/wk-j/file-version/_apis/build/status/wk-j.file-version)](https://dev.azure.com/wk-j/file-version/_build/latest?definitionId=13)
[![NuGet](https://img.shields.io/nuget/v/wk.FileVersion.svg)](https://www.nuget.org/packages/wk.FileVersion)

## Installation

```bash
dotnet add package wk.FileVersion
```

## Usage

```csharp
var parser = Parser
    .FromPath("src/FileVersion.1.0.1.zip")
    .Remove(".zip")
    .Remove("FileVersion.");
Assert.Equal("1.0.1", parser.Version);
```