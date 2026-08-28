using Application.DTOs.Responses;
using Domain.Entities;

namespace Application.Interfaces;

public interface IWorkExperienceMapper
{
    WorkExperienceResponse Map(WorkExperience workExperience);
}