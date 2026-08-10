using Domain.Entities;
using Domain.Enums;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data;

public static class DatabaseSeeder
{
    public static async Task SeedAsync(PortfolioDbContext context)
    {
        await SeedHeroAsync(context);
    }

    private static async Task SeedHeroAsync(PortfolioDbContext context)
    {
        if (await context.Heroes.AnyAsync())
            return;

        // Media
        var heroMedia = new Media
        {
            Path = "/media/giel.webp",
            AltText = "Giel van Gaal",
            Type = MediaType.Image
        };

        context.Media.Add(heroMedia);

        await context.SaveChangesAsync();

        // Hero
        context.Heroes.AddRange(
            new Hero
            {
                Language = "en",
                Name = "Giel van Gaal",
                JobTitle = "Junior Programmer & Software Developer",
                CatchPhrase = "Frontend • Backend • DevOps | Strong in project management, UX and getting-it-done.",
                Description = "Welcome to my portfolio.",
                MediaId = heroMedia.Id
            },

            new Hero
            {
                Language = "nl",
                Name = "Giel van Gaal",
                JobTitle = "Junior programmeur & softwareontwikkelaar",
                CatchPhrase = "Frontend • Backend • DevOps | Sterk in projectmanagement, UX en getting-it-done.",
                Description = "De wereld vooruit helpen",
                MediaId = heroMedia.Id
            });

        await context.SaveChangesAsync();
    }
}