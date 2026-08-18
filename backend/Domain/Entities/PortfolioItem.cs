namespace Domain.Entities;

public class PortfolioItem
{
    public int Id { get; set; }

    public string Language { get; set; } = string.Empty;
    public string Slug { get; set; } = string.Empty;

    public string Title { get; set; } = string.Empty;
    public string CardDescription { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;

    public string? GitHubUrl { get; set; }
    public string? LiveSiteUrl { get; set; }

    public ICollection<Category> Categories { get; set; } = [];
    public ICollection<Technology> Technologies { get; set; } = [];
    public ICollection<PortfolioItemMedia> Media { get; set; } = [];
}