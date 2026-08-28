using Application.Interfaces;
using Domain.Entities;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories;

public class SkillRepository : ISkillRepository
{
    private readonly PortfolioDbContext _context;

    public SkillRepository(PortfolioDbContext context)
    {
        _context = context;
    }

    public async Task<IReadOnlyCollection<Skill>> GetAllAsync()
    {
        return await _context.Skills
            .AsNoTracking()
            .OrderBy(x => x.Name)
            .ToListAsync();
    }
}