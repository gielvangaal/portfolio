using Application.DTOs.Responses;
using Application.Interfaces;
using Domain.Entities;

namespace Application.Mappers;

public class ToolingMapper : IToolingMapper
{
    public ToolingResponse Map(Tooling tooling)
    {
        return new ToolingResponse
        {
            Id = tooling.Id,
            Name = tooling.Name,

            Media = tooling.Media is null
                ? null
                : new MediaResponse
                {
                    Path = tooling.Media.Path,
                    AltText = tooling.Media.AltText,
                    Type = tooling.Media.Type
                }
        };
    }
}