using Domain.Entities;

namespace Application.Interfaces;

public interface IWorkExperienceRepository
{
    Task<IReadOnlyCollection<WorkExperience>> GetAllAsync();
}