using Microsoft.EntityFrameworkCore;

namespace TodoApi.Models;

public class StopContext : DbContext
{
    public StopContext(DbContextOptions<StopContext> options)
        : base(options)
    {
    }

    public DbSet<StopItem> StopItems { get; set; } = null!;
}
