# Dotnet.Tool.MD5

[![NuGet][main-nuget-badge]][main-nuget]

[main-nuget]: https://www.nuget.org/packages/dmd5/
[main-nuget-badge]: https://img.shields.io/nuget/v/dmd5.svg?style=flat-square&label=nuget

Dotnet.Tool.MD5 is a .NET Core Global Tool uesd to generate md5 hash value in CLI.

## Installation

Download and install the [.NET Core 2.1 SDK](https://www.microsoft.com/net/download) or newer. Once installed, run the following command:

```bash
dotnet tool install -g dmd5
```

## Usage

```text
Usage: dmd5 [text] [L|U]
```

## Example

```text
dmd5 foo
acbd18db4cc2f85cedef654fccc4a4d8

dmd5 foo U
ACBD18DB4CC2F85CEDEF654FCCC4A4D8
```
