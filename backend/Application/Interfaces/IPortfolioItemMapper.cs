using Application.DTOs.Responses;
using Domain.Entities;

namespace Application.Interfaces;

public interface IPortfolioItemMapper
{
    PortfolioItemResponse Map(PortfolioItem portfolioItem);
}