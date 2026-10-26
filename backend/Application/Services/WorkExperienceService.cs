using Application.DTOs.Responses;
using Application.Interfaces;

namespace Application.Services;

public class WorkExperienceService
    : IWorkExperienceService
{
    private readonly IWorkExperienceRepository _workExperienceRepository;
    private readonly IWorkExperienceMapper _workExperienceMapper;

    public WorkExperienceService(
        IWorkExperienceRepository workExperienceRepository,
        IWorkExperienceMapper workExperienceMapper)
    {
        _workExperienceRepository = workExperienceRepository;
        _workExperienceMapper = workExperienceMapper;
    }

    public async Task<IReadOnlyCollection<WorkExperienceResponse>> GetAllAsync(string language)
    {
        var workExperiences =
            await _workExperienceRepository.GetAllAsync();

        return workExperiences
            .Select(x => _workExperienceMapper.Map(x, language))
            .ToList();
    }
}