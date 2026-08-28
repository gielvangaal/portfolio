using Application.DTOs.Responses;
using Domain.Entities;

namespace Application.Interfaces;

public interface ITechnologyMapper
{
    TechnologyResponse Map(Technology technology);
}