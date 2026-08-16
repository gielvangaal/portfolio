using Domain.Enums;

namespace Domain.Entities;

public class PortfolioItemMedia
{
    public int Id { get; set; }

    public int PortfolioItemId { get; set; }
    public int MediaId { get; set; }

    public MediaRole Role { get; set; }

    public int SortOrder { get; set; }

    public PortfolioItem PortfolioItem { get; set; } = null!;
    public Media Media { get; set; } = null!;
}