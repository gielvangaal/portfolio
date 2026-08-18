using Domain.Entities;
using Domain.Enums;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data;

public static class DatabaseSeeder
{
    public static async Task SeedAsync(PortfolioDbContext context)
    {
        // Seed alle onderdelen van de database.
        // Nieuwe seed-methodes kun je hier later simpel onder toevoegen.
        await SeedHeroAsync(context);
        await SeedPortfolioAsync(context);
    }

    private static async Task SeedHeroAsync(PortfolioDbContext context)
    {
        // Als er al Hero-data bestaat, niets opnieuw toevoegen.
        if (await context.Heroes.AnyAsync())
            return;

        // -------------------------
        // MEDIA
        // -------------------------
        // Media staat los in een eigen tabel.
        // De Hero verwijst daarna via MediaId naar deze afbeelding.
        var heroMedia = new Media
        {
            Path = "/media/giel.webp",
            AltText = "Giel van Gaal",
            Type = MediaType.Image
        };

        context.Media.Add(heroMedia);

        // Eerst opslaan zodat heroMedia.Id beschikbaar is.
        await context.SaveChangesAsync();

        // -------------------------
        // HERO
        // -------------------------
        // Eén record per taal.
        context.Heroes.AddRange(
            new Hero
            {
                Language = "en",
                Name = "Giel van Gaal",
                JobTitle = "Junior Programmer & Software Developer",
                CatchPhrase = "Helping the world move forward",
                Description =
                    "Frontend • Backend • DevOps | Strong in project management, UX and getting-it-done.",
                MediaId = heroMedia.Id
            },

            new Hero
            {
                Language = "nl",
                Name = "Giel van Gaal",
                JobTitle = "Junior programmeur & softwareontwikkelaar",
                CatchPhrase = "De wereld vooruit helpen",
                Description =
                    "Frontend • Backend • DevOps | Sterk in projectmanagement, UX en getting-it-done.",
                MediaId = heroMedia.Id
            }
        );

        await context.SaveChangesAsync();
    }

    private static async Task SeedPortfolioAsync(PortfolioDbContext context)
    {
        // Als er al portfolio-items bestaan, niets opnieuw toevoegen.
        if (await context.PortfolioItems.AnyAsync())
            return;

        // =========================================================
        // CATEGORIES
        // =========================================================
        // Categories worden zowel aan PortfolioItems als aan
        // Technologies gekoppeld.
        //
        // Voorbeeld:
        // JoyRide -> Backend
        // Kotlin  -> Backend

        var backend = new Category
        {
            Name = "Backend"
        };

        var devOps = new Category
        {
            Name = "DevOps"
        };

        // Later bijvoorbeeld:
        //
        // var frontend = new Category
        // {
        //     Name = "Frontend"
        // };
        //
        // var mobile = new Category
        // {
        //     Name = "Mobile"
        // };


        // =========================================================
        // TECHNOLOGIES
        // =========================================================
        // Technologies zijn losse entities.
        //
        // Iedere Technology kan weer aan één of meerdere
        // Categories gekoppeld worden.

        var kotlin = new Technology
        {
            Name = "Kotlin",
            Categories = [backend]
        };

        var ktor = new Technology
        {
            Name = "Ktor",
            Categories = [backend]
        };

        var mysql = new Technology
        {
            Name = "MySQL",
            Categories = [backend]
        };

        var docker = new Technology
        {
            Name = "Docker",
            Categories = [devOps]
        };

        var github = new Technology
        {
            Name = "GitHub",
            Categories = [devOps]
        };


        // =========================================================
        // MEDIA
        // =========================================================
        // Media zelf weet niet bij welk PortfolioItem het hoort.
        //
        // Die relatie wordt hieronder gemaakt via
        // PortfolioItemMedia.
        //
        // Hierdoor kan dezelfde Media in theorie later
        // aan meerdere PortfolioItems gekoppeld worden.

        var dashboard = new Media
        {
            Path = "/media/portfolio/joyride-backend-1.webp",
            AltText = "Screenshot van het JoyRide dashboard",
            Type = MediaType.Image
        };

        var classDiagram = new Media
        {
            Path = "/media/portfolio/joyride-backend-2.webp",
            AltText = "Klassendiagram van JoyRide",
            Type = MediaType.Image
        };

        var sequenceDiagram = new Media
        {
            Path = "/media/portfolio/joyride-backend-3.webp",
            AltText = "Sequencediagram van JoyRide",
            Type = MediaType.Image
        };

        var joyRide = new PortfolioItem
        {
            Language = "nl",
            Slug = "joyride",

            Title = "JoyRide",

            CardDescription =
                "Backend-API voor een autoverhuurplatform, gebouwd met Kotlin en Ktor.",

            Description =
                "Lorem ipsum dolor sit amet, consectetur adipiscing elit. " +
                "Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. " +
                "Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris " +
                "nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in " +
                "reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur.",

            GitHubUrl = "https://github.com/...",
            LiveSiteUrl = null,

            Categories =
            [
                backend,
                devOps
            ],

            Technologies =
            [
                kotlin,
                ktor,
                mysql,
                docker,
                github
            ],

            Media =
            [
                new PortfolioItemMedia
                {
                    Media = dashboard,
                    Role = MediaRole.Primary,
                    SortOrder = 1
                },

                new PortfolioItemMedia
                {
                    Media = classDiagram,
                    Role = MediaRole.Secondary,
                    SortOrder = 2
                },

                new PortfolioItemMedia
                {
                    Media = sequenceDiagram,
                    Role = MediaRole.Secondary,
                    SortOrder = 3
                }
            ]
        };


        // =========================================================
        // OPSLAAN
        // =========================================================
        // Omdat alle gekoppelde objecten aan joyRide hangen,
        // kan EF Core de hele objectgraph in één keer opslaan:
        //
        // - PortfolioItem
        // - Categories
        // - Technologies
        // - koppeltabellen
        // - GitHubLinks
        // - Media
        // - PortfolioItemMedia

        context.PortfolioItems.Add(joyRide);

        await context.SaveChangesAsync();
    }
}

// eerst losse bouwstenen maken
//
// Category
//     Technology
// Media
//
//     ↓
//
// PortfolioItem maken
//
//     ↓
//
// bouwstenen eraan koppelen
//
//     ↓
//
// context.PortfolioItems.Add(joyRide)
//
//     ↓
//
// EF Core slaat de hele gekoppelde objectgraph op