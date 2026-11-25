# Student & Course Management (project-Card)

An **ASP.NET Core 9 MVC** web app for managing **students** and the **courses** they are enrolled in. It uses Entity Framework Core with SQL Server (Code-First).

## Features

- **Courses:** list, details, create, edit, delete.
- **Students:** list, details, create, edit, delete. Each student belongs to one course.
- **Search** students by name.
- Server-side validation (for example, a valid course must be selected).
- Reusable file upload helper (`FileUploader`) that stores files with unique GUID names and can remove them.

## Tech stack

- C# / .NET 9, ASP.NET Core MVC with Razor views
- Entity Framework Core 9 (SQL Server) with migrations
- Bootstrap and jQuery validation

## Data model

| Entity | Fields |
| --- | --- |
| `Course` | Id, Name, Description |
| `Student` | Id, Name, Email, Password, IsActive, CourseId, Course |

Relationship: one `Course` has many `Student`s (delete behavior set to `NoAction`).

## Project structure

```
project-Card/
├── final project1.sln
└── final project1/
    ├── Controllers/        # Courses, Students, Home
    ├── Data/ApplicationDbContext.cs
    ├── Models/             # Course, Student
    ├── Migrations/
    ├── Views/              # Courses, Students, Home, Shared
    ├── wwwroot/            # CSS, JS, Bootstrap, FileUploader
    ├── appsettings.json
    └── Program.cs
```

## Getting started

**Prerequisites:** [.NET 9 SDK](https://dotnet.microsoft.com/download) and SQL Server / SQL Server Express.

```bash
git clone https://github.com/ahmed19104/project-Card.git
cd "project-Card/final project1"
```

1. The connection string is set in `Data/ApplicationDbContext.cs` (`OnConfiguring`). Change the server name to your own instance.
2. Apply migrations:
   ```bash
   dotnet ef database update
   ```
3. Run:
   ```bash
   dotnet run
   ```

## Known limitations and next steps

- Student passwords are stored as plain text in the `Student` model. Hash them (for example with ASP.NET Core Identity's `PasswordHasher`) before using this beyond practice.
- Move the connection string to configuration (`appsettings.json` or user secrets).
- Add authentication and authorization for the management pages.

## Author

**Ahmed Yaser** - [@ahmed19104](https://github.com/ahmed19104)
