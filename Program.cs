using Microsoft.EntityFrameworkCore;
using TodoApi;
using TodoApi.Models;

var builder = WebApplication.CreateBuilder(args);

// var startup = new Startup(builder.Configuration);
// startup.ConfigureServices(builder.Services);

builder.Services.AddControllers();

/*
    services.AddDbContext<TodoContext>(opt =>
        {
          opt.UseInMemoryDatabase("TodoList");
        });*/

builder.Services.AddDbContext<AppDbContext>(opt =>
    {
        // opt.UseInMemoryDatabase("StopList");
        // opt.UseSqlite(Configuration["ConnectionStrings:WebApiDatabase"]);
        opt.UseSqlite(builder.Configuration.GetConnectionString("WebApiDatabase"));
        // opt.UseSqlite("Data Source=databse.dat");
        // opt.UseSqlite(builder.Configuration)
    });
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// startup.Configure(app, app.Environment);
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();


app.MapControllers();
app.Run();
