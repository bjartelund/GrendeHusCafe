using Microsoft.EntityFrameworkCore;

namespace Context;

public class CafeContext(DbContextOptions<CafeContext> options) : DbContext(options)
{
    public DbSet<Product> Products { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<OrderItem> OrderItems { get; set; }
    public DbSet<WorkSession> WorkSessions { get; set; }
    public DbSet<Expense> Expenses { get; set; }
}