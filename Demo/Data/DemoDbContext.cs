using Demo.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Demo.Data;

public class DemoDbContext : DbContext
{
    public DbSet<OrderEntity> Orders { get; set; }

    public DemoDbContext(DbContextOptions<DemoDbContext> options)
        : base(options)
    {
    }

}