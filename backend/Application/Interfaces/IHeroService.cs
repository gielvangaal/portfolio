using Application.DTOs.Responses;

namespace Application.Interfaces;

public interface IHeroService
{
    Task<HeroResponse?> GetAsync(string language);
}