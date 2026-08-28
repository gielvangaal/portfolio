using Application.DTOs.Responses;
using Domain.Entities;

namespace Application.Interfaces;

public interface ISkillMapper
{
    SkillResponse Map(Skill skill);
}