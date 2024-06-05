# ASP .Net back end API
A minimal backend API template using `.Net8.0` anf `EF Core`.

### Running app in different environments

Update [appsettings.json] for `Production`, [appsettings.Development.json] for `Development` and [appsettings.Staging.json] for `Staging` respectively.

```
dotnet run --launch-profile https --environment Development
dotnet run --launch-profile https --environment Production
```
