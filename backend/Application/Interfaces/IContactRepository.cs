using Domain.Entities;

namespace Application.Interfaces;

public interface IContactRepository
{
    Task<Contact?> GetAsync(string language);
}