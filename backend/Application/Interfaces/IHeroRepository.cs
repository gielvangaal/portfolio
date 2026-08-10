using Domain.Entities;

namespace Application.Interfaces;

public interface IHeroRepository
{
    Task<Hero?> GetAsync(string language);
}