using Application.Interfaces;
using Domain.Entities;
using Domain.Enums;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories;

public class TechnologyRepository : ITechnologyRepository
{
    private readonly PortfolioDbContext _context;

    public TechnologyRepository(PortfolioDbContext context)
    {
        _context = context;
    }

    public async Task<IReadOnlyCollection<Technology>> GetAllAsync(
        CapabilityUsage? usage)
    {
        var query = _context.Technologies
            .AsNoTracking()
            .Include(x => x.Media)
            .AsQueryable();

        if (usage.HasValue)
        {
            query = query.Where(x => x.Usage == usage.Value);
        }

        return await query
            .OrderBy(x => x.Name)
            .ToListAsync();
    }
}