namespace Domain.Entities;

public class SkillTranslation
{
    public int Id { get; set; }

    public int SkillId { get; set; }

    public Skill Skill { get; set; } = null!;

    public required string Language { get; set; }

    public required string Name { get; set; }
}