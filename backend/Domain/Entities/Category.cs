namespace Domain.Entities;

public class Category
{
    public int Id { get; set; }

    public required string Name { get; set; }

    public ICollection<PortfolioItem> PortfolioItems { get; set; } = [];

    public ICollection<Technology> Technologies { get; set; } = [];
}