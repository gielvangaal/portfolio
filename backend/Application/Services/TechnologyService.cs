using Application.DTOs.Responses;
using Application.Interfaces;
using Domain.Enums;

namespace Application.Services;

public class TechnologyService : ITechnologyService
{
    private readonly ITechnologyRepository _technologyRepository;
    private readonly ITechnologyMapper _technologyMapper;

    public TechnologyService(
        ITechnologyRepository technologyRepository,
        ITechnologyMapper technologyMapper)
    {
        _technologyRepository = technologyRepository;
        _technologyMapper = technologyMapper;
    }

    public async Task<IReadOnlyCollection<TechnologyResponse>> GetAllAsync(
        TechnologyUsage? usage)
    {
        var technologies =
            await _technologyRepository.GetAllAsync(usage);

        return technologies
            .Select(_technologyMapper.Map)
            .ToList();
    }
}