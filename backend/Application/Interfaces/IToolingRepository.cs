using Domain.Entities;

namespace Application.Interfaces;

public interface IToolingRepository
{
    Task<IReadOnlyCollection<Tooling>> GetAllAsync();
}