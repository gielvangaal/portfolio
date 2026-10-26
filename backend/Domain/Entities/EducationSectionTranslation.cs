namespace Domain.Entities;

public class EducationSectionTranslation
{
    public int Id { get; set; }

    public int EducationSectionId { get; set; }

    public EducationSection EducationSection { get; set; } = null!;

    public required string Language { get; set; }

    public required string Title { get; set; }
}