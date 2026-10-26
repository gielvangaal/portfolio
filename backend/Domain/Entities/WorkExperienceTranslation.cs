namespace Domain.Entities;

public class WorkExperienceTranslation
{
    public int Id { get; set; }

    public int WorkExperienceId { get; set; }

    public WorkExperience WorkExperience { get; set; } = null!;

    public required string Language { get; set; }

    public required string Role { get; set; }
}