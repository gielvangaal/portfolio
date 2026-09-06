namespace Domain.Entities;

public class Education
{
    public int Id { get; set; }

    public int OrganizationId { get; set; }

    public Organization Organization { get; set; } = null!;

    public required string Program { get; set; }

    public int StartYear { get; set; }

    public int? EndYear { get; set; }

    public int SortOrder { get; set; }

    public ICollection<EducationSection> Sections { get; set; } = [];

    public ICollection<Credential> Credentials { get; set; } = [];
}