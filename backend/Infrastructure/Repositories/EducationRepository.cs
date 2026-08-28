using Application.Interfaces;
using Domain.Entities;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories;

public class EducationRepository : IEducationRepository
{
    private readonly PortfolioDbContext _context;

    public EducationRepository(PortfolioDbContext context)
    {
        _context = context;
    }

    public async Task<IReadOnlyCollection<Education>> GetAllAsync()
    {
        return await _context.Educations
            .AsNoTracking()
            .Include(x => x.Media)
            .Include(x => x.Sections)
            .ThenInclude(x => x.Topics)
            .Include(x => x.Sections)
            .ThenInclude(x => x.Technologies)
            .ThenInclude(x => x.Media)
            .OrderBy(x => x.SortOrder)
            .ToListAsync();
    }
}