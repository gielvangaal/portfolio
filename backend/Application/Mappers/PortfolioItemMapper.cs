using Application.DTOs.Responses;
using Application.Interfaces;
using Domain.Entities;
using Domain.Enums;

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

            ProjectDate = portfolioItem.ProjectDate,
            ProjectType = portfolioItem.ProjectType,
            Role = portfolioItem.Role,
            TeamSize = portfolioItem.TeamSize,
            Duration = portfolioItem.Duration,

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
    
    public PortfolioCardResponse MapCard(PortfolioItem item)
    {
        return new PortfolioCardResponse
        {
            Slug = item.Slug,
            Title = item.Title,
            CardDescription = item.CardDescription,
            ProjectDate = item.ProjectDate,
            ProjectType = item.ProjectType,
            Role = item.Role,

            Categories = item.Categories
                .Select(x => x.Name)
                .ToList(),

            Technologies = item.Technologies
                .Select(x => x.Name)
                .ToList(),

            PrimaryImageUrl = item.Media
                .Where(x => x.Role == MediaRole.Primary)
                .OrderBy(x => x.SortOrder)
                .Select(x => x.Media.Path)
                .FirstOrDefault()
        };
    }
}