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
            Program = education.Program,
            StartYear = education.StartYear,
            EndYear = education.EndYear,

            Organization = new OrganizationResponse
            {
                Id = education.Organization.Id,
                Name = education.Organization.Name,
                Type = education.Organization.Type.ToString(),
                WebsiteUrl = education.Organization.WebsiteUrl,

                Media = education.Organization.Media is null
                    ? null
                    : new MediaResponse
                    {
                        Path = education.Organization.Media.Path,
                        AltText = education.Organization.Media.AltText,
                        Type = education.Organization.Media.Type
                    }
            },

            Credentials = education.Credentials
                .Select(x => new CredentialResponse
                {
                    Id = x.Id,
                    Name = x.Name,
                    Type = x.Type.ToString(),
                    Status = x.Status.ToString(),
                    Year = x.Year,
                    CredentialUrl = x.CredentialUrl,
                    DocumentUrl = x.DocumentUrl
                })
                .ToList(),

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