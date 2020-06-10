# Project Name: CPA Coding Part 2

## Design decisions:
    Adopt the TDD approach. Creating code based on the emerging requirements and re-engineering as needed.
    Functional programming is adopted in individual modules to make the code simpler and more concise.
    Asynchronous code support to deal with real world problem.
	Dockfile is generated for easily test bed setup.
	Testing project is included to test the HTTP response.

## Dependencies:
    '.NET Core 3.1' - .NET framework to establish the service
    'MsTest' - as testing framework

## Code Structure:

    There are two projects under the solution

    BackendApp
    -   the Restful API service to return the data as required
	
    BackendUnitTestProject
    -   provide Unit Test cases for the API service
    

## Get started

1. create a folder in your local computer and clone the project:
```
    git clone https://github.com/junfengchen/cpacodingpart2.git
```


2. You will see two new folders are created. Open "BackendApp\BackendApp.sln" from Visual Studio 2019

To test the code, open 'Developer Command Prompt' and run:
```
    dotnet test
```

To start the service, run:
```
    dotnet run
```

And access the service from:
```
	https://localhost:5001/api
```

## Thoughouts

If more time is given, I can expand the code to cover features like database query, database persistence and state JWT token authentication.