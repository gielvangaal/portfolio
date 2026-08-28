using Application.DTOs.Responses;
using Application.Interfaces;

namespace Application.Services;

public class ToolingService : IToolingService
{
    private readonly IToolingRepository _toolingRepository;
    private readonly IToolingMapper _toolingMapper;

    public ToolingService(
        IToolingRepository toolingRepository,
        IToolingMapper toolingMapper)
    {
        _toolingRepository = toolingRepository;
        _toolingMapper = toolingMapper;
    }

    public async Task<IReadOnlyCollection<ToolingResponse>> GetAllAsync()
    {
        var tooling = await _toolingRepository.GetAllAsync();

        return tooling
            .Select(_toolingMapper.Map)
            .ToList();
    }
}