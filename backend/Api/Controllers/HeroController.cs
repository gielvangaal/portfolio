using Application.DTOs.Responses;
using Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class HeroController : ControllerBase
{
    private readonly IHeroService _heroService;

    public HeroController(IHeroService heroService)
    {
        _heroService = heroService;
    }

    [HttpGet("{language}")]
    public async Task<ActionResult<HeroResponse>> Get(string language)
    {
        var hero = await _heroService.GetAsync(language);

        if (hero is null)
            return NotFound();

        return Ok(hero);
    }
}