using Application.DTOs.Responses;

namespace Application.Interfaces;

public interface IAboutProfileService
{
    Task<AboutProfileResponse?> GetAsync(string language);
}