using Application.DTOs.Responses;
using Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;

[ApiController]
[Route("api/tooling")]
public class ToolingController : ControllerBase
{
    private readonly IToolingService _toolingService;

    public ToolingController(IToolingService toolingService)
    {
        _toolingService = toolingService;
    }

    [HttpGet]
    public async Task<ActionResult<IReadOnlyCollection<ToolingResponse>>> GetAll()
    {
        var tooling = await _toolingService.GetAllAsync();

        return Ok(tooling);
    }
}