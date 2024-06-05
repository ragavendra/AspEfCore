# ASP .Net back end API
A minimal backend API template using `.Net8.0` anf `EF Core` to get one started up and running quickly.

### Create and apply migrations

Create migrations.

```
dotnet ef migrations add InitialCreate
```

Update it to the database or create database, once for each environment.
```
dotnet ef database update -- --environment Development
```
### Running in different environments

Update [appsettings.json](appsettings.json) for `Production`, [appsettings.Development.json](appsettings.Development.json) for `Development` and [appsettings.Staging.json](appsettings.Staging.json) for `Staging` respectively. The `ASPNETCORE_ENVIRONMENT` is set to the respective environment.

```
dotnet run --launch-profile https --environment Development
dotnet run --launch-profile https --environment Production
```

### Swagger or API's

Navigate to [swagger](https://localhost:7027/swagger) to access the API's.
