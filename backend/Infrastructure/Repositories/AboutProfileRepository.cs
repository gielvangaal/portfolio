using Application.Interfaces;
using Domain.Entities;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories;

public class AboutProfileRepository : IAboutProfileRepository
{
    private readonly PortfolioDbContext _context;

    public AboutProfileRepository(PortfolioDbContext context)
    {
        _context = context;
    }

    public async Task<AboutProfile?> GetAsync(string language)
    {
        return await _context.AboutProfiles
            .AsNoTracking()
            .FirstOrDefaultAsync(x => x.Language == language);
    }
}