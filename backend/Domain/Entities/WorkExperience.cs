namespace Domain.Entities;

public class WorkExperience
{
    public int Id { get; set; }

    public required string Company { get; set; }

    public required string Role { get; set; }

    public int? StartYear { get; set; }

    public int? EndYear { get; set; }

    public int SortOrder { get; set; }

    public int? MediaId { get; set; }

    public Media? Media { get; set; }

    public ICollection<WorkExperienceResponsibility> Responsibilities { get; set; } = [];

    public ICollection<Technology> Technologies { get; set; } = [];

    public ICollection<Skill> Skills { get; set; } = [];

    public ICollection<Tooling> Tooling { get; set; } = [];
}