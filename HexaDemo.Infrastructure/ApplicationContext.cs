using HexaDemo.Domain.Entities;
using HexaDemo.Infrastructure.Configurations;
using HexaDemo.Infrastructure.Entities;
using Microsoft.EntityFrameworkCore;

namespace HexaDemo.Infrastructure;

public class ApplicationContext : DbContext
{
    public DbSet<ProductEntity> Products { get; set; }
    
    public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new ProductEntityConfiguration());
        base.OnModelCreating(modelBuilder);
    }
}