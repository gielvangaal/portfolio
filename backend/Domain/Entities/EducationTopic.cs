namespace Domain.Entities;

public class EducationTopic
{
    public int Id { get; set; }

    public int EducationSectionId { get; set; }

    public EducationSection EducationSection { get; set; } = null!;

    public required string Name { get; set; }

    public int SortOrder { get; set; }
}