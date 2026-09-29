using Comercio.Api.Domain.Entities;

namespace Comercio.Api.Tests;

public class CategoryTests
{
    [Fact]
    public void Should_create_active_category_with_normalized_name()
    {
        var category = new Category("  Bebidas  ", "Produtos para beber");

        Assert.NotEqual(Guid.Empty, category.Id);
        Assert.Equal("Bebidas", category.Name);
        Assert.Equal("Produtos para beber", category.Description);
        Assert.True(category.IsActive);
    }
}
