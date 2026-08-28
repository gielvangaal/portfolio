using Domain.Enums;

namespace Application.DTOs.Responses;

public class MediaResponse
{
    public string Path { get; set; } = string.Empty;

    public string AltText { get; set; } = string.Empty;

    public MediaType Type { get; set; }
}