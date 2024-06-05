using Microsoft.EntityFrameworkCore;
using TodoApi;
using TodoApi.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

var serverVersion = new MySqlServerVersion(new Version(8, 0, 36));

builder.Services.AddDbContext<AppDbContext>(opt =>
    {
        // opt.UseInMemoryDatabase("StopList");
        // opt.UseSqlite(Configuration["ConnectionStrings:WebApiDatabase"]);
        _ = builder.Environment.IsDevelopment() ? opt.UseSqlite(builder.Configuration.GetConnectionString("WebApiDatabase"))
        : opt.UseMySql(builder.Configuration.GetConnectionString("WebApiDatabase"), serverVersion)
                // The following three options help with debugging, but should
                // be changed or removed for production.
                .LogTo(Console.WriteLine, LogLevel.Information)
                .EnableSensitiveDataLogging()
                .EnableDetailedErrors();
    });
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();


app.MapControllers();
app.Run();
