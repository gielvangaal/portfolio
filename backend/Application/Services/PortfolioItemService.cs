using Application.DTOs.Responses;
using Application.Interfaces;

namespace Application.Services;

public class PortfolioItemService : IPortfolioItemService
{
    private readonly IPortfolioItemRepository _portfolioItemRepository;
    private readonly IPortfolioItemMapper _portfolioItemMapper;

    public PortfolioItemService(
        IPortfolioItemRepository portfolioItemRepository,
        IPortfolioItemMapper portfolioItemMapper)
    {
        _portfolioItemRepository = portfolioItemRepository;
        _portfolioItemMapper = portfolioItemMapper;
    }

    public async Task<PortfolioItemResponse?> GetAsync(
        string slug,
        string language)
    {
        var portfolioItem =
            await _portfolioItemRepository.GetAsync(slug, language);

        if (portfolioItem is null)
            return null;

        return _portfolioItemMapper.Map(portfolioItem);
    }

    public async Task<IReadOnlyCollection<PortfolioCardResponse>> GetCardsAsync(
        string language)
    {
        var portfolioItems =
            await _portfolioItemRepository.GetAllAsync(language);

        return portfolioItems
            .Select(_portfolioItemMapper.MapCard)
            .ToList();
    }
}