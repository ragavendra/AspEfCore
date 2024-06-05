using Microsoft.EntityFrameworkCore;
using TodoApi.Models;

namespace TodoApi;

public class Startup
{
  public Startup(IConfiguration configuration)
  {
    Configuration = configuration;
  }

  public IConfiguration Configuration { get; }

  public void ConfigureServices(IServiceCollection services)
  {
    services.AddControllers();

    services.AddDbContext<TodoContext>(opt =>
        {
          opt.UseInMemoryDatabase("TodoList");
        });

    services.AddDbContext<StopContext>(opt =>
        {
          // opt.UseInMemoryDatabase("StopList");
          // opt.UseSqlite(Configuration["ConnectionStrings:WebApiDatabase"]);
          opt.UseSqlite(Configuration.GetConnectionString("WebApiDatabase"));
          // opt.UseSqlite("Data Source=databse.dat");
          // opt.UseSqlite(builder.Configuration)
        });
    services.AddEndpointsApiExplorer();
    services.AddSwaggerGen();
  }

  public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
  {
    if (env.IsDevelopment())
    {
      app.UseSwagger();
      app.UseSwaggerUI();
    }

    app.UseHttpsRedirection();

    app.UseAuthorization();

    // app.MapControllers();


  }
}
