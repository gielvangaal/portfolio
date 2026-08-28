using Application.DTOs.Responses;
using Application.Interfaces;
using Domain.Entities;

namespace Application.Mappers;

public class LibraryItemMapper
    : ILibraryItemMapper
{
    private readonly ITechnologyMapper _technologyMapper;
    private readonly ISkillMapper _skillMapper;
    private readonly IToolingMapper _toolingMapper;

    public LibraryItemMapper(
        ITechnologyMapper technologyMapper,
        ISkillMapper skillMapper,
        IToolingMapper toolingMapper)
    {
        _technologyMapper = technologyMapper;
        _skillMapper = skillMapper;
        _toolingMapper = toolingMapper;
    }

    public LibraryItemResponse Map(
        LibraryItem libraryItem)
    {
        return new LibraryItemResponse
        {
            Id = libraryItem.Id,
            Title = libraryItem.Title,
            Creator = libraryItem.Creator,
            Type = libraryItem.Type.ToString(),

            Media = libraryItem.Media is null
                ? null
                : new MediaResponse
                {
                    Path = libraryItem.Media.Path,
                    AltText = libraryItem.Media.AltText,
                    Type = libraryItem.Media.Type
                },

            Technologies = libraryItem.Technologies
                .OrderBy(x => x.Name)
                .Select(_technologyMapper.Map)
                .ToList(),

            Skills = libraryItem.Skills
                .OrderBy(x => x.Name)
                .Select(_skillMapper.Map)
                .ToList(),

            Tooling = libraryItem.Tooling
                .OrderBy(x => x.Name)
                .Select(_toolingMapper.Map)
                .ToList()
        };
    }
}