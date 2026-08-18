using Domain.Entities;
using Domain.Enums;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data;

public static class DatabaseSeeder
{
    public static async Task SeedAsync(PortfolioDbContext context)
    {
        await SeedHeroAsync(context);
        await SeedPortfolioAsync(context);
    }

    private static async Task SeedHeroAsync(PortfolioDbContext context)
    {
        if (await context.Heroes.AnyAsync())
            return;

        context.Heroes.AddRange(
            new Hero
            {
                Language = "nl",
                Name = "Giel van Gaal",
                JobTitle = "Linux Engineer & Software Developer",
                CatchPhrase = "Van infrastructuur tot applicatie.",
                Description =
                    "Ik werk als Linux Engineer en ontwikkel daarnaast software met onder andere C#, React en Kotlin."
            },

            new Hero
            {
                Language = "en",
                Name = "Giel van Gaal",
                JobTitle = "Linux Engineer & Software Developer",
                CatchPhrase = "From infrastructure to application.",
                Description =
                    "I work as a Linux Engineer and develop software using technologies such as C#, React and Kotlin."
            }
        );

        await context.SaveChangesAsync();
    }

    private static async Task SeedPortfolioAsync(PortfolioDbContext context)
    {
        if (await context.PortfolioItems.AnyAsync())
            return;

        // Categories
        var backend = new Category
        {
            Name = "Backend"
        };

        var devOps = new Category
        {
            Name = "DevOps"
        };

        // Technologies
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

        // Media
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

        // Nederlands
        var joyRideNl = new PortfolioItem
        {
            Language = "nl",
            Slug = "joyride",

            Title = "JoyRide",

            CardDescription =
                "Backend-API voor een autoverhuurplatform, gebouwd met Kotlin en Ktor.",

            Description =
                "JoyRide is een backend-API voor een autoverhuurplatform, ontwikkeld met Kotlin, Ktor en MySQL.",

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

        // Engels
        var joyRideEn = new PortfolioItem
        {
            Language = "en",
            Slug = "joyride",

            Title = "JoyRide",

            CardDescription =
                "Backend API for a car rental platform, built with Kotlin and Ktor.",

            Description =
                "JoyRide is a backend API for a car rental platform, developed with Kotlin, Ktor and MySQL.",

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

        context.PortfolioItems.AddRange(
            joyRideNl,
            joyRideEn
        );

        await context.SaveChangesAsync();
    }
}