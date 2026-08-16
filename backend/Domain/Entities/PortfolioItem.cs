namespace Domain.Entities;

public class PortfolioItem
{
    public int Id { get; set; }

    public required string Title { get; set; }
    public required string CardDescription { get; set; }
    public required string Description { get; set; }

    public string? LiveSiteUrl { get; set; }

    public ICollection<GitHubLink> GitHubLinks { get; set; } = [];
    public ICollection<Technology> Technologies { get; set; } = [];
    public ICollection<Category> Categories { get; set; } = [];
    public ICollection<PortfolioItemMedia> Media { get; set; } = [];
}