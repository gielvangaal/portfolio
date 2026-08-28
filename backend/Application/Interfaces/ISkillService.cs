using Application.DTOs.Responses;

namespace Application.Interfaces;

public interface ISkillService
{
    Task<IReadOnlyCollection<SkillResponse>> GetAllAsync();
}