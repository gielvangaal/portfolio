using Domain.Entities;
using Domain.Enums;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data;

public static class DatabaseSeeder
{
    public static async Task SeedAsync(PortfolioDbContext context)
    {
        await SeedTechnologiesAsync(context);
        await SeedSkillsAsync(context);
        await SeedToolingAsync(context);
        
        await SeedHeroAsync(context);
        await SeedPortfolioAsync(context);
        await SeedAboutProfileAsync(context);
        await SeedEducationAsync(context);
        await SeedWorkExperienceAsync(context);
        await SeedLibraryItemsAsync(context);
        await SeedContactAsync(context);
    }
    
    // Required
    private static async Task SeedTechnologiesAsync(PortfolioDbContext context)
{
    if (await context.Technologies.AnyAsync())
        return;

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

    context.Technologies.AddRange(
        new Technology
        {
            Name = "HTML",
            Usage = TechnologyUsage.Regular,
            Categories = [frontend],
            Media = CreateImage(
                "/media/technologies/html5.webp",
                "HTML-logo")
        },
        new Technology
        {
            Name = "CSS",
            Usage = TechnologyUsage.Regular,
            Categories = [frontend],
            Media = CreateImage(
                "/media/technologies/css3.webp",
                "CSS-logo")
        },
        new Technology
        {
            Name = "SOAP",
            Usage = TechnologyUsage.Past,
            Categories = [backend],
            Media = null
        },
        new Technology
        {
            Name = "JavaScript",
            Usage = TechnologyUsage.Occasional,
            Categories = [frontend],
            Media = CreateImage(
                "/media/technologies/javascript.webp",
                "JavaScript-logo")
        },
        new Technology
        {
            Name = "Bootstrap",
            Usage = TechnologyUsage.Occasional,
            Categories = [frontend],
            Media = CreateImage(
                "/media/technologies/bootstrap.webp",
                "Bootstrap-logo")
        },
        new Technology
        {
            Name = "Figma",
            Usage = TechnologyUsage.Occasional,
            Categories = [frontend],
            Media = CreateImage(
                "/media/technologies/figma.webp",
                "Figma-logo")
        },
        new Technology
        {
            Name = "PHP",
            Usage = TechnologyUsage.Occasional,
            Categories = [backend],
            Media = CreateImage(
                "/media/technologies/php.webp",
                "PHP-logo")
        },
        new Technology
        {
            Name = "MySQL",
            Usage = TechnologyUsage.Daily,
            Categories = [backend],
            Media = CreateImage(
                "/media/technologies/mysql.webp",
                "MySQL-logo")
        },
        new Technology
        {
            Name = "phpMyAdmin",
            Usage = TechnologyUsage.Daily,
            Categories = [backend],
            Media = CreateImage(
                "/media/technologies/phpmyadmin.webp",
                "phpMyAdmin-logo")
        },
        new Technology
        {
            Name = "Kotlin",
            Usage = TechnologyUsage.Occasional,
            Categories = [backend],
            Media = CreateImage(
                "/media/technologies/kotlin.webp",
                "Kotlin-logo")
        },
        new Technology
        {
            Name = "Ktor",
            Usage = TechnologyUsage.Occasional,
            Categories = [backend],
            Media = CreateImage(
                "/media/technologies/ktor.webp",
                "Ktor-logo")
        },
        new Technology
        {
            Name = "Exposed",
            Usage = TechnologyUsage.Occasional,
            Categories = [backend],
            Media = CreateImage(
                "/media/technologies/exposed.webp",
                "Exposed-logo")
        },
        new Technology
        {
            Name = "Python",
            Usage = TechnologyUsage.Daily,
            Categories = [backend],
            Media = CreateImage(
                "/media/technologies/python.webp",
                "Python-logo")
        },
        new Technology
        {
            Name = "Django",
            Usage = TechnologyUsage.Occasional,
            Categories = [backend],
            Media = CreateImage(
                "/media/technologies/django.webp",
                "Django-logo")
        },
        new Technology
        {
            Name = "Docker",
            Usage = TechnologyUsage.Daily,
            Categories = [devOps],
            Media = CreateImage(
                "/media/technologies/docker.webp",
                "Docker-logo")
        },
        new Technology
        {
            Name = "Nginx",
            Usage = TechnologyUsage.Daily,
            Categories = [devOps],
            Media = CreateImage(
                "/media/technologies/nginx.webp",
                "Nginx-logo")
        },
        new Technology
        {
            Name = "Gunicorn",
            Usage = TechnologyUsage.Occasional,
            Categories = [devOps],
            Media = CreateImage(
                "/media/technologies/gunicorn.webp",
                "Gunicorn-logo")
        },
        new Technology
        {
            Name = "Certbot",
            Usage = TechnologyUsage.Regular,
            Categories = [devOps],
            Media = CreateImage(
                "/media/technologies/certbot.webp",
                "Certbot-logo")
        },
        new Technology
        {
            Name = "GitHub",
            Usage = TechnologyUsage.Daily,
            Categories = [devOps],
            Media = CreateImage(
                "/media/technologies/github.webp",
                "GitHub-logo")
        },
        new Technology
        {
            Name = "Jira",
            Usage = TechnologyUsage.Daily,
            Categories = [devOps],
            Media = CreateImage(
                "/media/technologies/jira.webp",
                "Jira-logo")
        },
        new Technology
        {
            Name = "FFmpeg",
            Usage = TechnologyUsage.Occasional,
            Categories = [backend],
            Media = CreateImage(
                "/media/technologies/ffmpeg.webp",
                "FFmpeg-logo")
        },
        new Technology
        {
            Name = "GIMP",
            Usage = TechnologyUsage.Occasional,
            Categories = [frontend],
            Media = CreateImage(
                "/media/technologies/gimp.webp",
                "GIMP-logo")
        },
        new Technology
        {
            Name = "Node.js",
            Usage = TechnologyUsage.Occasional,
            Categories = [backend],
            Media = CreateImage(
                "/media/technologies/node-js.webp",
                "Node.js-logo")
        },
        new Technology
        {
            Name = "REST API",
            Usage = TechnologyUsage.Regular,
            Categories = [backend],
            Media = CreateImage(
                "/media/technologies/rest-api.webp",
                "REST API-logo")
        },
        new Technology
        {
            Name = "Terminal",
            Usage = TechnologyUsage.Daily,
            Categories = [devOps],
            Media = CreateImage(
                "/media/technologies/terminal.webp",
                "Terminal-logo")
        },
        new Technology
        {
            Name = "UML",
            Usage = TechnologyUsage.Occasional,
            Categories = [backend],
            Media = CreateImage(
                "/media/technologies/uml.webp",
                "UML-logo")
        },
        new Technology
        {
            Name = "Visual Studio Code",
            Usage = TechnologyUsage.Regular,
            Categories = [frontend, backend, devOps],
            Media = CreateImage(
                "/media/technologies/vsc.webp",
                "Visual Studio Code-logo")
        }
    );

    await context.SaveChangesAsync();
}

    private static async Task SeedSkillsAsync(PortfolioDbContext context)
    {
        if (await context.Skills.AnyAsync())
            return;

        context.Skills.AddRange(
            new Skill
            {
                Name = "Functioneel programmeren",
                Type = SkillType.Skill
            },
            new Skill
            {
                Name = "Software testing",
                Type = SkillType.Skill
            },
            new Skill
            {
                Name = "Agile werken",
                Type = SkillType.Skill
            },
            new Skill
            {
                Name = "Scrum",
                Type = SkillType.Skill
            },
            new Skill
            {
                Name = "Design patterns",
                Type = SkillType.Skill
            },
            new Skill
            {
                Name = "Projectmatig werken",
                Type = SkillType.Skill
            },
            new Skill
            {
                Name = "Systeemontwerp",
                Type = SkillType.Skill
            },
            new Skill
            {
                Name = "Softwarearchitectuur",
                Type = SkillType.Skill
            },
            new Skill
            {
                Name = "Databaseontwerp",
                Type = SkillType.Skill
            },
            new Skill
            {
                Name = "CI/CD-pipelines",
                Type = SkillType.Skill
            },
            new Skill
            {
                Name = "Objectgeoriënteerd programmeren",
                Type = SkillType.Skill
            },

            // Softskills - vaardigheden

            new Skill
            {
                Name = "Praktische instelling",
                Type = SkillType.Skill
            },
            new Skill
            {
                Name = "Sociale vaardigheden",
                Type = SkillType.Skill
            },
            new Skill
            {
                Name = "Zelfstandigheid",
                Type = SkillType.Skill
            },
            new Skill
            {
                Name = "Nauwkeurig en exact",
                Type = SkillType.Skill
            },
            new Skill
            {
                Name = "Plannen en structureren",
                Type = SkillType.Skill
            },
            new Skill
            {
                Name = "Effectief communiceren",
                Type = SkillType.Skill
            },
            new Skill
            {
                Name = "Snel leren en toepassen",
                Type = SkillType.Skill
            },
            new Skill
            {
                Name = "Helder documenteren",
                Type = SkillType.Skill
            },

            // Softskills - competenties

            new Skill
            {
                Name = "Oplossingsgericht denken",
                Type = SkillType.Competency
            },
            new Skill
            {
                Name = "Energie",
                Type = SkillType.Competency
            },
            new Skill
            {
                Name = "Empathie",
                Type = SkillType.Competency
            },
            new Skill
            {
                Name = "Creativiteit",
                Type = SkillType.Competency
            },
            new Skill
            {
                Name = "Analytisch vermogen",
                Type = SkillType.Competency
            },
            new Skill
            {
                Name = "Zelfstandig leren",
                Type = SkillType.Competency
            },
            new Skill
            {
                Name = "Kwaliteitsbewustzijn",
                Type = SkillType.Competency
            },
            new Skill
            {
                Name = "Flexibiliteit",
                Type = SkillType.Competency
            },
            new Skill
            {
                Name = "Samenwerken",
                Type = SkillType.Competency
            },

            // Softskills - karakter

            new Skill
            {
                Name = "Nieuwsgierig",
                Type = SkillType.Character
            },
            new Skill
            {
                Name = "Realistisch",
                Type = SkillType.Character
            },
            new Skill
            {
                Name = "Klantgericht",
                Type = SkillType.Character
            },
            new Skill
            {
                Name = "Evenwichtig",
                Type = SkillType.Character
            },
            new Skill
            {
                Name = "Spontaan",
                Type = SkillType.Character
            },
            new Skill
            {
                Name = "Integer",
                Type = SkillType.Character
            },
            new Skill
            {
                Name = "Creatief",
                Type = SkillType.Character
            },
            new Skill
            {
                Name = "Betrokken",
                Type = SkillType.Character
            },
            new Skill
            {
                Name = "Doortastend",
                Type = SkillType.Character
            },

            new Skill
            {
                Name = "UI/UX",
                Type = SkillType.Skill
            },
            new Skill
            {
                Name = "Creatief ondernemen",
                Type = SkillType.Skill
            },
            new Skill
            {
                Name = "Presentatievaardigheden",
                Type = SkillType.Skill
            },
            new Skill
            {
                Name = "Marketing en communicatie",
                Type = SkillType.Skill
            },
            new Skill
            {
                Name = "Methodisch werken",
                Type = SkillType.Skill
            }
        );
    }

    private static async Task SeedToolingAsync(PortfolioDbContext context)
{
    if (await context.Tooling.AnyAsync())
        return;

    context.Tooling.AddRange(
        new Tooling
        {
            Name = "Git",
            Media = CreateImage(
                "/media/tooling/git.webp",
                "Git-logo")
        },
        new Tooling
        {
            Name = "GitHub Actions",
            Media = CreateImage(
                "/media/tooling/github-actions.webp",
                "GitHub Actions-logo")
        },
        new Tooling
        {
            Name = "Gradle",
            Media = CreateImage(
                "/media/tooling/gradle.webp",
                "Gradle-logo")
        },
        new Tooling
        {
            Name = "Jira",
            Media = CreateImage(
                "/media/tooling/jira.webp",
                "Jira-logo")
        },
        new Tooling
        {
            Name = "Confluence",
            Media = CreateImage(
                "/media/tooling/confluence.webp",
                "Confluence-logo")
        },
        new Tooling
        {
            Name = "GitLab",
            Media = CreateImage(
                "/media/tooling/gitlab.webp",
                "GitLab-logo")
        },
        new Tooling
        {
            Name = "Zendesk",
            Media = CreateImage(
                "/media/tooling/zendesk.webp",
                "Zendesk-logo")
        },
        new Tooling
        {
            Name = "Postman",
            Media = CreateImage(
                "/media/tooling/postman.webp",
                "Postman-logo")
        },
        new Tooling
        {
            Name = "WinSCP",
            Media = CreateImage(
                "/media/tooling/winscp.webp",
                "WinSCP-logo")
        },
        new Tooling
        {
            Name = "Microsoft Dynamics 365",
            Media = CreateImage(
                "/media/tooling/dynamics-365.webp",
                "Microsoft Dynamics 365-logo")
        },
        new Tooling
        {
            Name = "Microsoft Outlook",
            Media = null
        },
        new Tooling
        {
            Name = "Microsoft Agenda",
            Media = null
        },
        new Tooling
        {
            Name = "Microsoft Excel",
            Media = null
        },
        new Tooling
        {
            Name = "Microsoft Word",
            Media = null
        },
        new Tooling
        {
            Name = "Klantbeeld",
            Media = null
        }
    );

    await context.SaveChangesAsync();
}

    // Sections
    private static async Task SeedHeroAsync(PortfolioDbContext context)
    {
        if (await context.Heroes.AnyAsync())
            return;

        var heroImage = new Media
        {
            Path = "/media/giel.webp",
            AltText = "Portret van Giel van Gaal",
            Type = MediaType.Image
        };

        context.Heroes.AddRange(
            new Hero
            {
                Language = "nl",
                Name = "Giel van Gaal",
                JobTitle = "Linux Engineer & Software Developer",
                CatchPhrase = "Van infrastructuur tot applicatie.",
                Description =
                    "Ik werk als Linux Engineer en ontwikkel daarnaast software met onder andere C#, React en Kotlin.",
                Media = heroImage
            },

            new Hero
            {
                Language = "en",
                Name = "Giel van Gaal",
                JobTitle = "Linux Engineer & Software Developer",
                CatchPhrase = "From infrastructure to application.",
                Description =
                    "I work as a Linux Engineer and develop software using technologies such as C#, React and Kotlin.",
                Media = heroImage
            }
        );

        await context.SaveChangesAsync();
    }

    private static async Task SeedPortfolioAsync(PortfolioDbContext context)
    {
        if (await context.PortfolioItems.AnyAsync())
            return;

        var technologies = await context.Technologies
            .Include(t => t.Categories)
            .ToDictionaryAsync(t => t.Name);

        var html = technologies["HTML"];
        var css = technologies["CSS"];
        var javascript = technologies["JavaScript"];
        var bootstrap = technologies["Bootstrap"];
        var figma = technologies["Figma"];

        var php = technologies["PHP"];
        var mysql = technologies["MySQL"];
        var phpMyAdmin = technologies["phpMyAdmin"];

        var kotlin = technologies["Kotlin"];
        var ktor = technologies["Ktor"];
        var exposed = technologies["Exposed"];

        var python = technologies["Python"];
        var django = technologies["Django"];

        var docker = technologies["Docker"];
        var nginx = technologies["Nginx"];
        var gunicorn = technologies["Gunicorn"];
        var certbot = technologies["Certbot"];
        var github = technologies["GitHub"];
        var jira = technologies["Jira"];

        var frontend = html.Categories.Single(c => c.Name == "Frontend");
        var backend = kotlin.Categories.Single(c => c.Name == "Backend");
        var devOps = docker.Categories.Single(c => c.Name == "DevOps");

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

    private static async Task SeedAboutProfileAsync(PortfolioDbContext context)
{
    if (await context.AboutProfiles.AnyAsync())
        return;

    context.AboutProfiles.AddRange(
        new AboutProfile
        {
            Language = "nl",
            Description =
                """
                Mijn naam is **Giel** en ik werk als **Linux Engineer**. Na jaren met plezier in de culturele sector te hebben gewerkt, heb ik de overstap gemaakt naar de **informatica**. Daarnaast volg ik de **bachelor Informatica** aan Avans Hogeschool.

                In mijn werk houd ik me bezig met **Linux**, infrastructuur en automatisering. Daarnaast ontwikkel ik software en werk ik onder andere met **C#**, **React** en **Kotlin**.

                Ik werk graag vanuit duidelijke **requirements** en volgens **OTAP-principes**, met aandacht voor **CI/CD**, testen en onderhoudbaarheid. Ik geloof in de tijd nemen om iets goed op te zetten, zodat software ook op langere termijn begrijpelijk en beheersbaar blijft.

                Ik ben nieuwsgierig van aard en vind het interessant om de volledige technische keten te begrijpen: van infrastructuur en deployment tot backend en frontend.
                """,
            ImagePath = "/media/giel2.webp"
        },

        new AboutProfile
        {
            Language = "en",
            Description =
                """
                My name is **Giel** and I work as a **Linux Engineer**. After spending several years working in the cultural sector, I made the transition into **computer science**. I am also studying for a **Bachelor's degree in Computer Science** at Avans University of Applied Sciences.

                In my work I focus on **Linux**, infrastructure and automation. Alongside that, I develop software using technologies including **C#**, **React** and **Kotlin**.

                I like working from clear **requirements** and following **DTAP principles**, with attention to **CI/CD**, testing and maintainability. I believe that taking the time to build something properly saves time when software needs to be maintained or extended later.

                I am naturally curious and enjoy understanding the complete technical chain: from infrastructure and deployment to backend and frontend development.
                """,
            ImagePath = "/media/giel2.webp"
        }
    );

    await context.SaveChangesAsync();
}
    
    private static async Task SeedEducationAsync(PortfolioDbContext context)
{
    if (await context.Educations.AnyAsync())
        return;

    var technologies = await context.Technologies
        .ToDictionaryAsync(x => x.Name);

    var skills = await context.Skills
        .ToDictionaryAsync(x => x.Name);

    var tooling = await context.Tooling
        .ToDictionaryAsync(x => x.Name);

    var redhat = new Education
    {
        Institution = "Red Hat",
        Program = "RHCSA",
        StartYear = 2026,
        EndYear = null,
        SortOrder = 1,
        
        Media = CreateImage(
            "/media/education/redhat.webp",
            "Red Hat RHCSA"),
        
        Sections =
        [
            new EducationSection
            {
                Title = null,
                SortOrder = 1,

                Technologies =
                [
                    technologies["Python"],
                    technologies["JavaScript"],
                    technologies["HTML"],
                    technologies["CSS"],
                    technologies["MySQL"]
                ],

                Skills =
                [
                    skills["UI/UX"]
                ]
            }
        ]
    };
    
    var avans = new Education
    {
        Institution = "Avans Hogeschool",
        Program = "Deeltijdopleiding Informatica",
        StartYear = 2024,
        EndYear = null,
        SortOrder = 2,

        Media = CreateImage(
            "/media/education/avans.webp",
            "Avans Hogeschool logo"),

        Sections =
        [
            new EducationSection
            {
                Title = "Leerjaar 2",
                SortOrder = 1,

                Technologies =
                [
                    technologies["Kotlin"],
                    technologies["Ktor"]
                ],

                Skills =
                [
                    skills["Functioneel programmeren"],
                    skills["Software testing"],
                    skills["Agile werken"],
                    skills["Scrum"],
                    skills["Design patterns"]
                ],

                Tooling =
                [
                    tooling["Gradle"],
                    tooling["GitHub Actions"]
                ]
            },

            new EducationSection
            {
                Title = "Leerjaar 1",
                SortOrder = 2,

                Technologies =
                [
                    technologies["PHP"],
                    technologies["MySQL"],
                    technologies["JavaScript"],
                    technologies["HTML"],
                    technologies["CSS"],
                    technologies["UML"]
                ],

                Skills =
                [
                    skills["Projectmatig werken"],
                    skills["Systeemontwerp"],
                    skills["Softwarearchitectuur"],
                    skills["Databaseontwerp"],
                    skills["CI/CD-pipelines"],
                    skills["Objectgeoriënteerd programmeren"]
                ],

                Tooling =
                [
                    tooling["Git"],
                    tooling["Jira"]
                ]
            }
        ]
    };

    var codecademy = new Education
    {
        Institution = "Codecademy",
        Program = "Web Development",
        StartYear = 2023,
        EndYear = null,
        SortOrder = 3,

        Media = CreateImage(
            "/media/education/codecademy.webp",
            "Codecademy logo"),

        Sections =
        [
            new EducationSection
            {
                Title = null,
                SortOrder = 1,

                Technologies =
                [
                    technologies["Python"],
                    technologies["JavaScript"],
                    technologies["HTML"],
                    technologies["CSS"],
                    technologies["MySQL"]
                ],

                Skills =
                [
                    skills["UI/UX"]
                ]
            }
        ]
    };

    var albeda = new Education
    {
        Institution = "Albeda College",
        Program = "Muzikant / Producer",
        StartYear = 2012,
        EndYear = 2015,
        SortOrder = 4,

        Media = CreateImage(
            "/media/education/albeda.png",
            "Albeda College logo"),

        Sections =
        [
            new EducationSection
            {
                Title = null,
                SortOrder = 1,

                Skills =
                [
                    skills["Projectmatig werken"],
                    skills["Creatief ondernemen"],
                    skills["Samenwerken"],
                    skills["Presentatievaardigheden"],
                    skills["Marketing en communicatie"]
                ]
            }
        ]
    };

    var koningWillem = new Education
    {
        Institution = "Koning Willem 1 College",
        Program = "Sociaal Cultureel Werk",
        StartYear = 2004,
        EndYear = 2009,
        SortOrder = 5,

        Media = CreateImage(
            "/media/education/kw1c.png",
            "Koning Willem 1 College logo"),

        Sections =
        [
            new EducationSection
            {
                Title = null,
                SortOrder = 1,

                Skills =
                [
                    skills["Methodisch werken"],
                    skills["Sociale vaardigheden"],
                    skills["Projectmatig werken"],
                    skills["Samenwerken"],
                    skills["Presentatievaardigheden"]
                ]
            }
        ]
    };

    context.Educations.AddRange(
        redhat,
        avans,
        codecademy,
        albeda,
        koningWillem);

    await context.SaveChangesAsync();
}
    
    private static async Task SeedWorkExperienceAsync(
    PortfolioDbContext context)
{
    if (await context.WorkExperiences.AnyAsync())
        return;

    var technologies = await context.Technologies
        .ToDictionaryAsync(x => x.Name);

    var skills = await context.Skills
        .ToDictionaryAsync(x => x.Name);

    var tooling = await context.Tooling
        .ToDictionaryAsync(x => x.Name);

    var bcs = new WorkExperience
    {
        Company = "BCS HR Solutions",
        Role = "Software Support Specialist",
        StartYear = null,
        EndYear = null,
        SortOrder = 1,

        Media = CreateImage(
            "/media/work-experience/bcs.webp",
            "BCS HR Solutions logo"),

        Responsibilities =
        [
            new WorkExperienceResponsibility
            {
                Description = "Ondersteunen van gebruikers bij softwareproblemen",
                SortOrder = 1
            },
            new WorkExperienceResponsibility
            {
                Description = "Analyseren en oplossen van technische issues",
                SortOrder = 2
            },
            new WorkExperienceResponsibility
            {
                Description = "Documenteren van oplossingen en processen",
                SortOrder = 3
            },
            new WorkExperienceResponsibility
            {
                Description = "Samenwerken met ontwikkelteams voor bugfixes",
                SortOrder = 4
            },
            new WorkExperienceResponsibility
            {
                Description = "Testen van nieuwe softwareversies",
                SortOrder = 5
            }
        ],

        Technologies =
        [
            technologies["REST API"],
            technologies["SOAP"]
        ],

        Skills =
        [
            skills["Software testing"],
            skills["Helder documenteren"],
            skills["Samenwerken"],
            skills["Oplossingsgericht denken"]
        ],

        Tooling =
        [
            tooling["Jira"],
            tooling["Confluence"],
            tooling["Zendesk"],
            tooling["GitLab"],
            tooling["Postman"],
            tooling["WinSCP"],
            tooling["Microsoft Dynamics 365"]
        ]
    };

    var gemeenteRotterdam = new WorkExperience
    {
        Company = "Gemeente Rotterdam",
        Role = "Senior Klantcontact Centrum",
        StartYear = null,
        EndYear = null,
        SortOrder = 2,

        Media = CreateImage(
            "/media/work-experience/gemeente-rotterdam.webp",
            "Gemeente Rotterdam logo"),

        Responsibilities =
        [
            new WorkExperienceResponsibility
            {
                Description = "Aanpakken van complexe klantvragen en problemen",
                SortOrder = 1
            },
            new WorkExperienceResponsibility
            {
                Description = "Begeleiden en coachen van teamleden",
                SortOrder = 2
            },
            new WorkExperienceResponsibility
            {
                Description = "Optimaliseren van werkprocessen",
                SortOrder = 3
            },
            new WorkExperienceResponsibility
            {
                Description = "Communiceren met diverse afdelingen",
                SortOrder = 4
            },
            new WorkExperienceResponsibility
            {
                Description = "Bijdragen aan klanttevredenheid en servicekwaliteit",
                SortOrder = 5
            }
        ],

        Skills =
        [
            skills["Effectief communiceren"],
            skills["Samenwerken"],
            skills["Oplossingsgericht denken"],
            skills["Klantgericht"],
            skills["Plannen en structureren"]
        ],

        Tooling =
        [
            tooling["Klantbeeld"],
            tooling["Microsoft Outlook"],
            tooling["Microsoft Agenda"],
            tooling["Microsoft Excel"],
            tooling["Microsoft Word"]
        ]
    };

    context.WorkExperiences.AddRange(
        bcs,
        gemeenteRotterdam);

    await context.SaveChangesAsync();
}
    
    private static async Task SeedLibraryItemsAsync(
    PortfolioDbContext context)
{
    if (await context.LibraryItems.AnyAsync())
        return;

    var technologies = await context.Technologies
        .ToDictionaryAsync(x => x.Name);

    var skills = await context.Skills
        .ToDictionaryAsync(x => x.Name);

    var tooling = await context.Tooling
        .ToDictionaryAsync(x => x.Name);

    var htmlCss = new LibraryItem
    {
        Title = "HTML 5 en CSS",
        Creator = "Peter Doolaard",
        Type = LibraryItemType.Book,
        SortOrder = 1,

        Media = CreateImage(
            "/media/library/htmlencss-doolaard.webp",
            "Boekcover HTML 5 en CSS van Peter Doolaard"),

        Technologies =
        [
            technologies["HTML"],
            technologies["CSS"]
        ]
    };

    var informatiemanagement = new LibraryItem
    {
        Title = "Informatiemanagement",
        Creator = "Roel Grit",
        Type = LibraryItemType.Book,
        SortOrder = 2,

        Media = CreateImage(
            "/media/library/informatiemanagement-grit.webp",
            "Boekcover Informatiemanagement van Roel Grit")
    };

    var inleidingDatabases = new LibraryItem
    {
        Title = "Inleiding databases",
        Creator = "Ben Groenendijk",
        Type = LibraryItemType.Book,
        SortOrder = 3,

        Media = CreateImage(
            "/media/library/inleidingdatabases-groenendijk.webp",
            "Boekcover Inleiding databases van Ben Groenendijk"),

        Skills =
        [
            skills["Databaseontwerp"]
        ]
    };

    var devOpsForTheDesperate = new LibraryItem
    {
        Title = "DevOps for the Desperate",
        Creator = "Bradley Smith",
        Type = LibraryItemType.Book,
        SortOrder = 4,

        Media = CreateImage(
            "/media/library/devops-for-the-desperate.webp",
            "Boekcover DevOps for the Desperate van Bradley Smith")
    };

    var javascriptJquery = new LibraryItem
    {
        Title = "JavaScript & jQuery",
        Creator = "Peter Kassenaar",
        Type = LibraryItemType.Book,
        SortOrder = 5,

        Media = CreateImage(
            "/media/library/javascript&jquery-kassenaar.webp",
            "Boekcover JavaScript & jQuery van Peter Kassenaar"),

        Technologies =
        [
            technologies["JavaScript"]
        ]
    };

    var praktischUml = new LibraryItem
    {
        Title = "Praktisch UML",
        Creator = "Jos Warmer & Anneke Kleppe",
        Type = LibraryItemType.Book,
        SortOrder = 6,

        Media = CreateImage(
            "/media/library/praktischuml-warmer-kleppe.webp",
            "Boekcover Praktisch UML van Jos Warmer & Anneke Kleppe"),

        Technologies =
        [
            technologies["UML"]
        ],

        Skills =
        [
            skills["Objectgeoriënteerd programmeren"],
            skills["Systeemontwerp"]
        ]
    };

    var pythonCrashCourse = new LibraryItem
    {
        Title = "Python Crash Course",
        Creator = "Eric Matthes",
        Type = LibraryItemType.Book,
        SortOrder = 7,

        Media = CreateImage(
            "/media/library/pythoncrashcourse-matthes.webp",
            "Boekcover Python Crash Course van Eric Matthes"),

        Technologies =
        [
            technologies["Python"]
        ]
    };

    var subliemWebdesign = new LibraryItem
    {
        Title = "Principes van subliem webdesign",
        Creator = "Jason Beaird & James George",
        Type = LibraryItemType.Book,
        SortOrder = 8,

        Media = CreateImage(
            "/media/library/subliemwebdesign.webp",
            "Boekcover Principes van subliem webdesign van Jason Beaird & James George"),

        Skills =
        [
            skills["UI/UX"]
        ]
    };

    var linuxCommandLine = new LibraryItem
    {
        Title = "The Linux Command Line",
        Creator = "William Shotts",
        Type = LibraryItemType.Book,
        SortOrder = 9,

        Media = CreateImage(
            "/media/library/linuxcommandline.webp",
            "Boekcover The Linux Command Line van William Shotts"),

        Technologies =
        [
            technologies["Terminal"]
        ]
    };

    var grafischOntwerpen = new LibraryItem
    {
        Title = "Grafisch Ontwerpen",
        Creator = "David Dabner & Sandra Stewart",
        Type = LibraryItemType.Book,
        SortOrder = 10,

        Media = CreateImage(
            "/media/library/grafischontwerpen.webp",
            "Boekcover Grafisch Ontwerpen van David Dabner & Sandra Stewart"),

        Skills =
        [
            skills["UI/UX"]
        ]
    };

    var thisIsIt = new LibraryItem
    {
        Title = "This is IT!",
        Creator = "Victor Peters",
        Type = LibraryItemType.Book,
        SortOrder = 11,

        Media = CreateImage(
            "/media/library/thisisit.webp",
            "Boekcover This is IT! van Victor Peters")
    };

    var wordpress6 = new LibraryItem
    {
        Title = "Handboek Wordpress 6",
        Creator = "Dirkjan van Ittersum",
        Type = LibraryItemType.Book,
        SortOrder = 12,

        Media = CreateImage(
            "/media/library/wordpress6.webp",
            "Boekcover Handboek Wordpress 6 van Dirkjan van Ittersum"),

        Technologies =
        [
            technologies["HTML"],
            technologies["CSS"],
            technologies["PHP"],
            technologies["MySQL"]
        ]
    };

    var inleidingUml = new LibraryItem
    {
        Title = "Inleiding UML",
        Creator = "Hendrik Jan van Randen",
        Type = LibraryItemType.Book,
        SortOrder = 13,

        Media = CreateImage(
            "/media/library/inleidinguml.webp",
            "Boekcover Inleiding UML van Hendrik Jan van Randen"),

        Technologies =
        [
            technologies["UML"]
        ],

        Skills =
        [
            skills["Objectgeoriënteerd programmeren"],
            skills["Systeemontwerp"]
        ]
    };

    var principesVanDatabases = new LibraryItem
    {
        Title = "Principes van Databases",
        Creator = "Guy Tré",
        Type = LibraryItemType.Book,
        SortOrder = 14,

        Media = CreateImage(
            "/media/library/principes-van-databases.webp",
            "Boekcover Principes van Databases van Guy Tré"),

        Skills =
        [
            skills["Databaseontwerp"]
        ]
    };

    var creativeAct = new LibraryItem
    {
        Title = "The Creative Act",
        Creator = "Rick Rubin",
        Type = LibraryItemType.Book,
        SortOrder = 15,

        Media = CreateImage(
            "/media/library/the-creative-act.webp",
            "Boekcover The Creative Act van Rick Rubin"),

        Skills =
        [
            skills["Creativiteit"]
        ]
    };

    var kotlinInAction = new LibraryItem
    {
        Title = "Kotlin in Action",
        Creator = "Dmitry Jemerov",
        Type = LibraryItemType.Book,
        SortOrder = 16,

        Media = CreateImage(
            "/media/library/kotlin-in-action.webp",
            "Boekcover Kotlin in Action van Dmitry Jemerov"),

        Technologies =
        [
            technologies["Kotlin"]
        ],

        Skills =
        [
            skills["Objectgeoriënteerd programmeren"]
        ]
    };

    var shellScripting = new LibraryItem
    {
        Title = "Shell Scripting",
        Creator = "Steve Parker",
        Type = LibraryItemType.Book,
        SortOrder = 17,

        Media = CreateImage(
            "/media/library/shell-scripting.webp",
            "Boekcover Shell Scripting van Steve Parker"),

        Technologies =
        [
            technologies["Terminal"]
        ]
    };

    var krachtVanHetNu = new LibraryItem
    {
        Title = "De kracht van het Nu",
        Creator = "Eckhart Tolle",
        Type = LibraryItemType.Book,
        SortOrder = 18,

        Media = CreateImage(
            "/media/library/de-kracht-van-het-nu.webp",
            "Boekcover De kracht van het Nu van Eckhart Tolle")
    };

    context.LibraryItems.AddRange(
        htmlCss,
        informatiemanagement,
        inleidingDatabases,
        devOpsForTheDesperate,
        javascriptJquery,
        praktischUml,
        pythonCrashCourse,
        subliemWebdesign,
        linuxCommandLine,
        grafischOntwerpen,
        thisIsIt,
        wordpress6,
        inleidingUml,
        principesVanDatabases,
        creativeAct,
        kotlinInAction,
        shellScripting,
        krachtVanHetNu);

    await context.SaveChangesAsync();
}
    
    private static async Task SeedContactAsync(
        PortfolioDbContext context)
    {
        if (await context.Contacts.AnyAsync())
            return;

        context.Contacts.AddRange(
            new Contact
            {
                Language = "nl",

                Name = "Giel van Gaal",
                Phone = "06-13383313",
                Email = "gielvangaal@gmail.com",
                Location = "'s-Hertogenbosch",

                GitHubUrl = "https://github.com/",
                LinkedInUrl = "https://www.linkedin.com/",
                InstagramUrl = "https://www.instagram.com/",
                SpotifyUrl = "https://open.spotify.com/",

                CreditText = "Ontwerp en realisatie: Giel van Gaal"
            },

            new Contact
            {
                Language = "en",

                Name = "Giel van Gaal",
                Phone = "06-13383313",
                Email = "gielvangaal@gmail.com",
                Location = "'s-Hertogenbosch",

                GitHubUrl = "https://github.com/",
                LinkedInUrl = "https://www.linkedin.com/",
                InstagramUrl = "https://www.instagram.com/",
                SpotifyUrl = "https://open.spotify.com/",

                CreditText = "Design and development: Giel van Gaal"
            }
        );

        await context.SaveChangesAsync();
    }
    
    // Helpers
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