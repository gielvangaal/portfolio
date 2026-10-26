using Application.DTOs.Responses;
using Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;

[ApiController]
[Route("api/skills")]
public class SkillController : ControllerBase
{
    private readonly ISkillService _skillService;

    public SkillController(ISkillService skillService)
    {
        _skillService = skillService;
    }

    [HttpGet]
    public async Task<ActionResult<IReadOnlyCollection<SkillResponse>>> GetAll(
        [FromQuery] string language = "nl")
    {
        var skills = await _skillService.GetAllAsync(language);

        return Ok(skills);
    }
}