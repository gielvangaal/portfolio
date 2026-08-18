using Application.DTOs.Responses;
using Application.Interfaces;
using Domain.Entities;

namespace Application.Mappers;

public class PortfolioItemMapper : IPortfolioItemMapper
{
    public PortfolioItemResponse Map(PortfolioItem portfolioItem)
    {
        return new PortfolioItemResponse
        {
            Slug = portfolioItem.Slug,
            Title = portfolioItem.Title,
            CardDescription = portfolioItem.CardDescription,
            Description = portfolioItem.Description,
            GitHubUrl = portfolioItem.GitHubUrl,
            LiveSiteUrl = portfolioItem.LiveSiteUrl,

            Categories = portfolioItem.Categories
                .Select(x => x.Name)
                .ToList(),

            Technologies = portfolioItem.Technologies
                .Select(x => x.Name)
                .ToList(),

            Media = portfolioItem.Media
                .OrderBy(x => x.SortOrder)
                .Select(x => new PortfolioMediaResponse
                {
                    Path = x.Media.Path,
                    AltText = x.Media.AltText,
                    Role = x.Role,
                    SortOrder = x.SortOrder
                })
                .ToList()
        };
    }
}