using Application.DTOs.Responses;
using Domain.Entities;

namespace Application.Interfaces;

public interface ILibraryItemMapper
{
    LibraryItemResponse Map(LibraryItem libraryItem);
}