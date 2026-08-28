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
        services.AddScoped<IAboutProfileRepository, AboutProfileRepository>();
        services.AddScoped<ITechnologyRepository, TechnologyRepository>();
        services.AddScoped<IEducationRepository, EducationRepository>();
        services.AddScoped<ISkillRepository, SkillRepository>();
        services.AddScoped<IToolingRepository, ToolingRepository>();
        services.AddScoped<IWorkExperienceRepository, WorkExperienceRepository>();
            
        // Services
        services.AddScoped<IHeroService, HeroService>();
        services.AddScoped<IPortfolioItemService, PortfolioItemService>();
        services.AddScoped<IAboutProfileService, AboutProfileService>();
        services.AddScoped<ITechnologyService, TechnologyService>();
        services.AddScoped<IEducationService, EducationService>();
        services.AddScoped<ISkillService, SkillService>();
        services.AddScoped<IToolingService, ToolingService>();
        services.AddScoped<IWorkExperienceService, WorkExperienceService>();

        // Mappers
        services.AddScoped<IPortfolioItemMapper, PortfolioItemMapper>();
        services.AddScoped<IAboutProfileMapper, AboutProfileMapper>();
        services.AddScoped<ITechnologyMapper, TechnologyMapper>();
        services.AddScoped<IEducationMapper, EducationMapper>();
        services.AddScoped<ISkillMapper, SkillMapper>();
        services.AddScoped<IToolingMapper, ToolingMapper>();
        services.AddScoped<IWorkExperienceMapper, WorkExperienceMapper>();

        return services;
    }
}