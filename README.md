# Turbo Turtle
Blazor To-Do app

Yet another To-Do application built with Blazor Server and .NET 5.

## Features
- [ ] CRUD (create, read, update and delete) actions on tasks
- [ ] Managing categories and assigning tasks to them
- [ ] Managing tasks list.
- [ ] Sharing tasks list

## Getting Started with Blazor

To get setup with Blazor:

1. Install the [.NET 5 SDK](https://dotnet.microsoft.com/download/dotnet/5.0) (5.0.202 or later).
2. Install your favourite editor: [Visual Studio](https://visualstudio.microsoft.com/), [VSCode](https://code.visualstudio.com/), [Rider](https://www.jetbrains.com/rider/), smth else

## Get it running

### Clone source code

```bash
git clone https://github.com/amka/turbo-turtle/
cd turbo-turtle
```

### Setup Database Connections

This example is running on in SQLite database. You can change that in Startup.cs file.


```cs
services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlite(
        Configuration.GetConnectionString("DefaultConnection")));
```
<!-- When running on Windows, the server is using in memory database on default configuration. You can change that in the file appsettings.json. -->

```xml
"ConnectionStrings": {
  "DefaultConnection": "DataSource=app.db;Cache=Shared"
}
```

### Run the application

```bash
dotnet run
```

## Screenshots

Work in progress.
