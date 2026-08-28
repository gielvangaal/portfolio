using Application.DTOs.Responses;
using Domain.Entities;

namespace Application.Interfaces;

public interface IEducationMapper
{
    EducationResponse Map(Education education);
}