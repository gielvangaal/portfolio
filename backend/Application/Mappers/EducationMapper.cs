using Application.DTOs.Responses;
using Application.Interfaces;
using Domain.Entities;

namespace Application.Mappers;

public class EducationMapper : IEducationMapper
{
    private readonly ITechnologyMapper _technologyMapper;

    public EducationMapper(ITechnologyMapper technologyMapper)
    {
        _technologyMapper = technologyMapper;
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

                    Topics = section.Topics
                        .OrderBy(x => x.SortOrder)
                        .Select(topic => new EducationTopicResponse
                        {
                            Id = topic.Id,
                            Name = topic.Name
                        })
                        .ToList()
                })
                .ToList()
        };
    }
}