using Application.DTOs.Responses;
using Application.Interfaces;
using Domain.Entities;

namespace Application.Mappers;

public class AboutProfileMapper : IAboutProfileMapper
{
    public AboutProfileResponse Map(AboutProfile aboutProfile)
    {
        return new AboutProfileResponse
        {
            Description = aboutProfile.Description,
            ImagePath = aboutProfile.ImagePath
        };
    }
}