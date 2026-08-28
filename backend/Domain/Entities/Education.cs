namespace Domain.Entities;

public class Education
{
    public int Id { get; set; }

    public required string Institution { get; set; }

    public required string Program { get; set; }

    public int StartYear { get; set; }

    public int? EndYear { get; set; }

    public int SortOrder { get; set; }

    public int? MediaId { get; set; }

    public Media? Media { get; set; }

    public ICollection<EducationSection> Sections { get; set; } = [];
}