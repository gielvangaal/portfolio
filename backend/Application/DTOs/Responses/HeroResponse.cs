namespace Application.DTOs.Responses;

public class HeroResponse
{
    public string Name { get; set; } = string.Empty;

    public string JobTitle { get; set; } = string.Empty;

    public string CatchPhrase { get; set; } = string.Empty;

    public string Description { get; set; } = string.Empty;

    public string? MediaPath { get; set; }

    public string? MediaAltText { get; set; }
}