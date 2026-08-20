using Domain.Enums;

namespace Application.DTOs.Responses;

public class PortfolioItemResponse
{
    public string Slug { get; set; } = string.Empty;

    public string Title { get; set; } = string.Empty;

    public string CardDescription { get; set; } = string.Empty;

    public string Description { get; set; } = string.Empty;

    public DateOnly ProjectDate { get; set; }

    public string ProjectType { get; set; } = string.Empty;

    public string Role { get; set; } = string.Empty;

    public int? TeamSize { get; set; }

    public string? Duration { get; set; }

    public string? GitHubUrl { get; set; }

    public string? LiveSiteUrl { get; set; }

    public ICollection<string> Categories { get; set; } = [];

    public ICollection<string> Technologies { get; set; } = [];

    public ICollection<PortfolioMediaResponse> Media { get; set; } = [];
}