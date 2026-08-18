using Application.DTOs.Responses;
using Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;

[ApiController]
[Route("api/portfolio")]
public class PortfolioItemController : ControllerBase
{
    private readonly IPortfolioItemService _portfolioItemService;

    public PortfolioItemController(
        IPortfolioItemService portfolioItemService)
    {
        _portfolioItemService = portfolioItemService;
    }

    [HttpGet("{slug}/{language}")]
    public async Task<ActionResult<PortfolioItemResponse>> Get(
        string slug,
        string language)
    {
        var portfolioItem =
            await _portfolioItemService.GetAsync(slug, language);

        if (portfolioItem is null)
            return NotFound();

        return Ok(portfolioItem);
    }
}