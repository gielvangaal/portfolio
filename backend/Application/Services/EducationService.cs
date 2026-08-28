using Application.DTOs.Responses;
using Application.Interfaces;

namespace Application.Services;

public class EducationService : IEducationService
{
    private readonly IEducationRepository _educationRepository;
    private readonly IEducationMapper _educationMapper;

    public EducationService(
        IEducationRepository educationRepository,
        IEducationMapper educationMapper)
    {
        _educationRepository = educationRepository;
        _educationMapper = educationMapper;
    }

    public async Task<IReadOnlyCollection<EducationResponse>> GetAllAsync()
    {
        var educations =
            await _educationRepository.GetAllAsync();

        return educations
            .Select(_educationMapper.Map)
            .ToList();
    }
}