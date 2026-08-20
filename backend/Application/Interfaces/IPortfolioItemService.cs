using Application.DTOs.Responses;

namespace Application.Interfaces;

public interface IPortfolioItemService
{
    Task<IReadOnlyCollection<PortfolioCardResponse>> GetCardsAsync(
        string language);

    Task<PortfolioItemResponse?> GetAsync(
        string slug,
        string language);
}