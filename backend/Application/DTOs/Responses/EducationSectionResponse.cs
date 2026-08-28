namespace Application.DTOs.Responses;

public class EducationSectionResponse
{
    public int Id { get; set; }

    public string? Title { get; set; }

    public IReadOnlyCollection<TechnologyResponse> Technologies { get; set; }
        = [];

    public IReadOnlyCollection<EducationTopicResponse> Topics { get; set; }
        = [];
}