using Application.DTOs.Responses;

namespace Application.Interfaces;

public interface IEducationService
{
    Task<IReadOnlyCollection<EducationResponse>> GetAllAsync();
}