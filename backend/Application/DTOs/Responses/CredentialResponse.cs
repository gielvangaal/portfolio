namespace Application.DTOs.Responses;

public class CredentialResponse
{
    public int Id { get; set; }

    public string Name { get; set; } = string.Empty;

    public string Type { get; set; } = string.Empty;

    public string Status { get; set; } = string.Empty;

    public int? Year { get; set; }

    public string? CredentialUrl { get; set; }

    public string? DocumentUrl { get; set; }
}