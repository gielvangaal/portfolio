using Application.DTOs.Responses;

namespace Application.Interfaces;

public interface IToolingService
{
    Task<IReadOnlyCollection<ToolingResponse>> GetAllAsync();
}