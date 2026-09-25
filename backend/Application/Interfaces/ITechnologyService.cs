using Application.DTOs.Responses;
using Domain.Enums;

namespace Application.Interfaces;

public interface ITechnologyService
{
    Task<IReadOnlyCollection<TechnologyResponse>> GetAllAsync(
        CapabilityUsage? usage);
}