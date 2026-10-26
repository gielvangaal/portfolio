using Application.Interfaces;
using Domain.Entities;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories;

public class WorkExperienceRepository
    : IWorkExperienceRepository
{
    private readonly PortfolioDbContext _context;

    public WorkExperienceRepository(
        PortfolioDbContext context)
    {
        _context = context;
    }

    public async Task<IReadOnlyCollection<WorkExperience>> GetAllAsync()
    {
        return await _context.WorkExperiences
            .AsNoTracking()
            .AsSplitQuery()

            .Include(x => x.Organization)
            .ThenInclude(x => x.Media)

            .Include(x => x.Translations)

            .Include(x => x.Responsibilities)
            .ThenInclude(x => x.Translations)

            .Include(x => x.Technologies)
            .ThenInclude(x => x.Media)

            .Include(x => x.Skills)
            .ThenInclude(x => x.Translations)

            .Include(x => x.Tooling)
            .ThenInclude(x => x.Media)

            .OrderBy(x => x.SortOrder)
            .ToListAsync();
    }
}