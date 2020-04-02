# SalesTaxCalculatorNC

A Sales tax calculating Web API for calculating tax on retail purchase in different counties in north carolina. 

## Getting Started

These instructions will get you a copy of the project up and running on your local machine for development and testing purposes. See deployment for notes on how to deploy the project on a live system.

### Prerequisites

Visual Studio with C# and .NET
Windows 10
PostMan

Download visual studio from [Visual Studio](https://visualstudio.microsoft.com/) - IDE used

Download Postman from [Postman](https://www.postman.com/downloads/) - API request handler


### Packages

Microsoft.AspNet.WebApi version= 5.2.7

Microsoft.AspNet.WebApi.Client version= 5.2.7

Microsoft.AspNet.WebApi.Core version= 5.2.7

Microsoft.AspNet.WebApi.WebHost version= 5.2.7

Microsoft.CodeDom.Providers.DotNetCompilerPlatform version= 2.0.1

Newtonsoft.Json version= 12.0.2

### API End Point
Calculate: send in two parameters, county and cost and returns json object of Sales tax for that county. if county does not exist returns status failure.
```
HOST URL/api/salestax/Calculate/{county}/{cost}
```
### Installing

After cloning Repoistory, Open Visual Studio and open solutions Folder.
After opening project, install any missing packages using nuGet Package manager.

Build Solution by pressing "CTRL + Shift + B" or by going onto build dropdown in menu and click Build.

## Running Web API
After cloning and installing Repository, open repository in Visual Studio. 
Run program in IIS Express (Google chrome). a window will pop up in google chrome stating successful run of Web API.

To get results from Web API open Postman.
Select create new request.
set request type to "GET" and Request url as "http://localhost:51953/api/salestax/Calculate/{county}/{cost}/",
where {county} is the county in north carolina and {cost} is the cost of transaction
Example:
```
http://localhost:51953/api/salestax/Calculate/Yancey/124.53/
```
After entering Parameters click send.
you will recieve a response from API in the form of a JSON datatype.
Example
```
{
  "status": "SUCCESS",
  "data": [
    "$8.41"
  ]
}
```

Another method to request for API call is to enter Request URL into browser. it will also give you a response in JSON format.
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
