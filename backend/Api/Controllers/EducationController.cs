using Application.DTOs.Responses;
using Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;

[ApiController]
[Route("api/education")]
public class EducationController : ControllerBase
{
    private readonly IEducationService _educationService;

    public EducationController(
        IEducationService educationService)
    {
        _educationService = educationService;
    }

    [HttpGet]
    public async Task<ActionResult<IReadOnlyCollection<EducationResponse>>> GetAll()
    {
        var educations =
            await _educationService.GetAllAsync();

        return Ok(educations);
    }
}