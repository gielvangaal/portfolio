using Domain.Entities;

namespace Application.Interfaces;

public interface ISkillRepository
{
    Task<IReadOnlyCollection<Skill>> GetAllAsync();
}