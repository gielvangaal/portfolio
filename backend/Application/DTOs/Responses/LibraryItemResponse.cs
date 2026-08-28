namespace Application.DTOs.Responses;

public class LibraryItemResponse
{
    public int Id { get; set; }

    public string Title { get; set; } = string.Empty;

    public string Creator { get; set; } = string.Empty;

    public string Type { get; set; } = string.Empty;

    public MediaResponse? Media { get; set; }

    public IReadOnlyCollection<TechnologyResponse> Technologies { get; set; }
        = [];

    public IReadOnlyCollection<SkillResponse> Skills { get; set; }
        = [];

    public IReadOnlyCollection<ToolingResponse> Tooling { get; set; }
        = [];
}