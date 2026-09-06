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

            .Include(x => x.Organization)
            .ThenInclude(x => x.Media)

            .Include(x => x.Responsibilities)

            .Include(x => x.Technologies)
            .ThenInclude(x => x.Media)

            .Include(x => x.Skills)

            .Include(x => x.Tooling)
            .ThenInclude(x => x.Media)

            .OrderBy(x => x.SortOrder)
            .ToListAsync();
    }
}