using Application.DTOs.Responses;
using Domain.Entities;

namespace Application.Interfaces;

public interface IToolingMapper
{
    ToolingResponse Map(Tooling tooling);
}