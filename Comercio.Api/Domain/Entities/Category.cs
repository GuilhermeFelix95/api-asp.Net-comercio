namespace Comercio.Api.Domain.Entities;

public sealed class Category
{
    public Category(string name, string? description)
    {
        Id = Guid.NewGuid();
        Name = name.Trim();
        Description = description?.Trim();
        IsActive = true;
    }

    public Guid Id { get; private set; }

    public string Name { get; private set; }

    public string? Description { get; private set; }

    public bool IsActive { get; private set; }
}
