namespace Application.DTOs.Responses;

public class PortfolioCardResponse
{
    public string Slug { get; set; } = string.Empty;

    public string Title { get; set; } = string.Empty;

    public string CardDescription { get; set; } = string.Empty;

    public DateOnly ProjectDate { get; set; }

    public string ProjectType { get; set; } = string.Empty;

    public string Role { get; set; } = string.Empty;

    public IReadOnlyCollection<string> Categories { get; set; } = [];

    public IReadOnlyCollection<TechnologyResponse> Technologies { get; set; } = [];

    public IReadOnlyCollection<SkillResponse> Skills { get; set; } = [];

    public IReadOnlyCollection<ToolingResponse> Tooling { get; set; } = [];

    public string? PrimaryImageUrl { get; set; }
}