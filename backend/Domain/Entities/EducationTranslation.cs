namespace Domain.Entities;

public class EducationTranslation
{
    public int Id { get; set; }

    public int EducationId { get; set; }

    public Education Education { get; set; } = null!;

    public required string Language { get; set; }

    public required string Program { get; set; }
}