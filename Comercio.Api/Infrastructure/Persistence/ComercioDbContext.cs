using Microsoft.EntityFrameworkCore;

namespace Comercio.Api.Infrastructure.Persistence;

public sealed class ComercioDbContext(DbContextOptions<ComercioDbContext> options)
    : DbContext(options)
{
}
