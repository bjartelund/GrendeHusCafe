using Microsoft.EntityFrameworkCore;

namespace Context;

public class CafeContext(DbContextOptions<CafeContext> options) : DbContext(options)
{
    public DbSet<Product> Products { get; set; }
}