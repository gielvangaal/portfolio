using Domain.Entities;

namespace Application.Interfaces;

public interface ILibraryItemRepository
{
    Task<IReadOnlyCollection<LibraryItem>> GetAllAsync();
}