using Application.DTOs.Responses;
using Application.Interfaces;
using Domain.Entities;

namespace Application.Mappers;

public class ContactMapper : IContactMapper
{
    public ContactResponse Map(Contact contact)
    {
        return new ContactResponse
        {
            Name = contact.Name,
            Phone = contact.Phone,
            Email = contact.Email,
            Location = contact.Location,
            GitHubUrl = contact.GitHubUrl,
            LinkedInUrl = contact.LinkedInUrl,
            InstagramUrl = contact.InstagramUrl,
            SpotifyUrl = contact.SpotifyUrl,
            CreditText = contact.CreditText
        };
    }
}