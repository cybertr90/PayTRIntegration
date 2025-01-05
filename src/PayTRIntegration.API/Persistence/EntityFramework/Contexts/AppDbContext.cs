using Microsoft.EntityFrameworkCore;
using PayTRIntegration.API.Domain.Entities;

namespace PayTRIntegration.API.Persistence;

public sealed class AppDbContext: DbContext
{
    
    public DbSet<Order> Orders { get; set; }
    public DbSet<OrderHistory> OrderHistories { get; set; }
    public DbSet<Payment> Payments { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<Promotion> Promotions { get; set; }
    public DbSet<Tenant> Tenants { get; set; }
    public DbSet<User> Users { get; set; }
    
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
        
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
    }
    
}