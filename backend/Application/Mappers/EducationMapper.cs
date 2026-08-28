using Application.DTOs.Responses;
using Application.Interfaces;
using Domain.Entities;

namespace Application.Mappers;

public class EducationMapper : IEducationMapper
{
    private readonly ITechnologyMapper _technologyMapper;
    private readonly ISkillMapper _skillMapper;
    private readonly IToolingMapper _toolingMapper;

    public EducationMapper(
        ITechnologyMapper technologyMapper,
        ISkillMapper skillMapper,
        IToolingMapper toolingMapper)
    {
        _technologyMapper = technologyMapper;
        _skillMapper = skillMapper;
        _toolingMapper = toolingMapper;
    }

    public EducationResponse Map(Education education)
    {
        return new EducationResponse
        {
            Id = education.Id,
            Institution = education.Institution,
            Program = education.Program,
            StartYear = education.StartYear,
            EndYear = education.EndYear,

            Media = education.Media is null
                ? null
                : new MediaResponse
                {
                    Path = education.Media.Path,
                    AltText = education.Media.AltText,
                    Type = education.Media.Type
                },

            Sections = education.Sections
                .OrderBy(x => x.SortOrder)
                .Select(section => new EducationSectionResponse
                {
                    Id = section.Id,
                    Title = section.Title,

                    Technologies = section.Technologies
                        .OrderBy(x => x.Name)
                        .Select(_technologyMapper.Map)
                        .ToList(),

                    Skills = section.Skills
                        .OrderBy(x => x.Name)
                        .Select(_skillMapper.Map)
                        .ToList(),

                    Tooling = section.Tooling
                        .OrderBy(x => x.Name)
                        .Select(_toolingMapper.Map)
                        .ToList()
                })
                .ToList()
        };
    }
}