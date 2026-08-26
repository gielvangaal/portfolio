using Application.DTOs.Responses;
using Application.Interfaces;

namespace Application.Services;

public class AboutProfileService : IAboutProfileService
{
    private readonly IAboutProfileRepository _aboutProfileRepository;
    private readonly IAboutProfileMapper _aboutProfileMapper;

    public AboutProfileService(
        IAboutProfileRepository aboutProfileRepository,
        IAboutProfileMapper aboutProfileMapper)
    {
        _aboutProfileRepository = aboutProfileRepository;
        _aboutProfileMapper = aboutProfileMapper;
    }

    public async Task<AboutProfileResponse?> GetAsync(string language)
    {
        var aboutProfile =
            await _aboutProfileRepository.GetAsync(language);

        if (aboutProfile is null)
            return null;

        return _aboutProfileMapper.Map(aboutProfile);
    }
}