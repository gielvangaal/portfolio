using Application.DTOs.Responses;
using Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;

[ApiController]
[Route("api/work-experience")]
public class WorkExperienceController
    : ControllerBase
{
    private readonly IWorkExperienceService _workExperienceService;

    public WorkExperienceController(
        IWorkExperienceService workExperienceService)
    {
        _workExperienceService = workExperienceService;
    }

    [HttpGet]
    public async Task<ActionResult<IReadOnlyCollection<WorkExperienceResponse>>> GetAll()
    {
        var workExperiences =
            await _workExperienceService.GetAllAsync();

        return Ok(workExperiences);
    }
}