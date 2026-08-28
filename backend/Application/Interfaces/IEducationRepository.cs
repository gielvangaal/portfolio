using Domain.Entities;

namespace Application.Interfaces;

public interface IEducationRepository
{
    Task<IReadOnlyCollection<Education>> GetAllAsync();
}