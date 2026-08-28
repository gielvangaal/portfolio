using Domain.Enums;

namespace Domain.Entities;

public class Skill
{
    public int Id { get; set; }

    public required string Name { get; set; }
    
    public SkillType Type { get; set; }
}