using Application.DTOs.Responses;
using Domain.Entities;

namespace Application.Interfaces;

public interface IContactMapper
{
    ContactResponse Map(Contact contact);
}