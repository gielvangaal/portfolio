namespace Application.DTOs.Responses;

public class OrganizationResponse
{
    public int Id { get; set; }

    public string Name { get; set; } = string.Empty;

    public string Type { get; set; } = string.Empty;

    public string? WebsiteUrl { get; set; }

    public MediaResponse? Media { get; set; }
}