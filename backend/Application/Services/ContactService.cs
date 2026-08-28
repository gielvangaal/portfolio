using Application.DTOs.Responses;
using Application.Interfaces;

namespace Application.Services;

public class ContactService : IContactService
{
    private readonly IContactRepository _contactRepository;
    private readonly IContactMapper _contactMapper;

    public ContactService(
        IContactRepository contactRepository,
        IContactMapper contactMapper)
    {
        _contactRepository = contactRepository;
        _contactMapper = contactMapper;
    }

    public async Task<ContactResponse?> GetAsync(string language)
    {
        var contact =
            await _contactRepository.GetAsync(language);

        if (contact is null)
            return null;

        return _contactMapper.Map(contact);
    }
}