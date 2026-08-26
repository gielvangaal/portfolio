using Application.DTOs.Responses;
using Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;

[ApiController]
[Route("api/about")]
public class AboutProfileController : ControllerBase
{
    private readonly IAboutProfileService _aboutProfileService;

    public AboutProfileController(
        IAboutProfileService aboutProfileService)
    {
        _aboutProfileService = aboutProfileService;
    }

    [HttpGet("{language}")]
    public async Task<ActionResult<AboutProfileResponse>> Get(
        string language)
    {
        var aboutProfile =
            await _aboutProfileService.GetAsync(language);

        if (aboutProfile is null)
            return NotFound();

        return Ok(aboutProfile);
    }
}