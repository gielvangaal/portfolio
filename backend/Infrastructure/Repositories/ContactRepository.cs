using Application.Interfaces;
using Domain.Entities;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories;

public class ContactRepository : IContactRepository
{
    private readonly PortfolioDbContext _context;

    public ContactRepository(PortfolioDbContext context)
    {
        _context = context;
    }

    public async Task<Contact?> GetAsync(string language)
    {
        return await _context.Contacts
            .AsNoTracking()
            .FirstOrDefaultAsync(x => x.Language == language);
    }
}