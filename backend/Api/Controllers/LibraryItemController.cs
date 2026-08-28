using Application.DTOs.Responses;
using Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;

[ApiController]
[Route("api/library")]
public class LibraryItemController
    : ControllerBase
{
    private readonly ILibraryItemService _libraryItemService;

    public LibraryItemController(
        ILibraryItemService libraryItemService)
    {
        _libraryItemService = libraryItemService;
    }

    [HttpGet]
    public async Task<ActionResult<IReadOnlyCollection<LibraryItemResponse>>> GetAll()
    {
        var libraryItems =
            await _libraryItemService.GetAllAsync();

        return Ok(libraryItems);
    }
}