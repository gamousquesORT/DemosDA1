# Refactoring Fowler
A C# translation from JavaScript of the examples in Martin Fowler's ["Refactoring"](https://martinfowler.com/articles/refactoring-2nd-changes.html) :book:, 2nd Edition. Watch a [podcast](https://www.infoq.com/podcasts/refactoring-evolutionary-architecture) about why the 2nd Edition was written.

## How the Code is translated
The C# code follows the JavaScript as closely as possible

The C# code should be "good style", specifically [ReSharper](https://www.jetbrains.com/resharper) should have no warnings

## Target Environment
.NET Core 5.0

### Build
* [Visual Studio Code](https://code.visualstudio.com) v1.52+ with [C# extension](https://marketplace.visualstudio.com/items?itemName=ms-vscode.csharp) v1.23+
* Visual Studio 2019 v16.8+ 
### Dependencies
* C# .NET Core using [SDK](https://www.microsoft.com/net/download) v5.0+
* [NUnit](https://nunit.org) v3.12+

## Testing
Unit testing is vital to refactoring and have been added. 
The convention used is that the tests for *ChapterN* are in project *ChapterN.Tests*

## Static Analysis
* [PVS-Studio](https://www.viva64.com/en/pvs-studio/) 7.11+ (No CI support currently)
* [ReSharper](https://www.jetbrains.com/resharper/) 2020.3+

## Installing
### Package Manager (for NUnit3 Test projects)
* Install-Package NUnit -Version 3.12.0
* Install-Package NUnit3TestAdapter -Version 3.17.0
* Install-Package Microsoft.NET.Test.Sdk -Version 16.8.3
### Package Manager (for Coverage on Test projects)
* Install-Package coverlet.msbuild -Version 2.9.0
* Install-Package coveralls.io -Version 1.4.2

## Continuous Integration
[Appveyor](https://www.appveyor.com) using appveyor.yml for Visual Studio 2019

[![Build status](https://ci.appveyor.com/api/projects/status/v3yc51dovaje1jpw/branch/master?svg=true)](https://ci.appveyor.com/project/ydango/refactoringfowler)

[![Coverage Status](https://coveralls.io/repos/github/ydango/RefactoringFowler/badge.svg?branch=master)](https://coveralls.io/github/ydango/RefactoringFowler?branch=master)
  
[![Build history](https://buildstats.info/appveyor/chart/ydango/refactoringfowler)](https://ci.appveyor.com/project/ydango/refactoringfowler/history)

## License
Using the [MIT](https://opensource.org/licenses/MIT) license, as used by .NET Core
