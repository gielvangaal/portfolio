using Application.DTOs.Responses;

namespace Application.Interfaces;

public interface IPortfolioItemService
{
    Task<PortfolioItemResponse?> GetAsync(string slug, string language);
}