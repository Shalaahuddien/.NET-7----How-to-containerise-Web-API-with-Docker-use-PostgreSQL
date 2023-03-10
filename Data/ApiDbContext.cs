using DemoApp.Models;
using Microsoft.EntityFrameworkCore;

namespace DemoApp.Data;

public class ApiDbContext : DbContext
{
    public ApiDbContext(DbContextOptions<ApiDbContext> options)
        : base(options)
    {
        
    }

    public DbSet<Driver> Drivers {get; set;}

}