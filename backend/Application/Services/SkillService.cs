using Application.DTOs.Responses;
using Application.Interfaces;

namespace Application.Services;

public class SkillService : ISkillService
{
    private readonly ISkillRepository _skillRepository;
    private readonly ISkillMapper _skillMapper;

    public SkillService(
        ISkillRepository skillRepository,
        ISkillMapper skillMapper)
    {
        _skillRepository = skillRepository;
        _skillMapper = skillMapper;
    }

    public async Task<IReadOnlyCollection<SkillResponse>> GetAllAsync()
    {
        var skills = await _skillRepository.GetAllAsync();

        return skills
            .Select(_skillMapper.Map)
            .ToList();
    }
}