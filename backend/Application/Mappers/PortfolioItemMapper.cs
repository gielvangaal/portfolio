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
            ProjectType = MapProjectType(
                portfolioItem.ProjectType,
                portfolioItem.Language
            ),
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
            ProjectType = MapProjectType(
                item.ProjectType,
                item.Language
            ),
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

    private static string MapProjectType(ProjectType projectType, string language)
    {
        return (projectType, language) switch
        {
            (ProjectType.Personal, "nl") => "Persoonlijk",
            (ProjectType.Education, "nl") => "Opleiding",
            (ProjectType.Professional, "nl") => "Professioneel",

            (ProjectType.Personal, _) => "Personal",
            (ProjectType.Education, _) => "Education",
            (ProjectType.Professional, _) => "Professional",

            _ => projectType.ToString()
        };
    }
}