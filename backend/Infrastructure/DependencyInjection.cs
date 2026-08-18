using Application.Interfaces;
using Application.Mappers;
using Application.Services;
using Infrastructure.Data;
using Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(
        this IServiceCollection services,
        IConfiguration configuration)
    {
        // Database
        services.AddDbContext<PortfolioDbContext>(options =>
            options.UseMySql(
                configuration.GetConnectionString("DefaultConnection"),
                ServerVersion.AutoDetect(
                    configuration.GetConnectionString("DefaultConnection"))
            ));

        // Repositories
        services.AddScoped<IHeroRepository, HeroRepository>();
        services.AddScoped<IPortfolioItemRepository, PortfolioItemRepository>();

        // Services
        services.AddScoped<IHeroService, HeroService>();
        services.AddScoped<IPortfolioItemService, PortfolioItemService>();

        // Mappers
        services.AddScoped<IPortfolioItemMapper, PortfolioItemMapper>();

        return services;
    }
}