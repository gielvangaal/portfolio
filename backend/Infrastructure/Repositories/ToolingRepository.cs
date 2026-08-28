using Application.Interfaces;
using Domain.Entities;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories;

public class ToolingRepository : IToolingRepository
{
    private readonly PortfolioDbContext _context;

    public ToolingRepository(PortfolioDbContext context)
    {
        _context = context;
    }

    public async Task<IReadOnlyCollection<Tooling>> GetAllAsync()
    {
        return await _context.Tooling
            .AsNoTracking()
            .Include(x => x.Media)
            .OrderBy(x => x.Name)
            .ToListAsync();
    }
}