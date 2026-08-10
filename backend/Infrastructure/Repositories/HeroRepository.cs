using Application.Interfaces;
using Domain.Entities;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories;

public class HeroRepository : IHeroRepository
{
    private readonly PortfolioDbContext _context;

    public HeroRepository(PortfolioDbContext context)
    {
        _context = context;
    }

    public async Task<Hero?> GetAsync(string language)
    {
        return await _context.Heroes
            .Include(x => x.Media)
            .FirstOrDefaultAsync(x => x.Language == language);
    }
}