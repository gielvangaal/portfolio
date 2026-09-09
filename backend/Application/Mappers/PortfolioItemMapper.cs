using Application.DTOs.Responses;
using Application.Interfaces;
using Domain.Entities;
using Domain.Enums;

namespace Application.Mappers;

public class PortfolioItemMapper : IPortfolioItemMapper
{
    private readonly ITechnologyMapper _technologyMapper;
    private readonly ISkillMapper _skillMapper;
    private readonly IToolingMapper _toolingMapper;

    public PortfolioItemMapper(
        ITechnologyMapper technologyMapper,
        ISkillMapper skillMapper,
        IToolingMapper toolingMapper)
    {
        _technologyMapper = technologyMapper;
        _skillMapper = skillMapper;
        _toolingMapper = toolingMapper;
    }

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
                .OrderBy(x => x.Name)
                .Select(x => x.Name)
                .ToList(),

            Technologies = portfolioItem.Technologies
                .OrderBy(x => x.Name)
                .Select(_technologyMapper.Map)
                .ToList(),

            Skills = portfolioItem.Skills
                .OrderBy(x => x.Name)
                .Select(_skillMapper.Map)
                .ToList(),

            Tooling = portfolioItem.Tooling
                .OrderBy(x => x.Name)
                .Select(_toolingMapper.Map)
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

    public PortfolioCardResponse MapCard(PortfolioItem portfolioItem)
    {
        return new PortfolioCardResponse
        {
            Slug = portfolioItem.Slug,
            Title = portfolioItem.Title,
            CardDescription = portfolioItem.CardDescription,
            ProjectDate = portfolioItem.ProjectDate,
            ProjectType = MapProjectType(
                portfolioItem.ProjectType,
                portfolioItem.Language
            ),
            Role = portfolioItem.Role,

            Categories = portfolioItem.Categories
                .OrderBy(x => x.Name)
                .Select(x => x.Name)
                .ToList(),

            Technologies = portfolioItem.Technologies
                .OrderBy(x => x.Name)
                .Select(_technologyMapper.Map)
                .ToList(),

            Skills = portfolioItem.Skills
                .OrderBy(x => x.Name)
                .Select(_skillMapper.Map)
                .ToList(),

            Tooling = portfolioItem.Tooling
                .OrderBy(x => x.Name)
                .Select(_toolingMapper.Map)
                .ToList(),

            PrimaryImageUrl = portfolioItem.Media
                .Where(x => x.Role == MediaRole.Primary)
                .OrderBy(x => x.SortOrder)
                .Select(x => x.Media.Path)
                .FirstOrDefault()
        };
    }

    private static string MapProjectType(
        ProjectType projectType,
        string language)
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