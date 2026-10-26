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
            .AsSplitQuery()

            .Include(x => x.Organization)
            .ThenInclude(x => x.Media)

            .Include(x => x.Translations)

            .Include(x => x.Credentials)

            .Include(x => x.Sections)
            .ThenInclude(x => x.Translations)

            .Include(x => x.Sections)
            .ThenInclude(x => x.Technologies)
            .ThenInclude(x => x.Media)

            .Include(x => x.Sections)
            .ThenInclude(x => x.Skills)
            .ThenInclude(x => x.Translations)

            .Include(x => x.Sections)
            .ThenInclude(x => x.Tooling)
            .ThenInclude(x => x.Media)

            .OrderBy(x => x.SortOrder)
            .ToListAsync();
    }
}