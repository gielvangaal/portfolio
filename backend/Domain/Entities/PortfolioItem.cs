using Domain.Enums;

namespace Domain.Entities;

public class PortfolioItem
{
    public int Id { get; set; }

    public string Language { get; set; } = string.Empty;
    public string Slug { get; set; } = string.Empty;

    public string Title { get; set; } = string.Empty;
    public string CardDescription { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    
    public DateOnly ProjectDate { get; set; }

    public ProjectType ProjectType { get; set; }

    public string Role { get; set; } = string.Empty;

    public int? TeamSize { get; set; }

    public string? Duration { get; set; }
    
    public string? GitHubUrl { get; set; }
    public string? LiveSiteUrl { get; set; }

    public ICollection<Category> Categories { get; set; } = [];
    public ICollection<Technology> Technologies { get; set; } = [];
    public ICollection<PortfolioItemMedia> Media { get; set; } = [];
}