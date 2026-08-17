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

            var csharp = new Technology
            {
                Name = "C#",
                Categories = [backendCategory]
            };

            var dotnet = new Technology
            {
                Name = ".NET",
                Categories = [backendCategory]
            };

            var react = new Technology
            {
                Name = "React",
                Categories = [frontendCategory]
            };

            var joyRideBackendMedia = new Media
            {
                Path = "/media/portfolio/joyride-backend-1.webp",
                AltText = "JoyRide backend",
                Type = MediaType.Image
            };

            var joyRideFrontendMedia = new Media
            {
                Path = "/media/portfolio/joyride-frontend-1.webp",
                AltText = "JoyRide frontend",
                Type = MediaType.Image
            };

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