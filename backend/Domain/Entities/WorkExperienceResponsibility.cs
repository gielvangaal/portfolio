namespace Domain.Entities;

public class WorkExperienceResponsibility
{
    public int Id { get; set; }

    public int WorkExperienceId { get; set; }

    public WorkExperience WorkExperience { get; set; } = null!;

    public int SortOrder { get; set; }

    public ICollection<WorkExperienceResponsibilityTranslation> Translations { get; set; } = [];
}