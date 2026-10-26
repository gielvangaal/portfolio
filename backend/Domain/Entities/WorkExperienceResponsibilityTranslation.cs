namespace Domain.Entities;

public class WorkExperienceResponsibilityTranslation
{
    public int Id { get; set; }

    public int WorkExperienceResponsibilityId { get; set; }

    public WorkExperienceResponsibility WorkExperienceResponsibility { get; set; } = null!;

    public required string Language { get; set; }

    public required string Description { get; set; }
}