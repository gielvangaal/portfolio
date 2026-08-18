using Domain.Enums;

namespace Application.DTOs.Responses;

public class PortfolioMediaResponse
{
    public string Path { get; set; } = string.Empty;

    public string AltText { get; set; } = string.Empty;

    public MediaRole Role { get; set; }

    public int SortOrder { get; set; }
}