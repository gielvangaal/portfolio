namespace Domain.Entities;

public class PortfolioItemCategory
{
    public int Id { get; set; }
    
    public int PortfolioItemId { get; set; }
    public int CategoryId { get; set; }

    public PortfolioItem PortfolioItem { get; set; } = null!;
    public Category Category { get; set; } = null!;
}