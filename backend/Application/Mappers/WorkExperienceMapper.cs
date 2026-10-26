using Application.DTOs.Responses;
using Application.Interfaces;
using Domain.Entities;

namespace Application.Mappers;

public class WorkExperienceMapper
    : IWorkExperienceMapper
{
    private readonly ITechnologyMapper _technologyMapper;
    private readonly ISkillMapper _skillMapper;
    private readonly IToolingMapper _toolingMapper;

    public WorkExperienceMapper(
        ITechnologyMapper technologyMapper,
        ISkillMapper skillMapper,
        IToolingMapper toolingMapper)
    {
        _technologyMapper = technologyMapper;
        _skillMapper = skillMapper;
        _toolingMapper = toolingMapper;
    }

    public WorkExperienceResponse Map(
        WorkExperience workExperience, string language)
    {
        return new WorkExperienceResponse
        {
            Id = workExperience.Id,
            Role = workExperience.Translations.FirstOrDefault(x => x.Language == language)?.Role
                ?? workExperience.Translations.FirstOrDefault(x => x.Language == "nl")?.Role
                ?? string.Empty,
            StartYear = workExperience.StartYear,
            EndYear = workExperience.EndYear,

            Organization = new OrganizationResponse
            {
                Id = workExperience.Organization.Id,
                Name = workExperience.Organization.Name,
                Type = workExperience.Organization.Type.ToString(),
                WebsiteUrl = workExperience.Organization.WebsiteUrl,

                Media = workExperience.Organization.Media is null
                    ? null
                    : new MediaResponse
                    {
                        Path = workExperience.Organization.Media.Path,
                        AltText = workExperience.Organization.Media.AltText,
                        Type = workExperience.Organization.Media.Type
                    }
            },

            Responsibilities = workExperience.Responsibilities
                .OrderBy(x => x.SortOrder)
                .Select(x => x.Translations.FirstOrDefault(t => t.Language == language)?.Description
                    ?? x.Translations.FirstOrDefault(t => t.Language == "nl")?.Description
                    ?? string.Empty)
                .ToList(),

            Technologies = workExperience.Technologies
                .OrderBy(x => x.Name)
                .Select(_technologyMapper.Map)
                .ToList(),

            Skills = workExperience.Skills
                .OrderBy(x => x.Key)
                .Select(x => _skillMapper.Map(x, language))
                .ToList(),

            Tooling = workExperience.Tooling
                .OrderBy(x => x.Name)
                .Select(_toolingMapper.Map)
                .ToList()
        };
    }
}