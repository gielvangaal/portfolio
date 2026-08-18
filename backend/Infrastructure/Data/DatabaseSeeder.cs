using Domain.Entities;
using Domain.Enums;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data;

public static class DatabaseSeeder
{
    public static async Task SeedAsync(PortfolioDbContext context)
    {
        await context.Database.MigrateAsync();

        if (!context.Heroes.Any())
        {
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
        }

        if (!context.PortfolioItems.Any())
        {
            var backendCategory = new Category
            {
                Name = "Backend"
            };

            var frontendCategory = new Category
            {
                Name = "Frontend"
            };

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

            var joyRideNl = new PortfolioItem
            {
                Language = "nl",
                Slug = "joyride",
                Title = "JoyRide",

                CardDescription =
                    "Een full-stack applicatie ontwikkeld met C# en React.",

                Description =
                    "JoyRide is een full-stack applicatie met een C#/.NET backend en een React frontend.",

                GitHubUrl = "https://github.com/example/joyride",
                LiveSiteUrl = null,

                Categories =
                [
                    new PortfolioItemCategory
                    {
                        Category = backendCategory
                    },
                    new PortfolioItemCategory
                    {
                        Category = frontendCategory
                    }
                ],

                Technologies =
                [
                    new PortfolioItemTechnology
                    {
                        Technology = csharp
                    },
                    new PortfolioItemTechnology
                    {
                        Technology = dotnet
                    },
                    new PortfolioItemTechnology
                    {
                        Technology = react
                    }
                ],

                Media =
                [
                    new PortfolioItemMedia
                    {
                        Media = joyRideBackendMedia
                    },
                    new PortfolioItemMedia
                    {
                        Media = joyRideFrontendMedia
                    }
                ]
            };

            var joyRideEn = new PortfolioItem
            {
                Language = "en",
                Slug = "joyride",
                Title = "JoyRide",

                CardDescription =
                    "A full-stack application developed with C# and React.",

                Description =
                    "JoyRide is a full-stack application with a C#/.NET backend and a React frontend.",

                GitHubUrl = "https://github.com/example/joyride",
                LiveSiteUrl = null,

                Categories =
                [
                    new PortfolioItemCategory
                    {
                        Category = backendCategory
                    },
                    new PortfolioItemCategory
                    {
                        Category = frontendCategory
                    }
                ],

                Technologies =
                [
                    new PortfolioItemTechnology
                    {
                        Technology = csharp
                    },
                    new PortfolioItemTechnology
                    {
                        Technology = dotnet
                    },
                    new PortfolioItemTechnology
                    {
                        Technology = react
                    }
                ],

                Media =
                [
                    new PortfolioItemMedia
                    {
                        Media = joyRideBackendMedia
                    },
                    new PortfolioItemMedia
                    {
                        Media = joyRideFrontendMedia
                    }
                ]
            };

            context.PortfolioItems.AddRange(
                joyRideNl,
                joyRideEn
            );
        }

        await context.SaveChangesAsync();
    }
}