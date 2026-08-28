using Application.DTOs.Responses;

namespace Application.Interfaces;

public interface IContactService
{
    Task<ContactResponse?> GetAsync(string language);
}