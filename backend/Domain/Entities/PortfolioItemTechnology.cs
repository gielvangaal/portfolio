namespace Domain.Entities;

public class PortfolioItemTechnology
{
    public int Id { get; set; }
    
    public int PortfolioItemId { get; set; }
    public int TechnologyId { get; set; }

    public PortfolioItem PortfolioItem { get; set; } = null!;
    public Technology Technology { get; set; } = null!;
}