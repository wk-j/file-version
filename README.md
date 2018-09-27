## File Version

## Installation

```bash
dotnet add package wk.FileVersion
```

## Usage

```bash
var v = Parser
    .From("src/FileVersion.1.0.1.zip")
    .Remove(".zip")
    .Remove("FileVersion.");
Assert.Equal("1.0.1", v.Version);
```