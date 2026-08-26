using Domain.Entities;

namespace Application.Interfaces;

public interface IAboutProfileRepository
{
    Task<AboutProfile?> GetAsync(string language);
}