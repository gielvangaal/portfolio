using Domain.Entities;

namespace Application.Interfaces;

public interface IPortfolioItemRepository
{
    Task<PortfolioItem?> GetAsync(string slug, string language);
    
    Task<IReadOnlyCollection<PortfolioItem>> GetAllAsync(string language);
}