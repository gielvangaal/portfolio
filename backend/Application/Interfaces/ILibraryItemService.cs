using Application.DTOs.Responses;

namespace Application.Interfaces;

public interface ILibraryItemService
{
    Task<IReadOnlyCollection<LibraryItemResponse>> GetAllAsync();
}