# ToDo App

### Description :

- Outlines the RESTful API architecture used for the ToDo app.
- Covers key API endpoints, request/response formats, and authentication mechanisms.
- Application runs on .net 5.0

```
└── TodoApp/
    ├── Configuration/
    │   ├── AuthResult.cs
    │   └── JwtConfig.cs
    ├── Controllers/
    │       ├── AuthManagementController.cs
    │       └── TodoController.cs   
    ├── Data/
    │   └── ApiDbContext.cs
    ├── Migrations
    ├── Models/
    │   └── DTOs/
    │       ├── Requests/
    │       │   ├── TokenRequest.cs
    │       │   ├── UserLoginRequest.cs
    │       │   └── UserRegistrationDto.cs
    │       ├── Responses/
    │       │   └── RegistrationResponse.cs
    │       ├── ItemData.cs
    │       └── RefreshToken.cs
    ├── Program.cs
    ├── Startup.cs
    └── README.md
```

### Directories

- `Configuration`, stores configuration files that hold application-wide settings and preferences.
- `Controllers`, houses controller classes that handle incoming requests and orchestrate responses.
- `Models`, contains model classes that represent the core data entities of the application.
- `Data`, stores static data files used by the application.

### Auth Management

`/api/[controller]/[route]`

```http
  POST /api/AuthManagement/Registration
```

```http
  POST /api/AuthManagement/Login
```

```http
  POST /api/AuthManagement/RefreshToken
```

### Todo

```http
  GET /api/Todo
```

```http
  GET /api/Todo/{id}
```

```http
  POST /api/Todo/
```

```http
  PUT /api/Todo/{id}
```

```http
  DELETE /api/Todo/{id}
```

## Mock Test
Unit Test can be found in UnitTest_Mock

```
└── UnitTest_Mock/
    ├── EmployeeTest/
        ├── EmployeeTest.cs
    ├── UnitTest_Mock/
        ├── Controllers/
        │   └── EmployeeController.cs   
        ├── Migrations
        ├── Models/
        │   ├── ApiDbContext.cs
        |   └── Employee.cs
        ├── Services/
        |   ├── EmployeeService.cs 
        |   └── IEmployeeService.cs
        ├── Program.cs
        └── Startup.cs
```

## Step to Run
1. Open UnitTest_Mock.sln in Visual Studio 2019
2. Run EmployeeTest.cs
3. Click "View"
3. Choose Test Explorer
4. Run the test
5. Get the result