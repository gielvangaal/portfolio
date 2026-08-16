namespace Domain.Entities;

public class GitHubLink
{
    public int Id { get; set; }

    public int PortfolioItemId { get; set; }

    public required string Url { get; set; }
    public required string Label { get; set; }

    public int SortOrder { get; set; }

    public PortfolioItem PortfolioItem { get; set; } = null!;
}