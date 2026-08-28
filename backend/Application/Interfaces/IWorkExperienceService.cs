using Application.DTOs.Responses;

namespace Application.Interfaces;

public interface IWorkExperienceService
{
    Task<IReadOnlyCollection<WorkExperienceResponse>> GetAllAsync();
}