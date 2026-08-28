using Application.Interfaces;
using Domain.Entities;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories;

public class LibraryItemRepository
    : ILibraryItemRepository
{
    private readonly PortfolioDbContext _context;

    public LibraryItemRepository(
        PortfolioDbContext context)
    {
        _context = context;
    }

    public async Task<IReadOnlyCollection<LibraryItem>> GetAllAsync()
    {
        return await _context.LibraryItems
            .AsNoTracking()

            .Include(x => x.Media)

            .Include(x => x.Technologies)
            .ThenInclude(x => x.Media)

            .Include(x => x.Skills)

            .Include(x => x.Tooling)
            .ThenInclude(x => x.Media)

            .OrderBy(x => x.SortOrder)
            .ToListAsync();
    }
}