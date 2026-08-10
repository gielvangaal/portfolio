using Application.DTOs.Responses;
using Application.Interfaces;

namespace Application.Services;

public class HeroService : IHeroService
{
    private readonly IHeroRepository _heroRepository;

    public HeroService(IHeroRepository heroRepository)
    {
        _heroRepository = heroRepository;
    }

    public async Task<HeroResponse?> GetAsync(string language)
    {
        var hero = await _heroRepository.GetAsync(language);

        if (hero is null)
            return null;

        return new HeroResponse
        {
            Name = hero.Name,
            JobTitle = hero.JobTitle,
            CatchPhrase = hero.CatchPhrase,
            Description = hero.Description,
            MediaPath = hero.Media?.Path,
            MediaAltText = hero.Media?.AltText
        };
    }
}