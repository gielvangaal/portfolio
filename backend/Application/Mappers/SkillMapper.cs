using Application.DTOs.Responses;
using Application.Interfaces;
using Domain.Entities;

namespace Application.Mappers;

public class SkillMapper : ISkillMapper
{
    public SkillResponse Map(Skill skill, string language)
    {
        return new SkillResponse
        {
            Id = skill.Id,
            Key = skill.Key,
            Name = skill.Translations.FirstOrDefault(x => x.Language == language)?.Name
                ?? skill.Translations.FirstOrDefault(x => x.Language == "nl")?.Name
                ?? skill.Key,
            Type = skill.Type.ToString()
        };
    }
}