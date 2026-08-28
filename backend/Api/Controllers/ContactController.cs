using Application.DTOs.Responses;
using Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;

[ApiController]
[Route("api/contact")]
public class ContactController : ControllerBase
{
    private readonly IContactService _contactService;

    public ContactController(
        IContactService contactService)
    {
        _contactService = contactService;
    }

    [HttpGet("{language}")]
    public async Task<ActionResult<ContactResponse>> Get(
        string language)
    {
        var contact =
            await _contactService.GetAsync(language);

        if (contact is null)
            return NotFound();

        return Ok(contact);
    }
}