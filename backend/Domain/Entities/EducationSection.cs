namespace Domain.Entities;

public class EducationSection
{
    public int Id { get; set; }

    public int EducationId { get; set; }

    public Education Education { get; set; } = null!;

    public string? Title { get; set; }

    public int SortOrder { get; set; }

    public ICollection<Technology> Technologies { get; set; } = [];

    public ICollection<Skill> Skills { get; set; } = [];

    public ICollection<Tooling> Tooling { get; set; } = [];
}