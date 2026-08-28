using Application.DTOs.Responses;
using Application.Interfaces;

namespace Application.Services;

public class LibraryItemService
    : ILibraryItemService
{
    private readonly ILibraryItemRepository _libraryItemRepository;
    private readonly ILibraryItemMapper _libraryItemMapper;

    public LibraryItemService(
        ILibraryItemRepository libraryItemRepository,
        ILibraryItemMapper libraryItemMapper)
    {
        _libraryItemRepository = libraryItemRepository;
        _libraryItemMapper = libraryItemMapper;
    }

    public async Task<IReadOnlyCollection<LibraryItemResponse>> GetAllAsync()
    {
        var libraryItems =
            await _libraryItemRepository.GetAllAsync();

        return libraryItems
            .Select(_libraryItemMapper.Map)
            .ToList();
    }
}