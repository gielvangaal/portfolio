using Application.DTOs.Responses;
using Application.Interfaces;
using Domain.Enums;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;

[ApiController]
[Route("api/technologies")]
public class TechnologyController : ControllerBase
{
    private readonly ITechnologyService _technologyService;

    public TechnologyController(
        ITechnologyService technologyService)
    {
        _technologyService = technologyService;
    }

    [HttpGet]
    public async Task<ActionResult<IReadOnlyCollection<TechnologyResponse>>> GetAll(
        [FromQuery] TechnologyUsage? usage)
    {
        var technologies =
            await _technologyService.GetAllAsync(usage);

        return Ok(technologies);
    }
}