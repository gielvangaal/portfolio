using Domain.Enums;

namespace Domain.Entities;

public class Tooling
{
    public int Id { get; set; }

    public required string Name { get; set; }
    
    public CapabilityUsage Usage { get; set; }

    public int? MediaId { get; set; }

    public Media? Media { get; set; }
    
    public ICollection<PortfolioItem> PortfolioItems { get; set; } = [];
}