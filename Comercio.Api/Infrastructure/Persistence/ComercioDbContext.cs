using Comercio.Api.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Comercio.Api.Infrastructure.Persistence;

public sealed class ComercioDbContext(DbContextOptions<ComercioDbContext> options)
    : DbContext(options)
{
    public DbSet<Category> Categories => Set<Category>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(ComercioDbContext).Assembly);
    }
}
