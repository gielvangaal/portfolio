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
        WorkExperience workExperience)
    {
        return new WorkExperienceResponse
        {
            Id = workExperience.Id,
            Company = workExperience.Company,
            Role = workExperience.Role,
            StartYear = workExperience.StartYear,
            EndYear = workExperience.EndYear,

            Media = workExperience.Media is null
                ? null
                : new MediaResponse
                {
                    Path = workExperience.Media.Path,
                    AltText = workExperience.Media.AltText,
                    Type = workExperience.Media.Type
                },

            Responsibilities = workExperience.Responsibilities
                .OrderBy(x => x.SortOrder)
                .Select(x => x.Description)
                .ToList(),

            Technologies = workExperience.Technologies
                .OrderBy(x => x.Name)
                .Select(_technologyMapper.Map)
                .ToList(),

            Skills = workExperience.Skills
                .OrderBy(x => x.Name)
                .Select(_skillMapper.Map)
                .ToList(),

            Tooling = workExperience.Tooling
                .OrderBy(x => x.Name)
                .Select(_toolingMapper.Map)
                .ToList()
        };
    }
}