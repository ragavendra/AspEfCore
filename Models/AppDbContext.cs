using Microsoft.EntityFrameworkCore;

namespace TodoApi.Models;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public DbSet<TodoItem> TodoItems { get; set; } = null!;

    public DbSet<StopItem> StopItems { get; set; } = null!;
}
