# SalesTaxCalculatorNC

A Sales tax calculating Web API for calculating tax on retail purchase in different counties in north carolina. 

## Getting Started

These instructions will get you a copy of the project up and running on your local machine for development and testing purposes. See deployment for notes on how to deploy the project on a live system.

### Prerequisites

Visual Studio with C# and .NET
```
Download visual studio from [Visual Studio](https://visualstudio.microsoft.com/) - IDE used
```

### Packages
```
Microsoft.AspNet.WebApi version="5.2.7

Microsoft.AspNet.WebApi.Client version="5.2.7

Microsoft.AspNet.WebApi.Core version="5.2.7

Microsoft.AspNet.WebApi.WebHost version="5.2.7

Microsoft.CodeDom.Providers.DotNetCompilerPlatform version="2.0.1

Newtonsoft.Json 12.0.2
```

### Installing

After cloning Repoistory, Open Visual Studio and open solutions Folder.
After opening project, install any missing packages using nuGet Package manager.

Build Solution by pressing "CTRL + Shift + B" or by going onto build dropdown in menu and click Build.

## Running the tests

To Run all Test press "CTRL + R" or by going to Test dropdown in menu and clicking Run ALl Tests.

### Unit Tests

There are 4 Unit tests in the API, they are:

##### SalesTaxExpectedResult_intParameter:
```
 This Test is used to check if an integer parameter can be passed through to give expected output for sales tax.
```

##### SalesTaxExpectedResult_floatParameter
```
 This Test is used to check if an Float parameter can be passed through to give expected output for sales tax.
```

##### IsStatusFail
```
 This test is used to check if the Transaction Fails when unknown county is passed to the API.
 ```
 
##### IsStatusSuccess
```
 This test is used to check if transaction returns success when valid county is passed to the API.
```

## Built With

* [.Net](https://dotnet.microsoft.com/download/dotnet-framework) - The web framework used


## Authors

* **Sukrit Mehra** - *Initial work* - [SukritMehra](https://github.com/SukritMehra1997)

## Acknowledgments

* Avalara - coding challenge
