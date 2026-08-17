namespace Domain.Entities;

public class Technology
{
    public int Id { get; set; }

    public required string Name { get; set; }

    public ICollection<PortfolioItemTechnology> PortfolioItems { get; set; } = [];

    public ICollection<Category> Categories { get; set; } = [];
}