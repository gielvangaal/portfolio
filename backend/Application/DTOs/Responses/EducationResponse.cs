namespace Application.DTOs.Responses;

public class EducationResponse
{
    public int Id { get; set; }

    public string Institution { get; set; } = string.Empty;

    public string Program { get; set; } = string.Empty;

    public int StartYear { get; set; }

    public int? EndYear { get; set; }

    public MediaResponse? Media { get; set; }

    public IReadOnlyCollection<EducationSectionResponse> Sections { get; set; }
        = [];
}