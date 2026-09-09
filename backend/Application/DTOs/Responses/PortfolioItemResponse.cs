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

    public IReadOnlyCollection<string> Categories { get; set; } = [];

    public IReadOnlyCollection<TechnologyResponse> Technologies { get; set; } = [];

    public IReadOnlyCollection<SkillResponse> Skills { get; set; } = [];

    public IReadOnlyCollection<ToolingResponse> Tooling { get; set; } = [];

    public IReadOnlyCollection<PortfolioMediaResponse> Media { get; set; } = [];
}