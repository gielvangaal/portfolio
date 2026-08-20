using Domain.Enums;

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
    public IReadOnlyCollection<string> Technologies { get; set; } = [];

    public string? PrimaryImageUrl { get; set; }
}