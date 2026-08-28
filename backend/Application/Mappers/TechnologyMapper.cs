using Application.DTOs.Responses;
using Application.Interfaces;
using Domain.Entities;

namespace Application.Mappers;

public class TechnologyMapper : ITechnologyMapper
{
    public TechnologyResponse Map(Technology technology)
    {
        return new TechnologyResponse
        {
            Id = technology.Id,
            Name = technology.Name,
            Usage = technology.Usage.ToString(),

            Media = technology.Media is null
                ? null
                : new MediaResponse
                {
                    Path = technology.Media.Path,
                    AltText = technology.Media.AltText,
                    Type = technology.Media.Type
                }
        };
    }
}