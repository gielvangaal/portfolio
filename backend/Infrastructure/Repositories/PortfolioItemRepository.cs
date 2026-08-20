using Application.Interfaces;
using Domain.Entities;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories;

public class PortfolioItemRepository : IPortfolioItemRepository
{
    private readonly PortfolioDbContext _context;

    public PortfolioItemRepository(PortfolioDbContext context)
    {
        _context = context;
    }

    public async Task<PortfolioItem?> GetAsync(
        string slug,
        string language)
    {
        return await _context.PortfolioItems
            .AsNoTracking()
            .Include(x => x.Categories)
            .Include(x => x.Technologies)
            .Include(x => x.Media)
            .ThenInclude(x => x.Media)
            .FirstOrDefaultAsync(x =>
                x.Slug == slug &&
                x.Language == language);
    }
    
    public async Task<IReadOnlyCollection<PortfolioItem>> GetAllAsync(
        string language)
    {
        return await _context.PortfolioItems
            .AsNoTracking()
            .Where(x => x.Language == language)
            .OrderByDescending(x => x.ProjectDate)
            .Include(x => x.Categories)
            .Include(x => x.Technologies)
            .Include(x => x.Media)
            .ThenInclude(x => x.Media)
            .ToListAsync();
    }
}