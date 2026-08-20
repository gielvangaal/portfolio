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

        /*
         * Categories
         */

        var frontend = new Category
        {
            Name = "Frontend"
        };

        var backend = new Category
        {
            Name = "Backend"
        };

        var devOps = new Category
        {
            Name = "DevOps"
        };

        /*
         * Technologies
         */

        var html = new Technology
        {
            Name = "HTML",
            Categories = [frontend]
        };

        var css = new Technology
        {
            Name = "CSS",
            Categories = [frontend]
        };

        var javascript = new Technology
        {
            Name = "JavaScript",
            Categories = [frontend]
        };

        var bootstrap = new Technology
        {
            Name = "Bootstrap",
            Categories = [frontend]
        };

        var figma = new Technology
        {
            Name = "Figma",
            Categories = [frontend]
        };

        var php = new Technology
        {
            Name = "PHP",
            Categories = [backend]
        };

        var mysql = new Technology
        {
            Name = "MySQL",
            Categories = [backend]
        };

        var phpMyAdmin = new Technology
        {
            Name = "phpMyAdmin",
            Categories = [backend]
        };

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

        var exposed = new Technology
        {
            Name = "Exposed",
            Categories = [backend]
        };

        var python = new Technology
        {
            Name = "Python",
            Categories = [backend]
        };

        var django = new Technology
        {
            Name = "Django",
            Categories = [backend]
        };

        var docker = new Technology
        {
            Name = "Docker",
            Categories = [devOps]
        };

        var nginx = new Technology
        {
            Name = "Nginx",
            Categories = [devOps]
        };

        var gunicorn = new Technology
        {
            Name = "Gunicorn",
            Categories = [devOps]
        };

        var certbot = new Technology
        {
            Name = "Certbot",
            Categories = [devOps]
        };

        var github = new Technology
        {
            Name = "GitHub",
            Categories = [devOps]
        };

        var jira = new Technology
        {
            Name = "Jira",
            Categories = [devOps]
        };

        /*
         * Media
         */

        // CareBots frontend

        var careBotsFrontendMain = CreateImage(
            "/media/portfolio/carebots-1-klein.webp",
            "Screenshot van de homepage van CareBots");

        var careBotsFrontendAbout = CreateImage(
            "/media/portfolio/carebots-2-klein.webp",
            "Screenshot van de over CareBots-pagina");

        var careBotsFrontendFaq = CreateImage(
            "/media/portfolio/carebots-3-klein.webp",
            "Screenshot van de FAQ-pagina van CareBots");

        // CareBots backend

        var careBotsBackendDashboard = CreateImage(
            "/media/portfolio/carebots-backend-1.webp",
            "Screenshot van het CareBots dashboard");

        var careBotsBackendUsers = CreateImage(
            "/media/portfolio/carebots-backend-2.webp",
            "Screenshot van de gebruikerspagina van CareBots");

        var careBotsBackendContact = CreateImage(
            "/media/portfolio/carebots-backend-3.webp",
            "Screenshot van de contactpagina van CareBots");

        // JoyRide

        var joyRideDashboard = CreateImage(
            "/media/portfolio/joyride-backend-1.webp",
            "Screenshot van het JoyRide dashboard");

        var joyRideClassDiagram = CreateImage(
            "/media/portfolio/joyride-backend-2.webp",
            "Klassendiagram van JoyRide");

        var joyRideSequenceDiagram = CreateImage(
            "/media/portfolio/joyride-backend-3.webp",
            "Sequencediagram van een JoyRide API-endpoint");

        // Nijntje

        var nijntjeMain = CreateImage(
            "/media/portfolio/nijntje-1-klein.webp",
            "Screenshot van de homepage van Nijntje");

        var nijntjeMessageBoard = CreateImage(
            "/media/portfolio/nijntje-2-klein.webp",
            "Screenshot van het Nijntje messageboard");

        var nijntjeAbout = CreateImage(
            "/media/portfolio/nijntje-3-klein.webp",
            "Screenshot van de over Nijntje-pagina");

        // Giel van Gaal

        var gielMain = CreateImage(
            "/media/portfolio/gvg-1-klein.webp",
            "Screenshot van de homepage van gielvangaal.nl");

        var gielDiscography = CreateImage(
            "/media/portfolio/gvg-2-klein.webp",
            "Screenshot van een pagina op gielvangaal.nl");

        var gielNews = CreateImage(
            "/media/portfolio/gvg-3-klein.webp",
            "Screenshot van de nieuwspagina van gielvangaal.nl");

        /*
         * Portfolio items
         */

        /*
         * CareBots frontend
         *
         * TODO: exacte projectmaand controleren.
         */

        var careBotsFrontendNl = new PortfolioItem
        {
            Language = "nl",
            Slug = "carebots-frontend",

            Title = "CareBots Frontend",

            CardDescription =
                "Responsive website voor een concept rond zorgrobots, ontwikkeld met HTML, CSS en JavaScript.",

            Description =
                "CareBots ontstond tijdens het eerste project van mijn opleiding Informatica. " +
                "Binnen een team ontwikkelden we een concept voor robots die zorgmedewerkers ondersteunen en werkten we " +
                "dit uit van ondernemingsplan en functioneel ontwerp tot een werkende website. " +
                "Mijn focus lag op het vertalen van het ontwerp naar een responsive frontend, waarbij ik werkte met " +
                "HTML, CSS, JavaScript en Bootstrap. Tijdens het project leerde ik veel over samenwerken, requirements, " +
                "Git-workflows en het maken van technische keuzes binnen een gezamenlijk product.",

            ProjectDate = new DateOnly(2024, 9, 1),
            ProjectType = ProjectType.Education,
            Role = "Frontend Developer",
            TeamSize = null,
            Duration = null,

            GitHubUrl = null,
            LiveSiteUrl = "https://fdd.infra.iantiemann.nl",

            Categories =
            [
                frontend
            ],

            Technologies =
            [
                html,
                css,
                javascript,
                bootstrap,
                figma,
                github
            ],

            Media = CreateMediaCollection(
                careBotsFrontendMain,
                careBotsFrontendAbout,
                careBotsFrontendFaq)
        };

        var careBotsFrontendEn = new PortfolioItem
        {
            Language = "en",
            Slug = "carebots-frontend",

            Title = "CareBots Frontend",

            CardDescription =
                "Responsive website for a healthcare robotics concept, built with HTML, CSS and JavaScript.",

            Description =
                "CareBots was created during the first project of my Computer Science degree. " +
                "As a team, we developed a concept for robots designed to support healthcare professionals and transformed " +
                "the idea from a business plan and functional design into a working website. " +
                "My focus was on translating the design into a responsive frontend using HTML, CSS, JavaScript and Bootstrap. " +
                "The project taught me a great deal about collaboration, requirements, Git workflows and making technical " +
                "decisions within a shared software project.",

            ProjectDate = new DateOnly(2024, 9, 1),
            ProjectType = ProjectType.Education,
            Role = "Frontend Developer",
            TeamSize = null,
            Duration = null,

            GitHubUrl = null,
            LiveSiteUrl = "https://fdd.infra.iantiemann.nl",

            Categories =
            [
                frontend
            ],

            Technologies =
            [
                html,
                css,
                javascript,
                bootstrap,
                figma,
                github
            ],

            Media = CreateMediaCollection(
                careBotsFrontendMain,
                careBotsFrontendAbout,
                careBotsFrontendFaq)
        };

        /*
         * CareBots backend
         *
         * TODO: exacte projectmaand controleren.
         */

        var careBotsBackendNl = new PortfolioItem
        {
            Language = "nl",
            Slug = "carebots-backend",

            Title = "CareBots Backend",

            CardDescription =
                "Backend voor een robotbeheersysteem met PHP, MySQL, CI/CD en role-based functionaliteit.",

            Description =
                "In een vervolgproject op CareBots ontwikkelden we een backend voor het beheren van robots en gebruikers. " +
                "Gebruikers konden afhankelijk van hun rol verschillende gegevens bekijken en beheren. " +
                "Tijdens dit project werkte ik met PHP, MySQL en JavaScript, ontwierp en implementeerde ik databasefunctionaliteit " +
                "en werkte ik objectgeoriënteerd. Daarnaast ontwikkelde ik een herbruikbare componentlibrary en werkten we " +
                "volgens Agile Scrum met Jira en een CI/CD-pipeline. Het project leerde me vooral hoe belangrijk heldere " +
                "requirements, betrouwbare functies en goede samenwerking zijn wanneer meerdere ontwikkelaars aan hetzelfde systeem werken.",

            ProjectDate = new DateOnly(2025, 5, 1),
            ProjectType = ProjectType.Education,
            Role = "Backend Developer",
            TeamSize = null,
            Duration = null,

            GitHubUrl = null,
            LiveSiteUrl = null,

            Categories =
            [
                backend,
                devOps
            ],

            Technologies =
            [
                php,
                mysql,
                phpMyAdmin,
                html,
                css,
                javascript,
                docker,
                github,
                jira
            ],

            Media = CreateMediaCollection(
                careBotsBackendDashboard,
                careBotsBackendUsers,
                careBotsBackendContact)
        };

        var careBotsBackendEn = new PortfolioItem
        {
            Language = "en",
            Slug = "carebots-backend",

            Title = "CareBots Backend",

            CardDescription =
                "Backend for a robot management system using PHP, MySQL, CI/CD and role-based functionality.",

            Description =
                "In a follow-up CareBots project, we developed a backend for managing robots and users. " +
                "Depending on their role, users could view and manage different parts of the system. " +
                "I worked with PHP, MySQL and JavaScript, designed and implemented database functionality and applied " +
                "object-oriented programming principles. I also developed a reusable component library while the team " +
                "worked with Agile Scrum, Jira and a CI/CD pipeline. The project taught me the importance of clear " +
                "requirements, reliable reusable code and good communication when several developers work on the same system.",

            ProjectDate = new DateOnly(2025, 5, 1),
            ProjectType = ProjectType.Education,
            Role = "Backend Developer",
            TeamSize = null,
            Duration = null,

            GitHubUrl = null,
            LiveSiteUrl = null,

            Categories =
            [
                backend,
                devOps
            ],

            Technologies =
            [
                php,
                mysql,
                phpMyAdmin,
                html,
                css,
                javascript,
                docker,
                github,
                jira
            ],

            Media = CreateMediaCollection(
                careBotsBackendDashboard,
                careBotsBackendUsers,
                careBotsBackendContact)
        };

        /*
         * JoyRide
         *
         * TODO: exacte projectmaand controleren.
         */

        var joyRideNl = new PortfolioItem
        {
            Language = "nl",
            Slug = "joyride",

            Title = "JoyRide",

            CardDescription =
                "REST-API voor een autoverhuurplatform, ontwikkeld met Kotlin, Ktor en MySQL.",

            Description =
                "JoyRide is een backend-API voor een autoverhuurplatform die ik ontwikkelde met Kotlin en Ktor. " +
                "De applicatie is opgebouwd rond controllers, services, repositories en mappers en gebruikt Exposed als ORM " +
                "voor de communicatie met MySQL. We werkten in wekelijkse sprints en gebruikten een OTAP-werkwijze met " +
                "staging, acceptatie en productie. Tijdens het project lag veel nadruk op foutafhandeling, duidelijke API-responses, " +
                "architectuur en het maken van pragmatische keuzes om binnen de beschikbare tijd een betrouwbaar systeem op te leveren.",

            ProjectDate = new DateOnly(2025, 11, 1),
            ProjectType = ProjectType.Education,
            Role = "Backend Developer",
            TeamSize = null,
            Duration = null,

            GitHubUrl = null,
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
                exposed,
                mysql,
                docker,
                github,
                jira
            ],

            Media = CreateMediaCollection(
                joyRideDashboard,
                joyRideClassDiagram,
                joyRideSequenceDiagram)
        };

        var joyRideEn = new PortfolioItem
        {
            Language = "en",
            Slug = "joyride",

            Title = "JoyRide",

            CardDescription =
                "REST API for a car rental platform, developed with Kotlin, Ktor and MySQL.",

            Description =
                "JoyRide is a backend API for a car rental platform developed with Kotlin and Ktor. " +
                "The application is structured around controllers, services, repositories and mappers and uses Exposed " +
                "as its ORM for communication with MySQL. We worked in weekly sprints and followed a DTAP workflow with " +
                "staging, acceptance and production environments. The project focused strongly on error handling, clear API responses, " +
                "software architecture and making pragmatic decisions to deliver a reliable system within a fixed deadline.",

            ProjectDate = new DateOnly(2025, 11, 1),
            ProjectType = ProjectType.Education,
            Role = "Backend Developer",
            TeamSize = null,
            Duration = null,

            GitHubUrl = null,
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
                exposed,
                mysql,
                docker,
                github,
                jira
            ],

            Media = CreateMediaCollection(
                joyRideDashboard,
                joyRideClassDiagram,
                joyRideSequenceDiagram)
        };

        /*
         * Nijntje
         *
         * TODO: exacte projectdatum controleren.
         */

        var nijntjeNl = new PortfolioItem
        {
            Language = "nl",
            Slug = "nijntje",

            Title = "Nijntje",

            CardDescription =
                "Persoonlijk full-stack experiment met Django, CSS Grid, Nginx en een eigen VPS.",

            Description =
                "Nijntje begon als hobbyproject om zonder vast framework of bestaande architectuur verschillende technieken " +
                "zelf te ontdekken. Ik experimenteerde met CSS Grid en bouwde met Django een messageboard. " +
                "Daarvoor zette ik mijn eigen VPS op, configureerde ik Gunicorn als WSGI-server en Nginx als reverse proxy " +
                "en gebruikte ik Certbot voor TLS. Berichten worden vanuit de frontend via JavaScript opgehaald. " +
                "Het project was vooral een technische speeltuin waarin ik veel leerde over Linux-servers, poorten, " +
                "reverse proxies, SSH-sleutels en het zelfstandig uitzoeken en implementeren van nieuwe technologie.",

            ProjectDate = new DateOnly(2024, 1, 1),
            ProjectType = ProjectType.Personal,
            Role = "Full-stack Developer",
            TeamSize = 1,
            Duration = null,

            GitHubUrl = null,
            LiveSiteUrl = "https://www.gielvangaal.nl/nijntje",

            Categories =
            [
                frontend,
                backend,
                devOps
            ],

            Technologies =
            [
                html,
                css,
                javascript,
                python,
                django,
                gunicorn,
                nginx,
                certbot
            ],

            Media = CreateMediaCollection(
                nijntjeMain,
                nijntjeMessageBoard,
                nijntjeAbout)
        };

        var nijntjeEn = new PortfolioItem
        {
            Language = "en",
            Slug = "nijntje",

            Title = "Nijntje",

            CardDescription =
                "Personal full-stack experiment using Django, CSS Grid, Nginx and a self-managed VPS.",

            Description =
                "Nijntje started as a personal project to explore different technologies without relying on an existing " +
                "architecture or predefined solution. I experimented with CSS Grid and built a message board using Django. " +
                "To run it, I set up my own VPS, configured Gunicorn as the WSGI server and Nginx as a reverse proxy, " +
                "and used Certbot for TLS. Messages are retrieved from the frontend using JavaScript. " +
                "The project became a technical playground in which I learned a great deal about Linux servers, ports, " +
                "reverse proxies, SSH keys and independently researching and implementing unfamiliar technology.",

            ProjectDate = new DateOnly(2024, 1, 1),
            ProjectType = ProjectType.Personal,
            Role = "Full-stack Developer",
            TeamSize = 1,
            Duration = null,

            GitHubUrl = null,
            LiveSiteUrl = "https://www.gielvangaal.nl/nijntje",

            Categories =
            [
                frontend,
                backend,
                devOps
            ],

            Technologies =
            [
                html,
                css,
                javascript,
                python,
                django,
                gunicorn,
                nginx,
                certbot
            ],

            Media = CreateMediaCollection(
                nijntjeMain,
                nijntjeMessageBoard,
                nijntjeAbout)
        };

        /*
         * Giel van Gaal
         */

        var gielVanGaalNl = new PortfolioItem
        {
            Language = "nl",
            Slug = "giel-van-gaal",

            Title = "Giel van Gaal",

            CardDescription =
                "Responsive artiestenwebsite voor mijn muziek, discografie, nieuws en contactinformatie.",

            Description =
                "In 2018 bouwde ik een website voor mijn werk als muzikant. De website brengt mijn discografie, nieuws, " +
                "achtergrondinformatie en contactgegevens samen in één responsive omgeving. " +
                "Ik gebruikte een bestaande template als uitgangspunt en paste de vormgeving, structuur en functionaliteit " +
                "aan mijn eigen wensen aan met HTML, CSS, JavaScript en Bootstrap. Het project laat goed zien hoe ik al " +
                "voor mijn opleiding Informatica zelfstandig experimenteerde met webontwikkeling en bestaande software " +
                "analyseerde en aanpaste om tot een bruikbaar eindproduct te komen.",

            ProjectDate = new DateOnly(2018, 1, 1),
            ProjectType = ProjectType.Personal,
            Role = "Frontend Developer",
            TeamSize = 1,
            Duration = null,

            GitHubUrl = null,
            LiveSiteUrl = "https://www.gielvangaal.nl",

            Categories =
            [
                frontend
            ],

            Technologies =
            [
                html,
                css,
                javascript,
                bootstrap
            ],

            Media = CreateMediaCollection(
                gielMain,
                gielDiscography,
                gielNews)
        };

        var gielVanGaalEn = new PortfolioItem
        {
            Language = "en",
            Slug = "giel-van-gaal",

            Title = "Giel van Gaal",

            CardDescription =
                "Responsive artist website for my music, discography, news and contact information.",

            Description =
                "In 2018 I built a website for my work as a musician. The site brings together my discography, news, " +
                "background information and contact details in a single responsive environment. " +
                "I used an existing template as a starting point and adapted its styling, structure and functionality " +
                "to my own requirements using HTML, CSS, JavaScript and Bootstrap. The project shows how I was already " +
                "experimenting independently with web development before starting my Computer Science degree, analysing " +
                "and adapting existing software to create a useful finished product.",

            ProjectDate = new DateOnly(2018, 1, 1),
            ProjectType = ProjectType.Personal,
            Role = "Frontend Developer",
            TeamSize = 1,
            Duration = null,

            GitHubUrl = null,
            LiveSiteUrl = "https://www.gielvangaal.nl",

            Categories =
            [
                frontend
            ],

            Technologies =
            [
                html,
                css,
                javascript,
                bootstrap
            ],

            Media = CreateMediaCollection(
                gielMain,
                gielDiscography,
                gielNews)
        };

        context.PortfolioItems.AddRange(
            careBotsFrontendNl,
            careBotsFrontendEn,

            careBotsBackendNl,
            careBotsBackendEn,

            joyRideNl,
            joyRideEn,

            nijntjeNl,
            nijntjeEn,

            gielVanGaalNl,
            gielVanGaalEn
        );

        await context.SaveChangesAsync();
    }

    private static Media CreateImage(string path, string altText)
    {
        return new Media
        {
            Path = path,
            AltText = altText,
            Type = MediaType.Image
        };
    }

    private static ICollection<PortfolioItemMedia> CreateMediaCollection(
        Media primary,
        params Media[] secondary)
    {
        var media = new List<PortfolioItemMedia>
        {
            new()
            {
                Media = primary,
                Role = MediaRole.Primary,
                SortOrder = 1
            }
        };

        for (var i = 0; i < secondary.Length; i++)
        {
            media.Add(
                new PortfolioItemMedia
                {
                    Media = secondary[i],
                    Role = MediaRole.Secondary,
                    SortOrder = i + 2
                });
        }

        return media;
    }
}