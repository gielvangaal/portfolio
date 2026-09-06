namespace Application.DTOs.Responses;

public class EducationResponse
{
    public int Id { get; set; }

    public OrganizationResponse Organization { get; set; } = null!;

    public string Program { get; set; } = string.Empty;

    public int StartYear { get; set; }

    public int? EndYear { get; set; }

    public IReadOnlyCollection<EducationSectionResponse> Sections { get; set; }
        = [];

    public IReadOnlyCollection<CredentialResponse> Credentials { get; set; }
        = [];
}