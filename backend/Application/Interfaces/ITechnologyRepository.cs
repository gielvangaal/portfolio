using Domain.Entities;
using Domain.Enums;

namespace Application.Interfaces;

public interface ITechnologyRepository
{
    Task<IReadOnlyCollection<Technology>> GetAllAsync(
        TechnologyUsage? usage);
}