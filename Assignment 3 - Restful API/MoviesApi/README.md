# Movies API App

### For ToDo App with authentications please click the link below

[Redirect to sesi7 RESTFUL-API Project](https://github.com/kurisu-snek/CIMB_Specialization/tree/main/sesi7)

### Prerequisites

1. Ensure MySQL is installed on your system (XAMPP or other MySQL server)
2. Import the db_movies to your MySQL server
3. Ensure MySQL connection is opened

### Description :

- Outlines the RESTful API architecture used for the Movies app.
- Covers key API endpoints and request/response formats.
- Application runs on .net 5.0 and MySQL for database

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

- `Controllers`, houses controller classes that handle incoming requests and orchestrate responses.
- `Models`, contains model classes that represent the core data entities of the application.

### Movie

```http
  GET /api/Movie
```

```http
  POST /api/Movie
```

```http
  GET /api/Movie/{id}
```

```http
  PUT /api/Movie/{id}
```

```http
  DELETE /api/Movie/{id}
```
