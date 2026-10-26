using Domain.Enums;

namespace Domain.Entities;

public class Skill
{
    public int Id { get; set; }

    public required string Key { get; set; }

    public SkillType Type { get; set; }

    public ICollection<SkillTranslation> Translations { get; set; } = [];
}