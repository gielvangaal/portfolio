namespace Application.DTOs.Responses;

public class WorkExperienceResponse
{
    public int Id { get; set; }

    public OrganizationResponse Organization { get; set; } = null!;

    public string Role { get; set; } = string.Empty;

    public int? StartYear { get; set; }

    public int? EndYear { get; set; }

    public MediaResponse? Media { get; set; }

    public IReadOnlyCollection<string> Responsibilities { get; set; }
        = [];

    public IReadOnlyCollection<TechnologyResponse> Technologies { get; set; }
        = [];

    public IReadOnlyCollection<SkillResponse> Skills { get; set; }
        = [];

    public IReadOnlyCollection<ToolingResponse> Tooling { get; set; }
        = [];
}