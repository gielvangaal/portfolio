using Application.DTOs.Responses;
using Application.Interfaces;
using Domain.Entities;

namespace Application.Mappers;

public class SkillMapper : ISkillMapper
{
    public SkillResponse Map(Skill skill)
    {
        return new SkillResponse
        {
            Id = skill.Id,
            Name = skill.Name
        };
    }
}