using Application.DTOs.Responses;
using Domain.Entities;

namespace Application.Interfaces;

public interface IAboutProfileMapper
{
    AboutProfileResponse Map(AboutProfile aboutProfile);
}