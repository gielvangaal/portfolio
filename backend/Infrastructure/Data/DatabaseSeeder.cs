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
        await SeedOrganizationsAsync(context);

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
        new Technology { Name = "Argo CD", Usage = CapabilityUsage.Regular, Categories = [devOps], Media = CreateImage("/media/webstack/placeholder.webp", "Argo CD logo") },
        new Technology { Name = "Helm", Usage = CapabilityUsage.Regular, Categories = [devOps], Media = CreateImage("/media/webstack/placeholder.webp", "Helm logo") },
        new Technology { Name = "Prometheus", Usage = CapabilityUsage.Regular, Categories = [devOps], Media = CreateImage("/media/webstack/placeholder.webp", "Prometheus logo") },
        new Technology { Name = "Grafana", Usage = CapabilityUsage.Regular, Categories = [devOps], Media = CreateImage("/media/webstack/placeholder.webp", "Grafana logo") },
        new Technology { Name = "Restic", Usage = CapabilityUsage.Regular, Categories = [devOps], Media = CreateImage("/media/webstack/placeholder.webp", "Restic logo") },
        new Technology { Name = "pandas", Usage = CapabilityUsage.Occasional, Categories = [backend], Media = CreateImage("/media/webstack/placeholder.webp", "pandas logo") },
        new Technology { Name = "NumPy", Usage = CapabilityUsage.Occasional, Categories = [backend], Media = CreateImage("/media/webstack/placeholder.webp", "NumPy logo") },
        new Technology { Name = "DAX", Usage = CapabilityUsage.Occasional, Categories = [backend], Media = CreateImage("/media/webstack/placeholder.webp", "DAX logo") },
        new Technology { Name = "Power Query", Usage = CapabilityUsage.Occasional, Categories = [backend], Media = CreateImage("/media/webstack/placeholder.webp", "Power Query logo") },
        new Technology { Name = "Matplotlib", Usage = CapabilityUsage.Occasional, Categories = [backend], Media = CreateImage("/media/webstack/placeholder.webp", "Matplotlib logo") },
        new Technology { Name = "Seaborn", Usage = CapabilityUsage.Occasional, Categories = [backend], Media = CreateImage("/media/webstack/placeholder.webp", "Seaborn logo") },
        new Technology { Name = "Plotly", Usage = CapabilityUsage.Occasional, Categories = [backend], Media = CreateImage("/media/webstack/placeholder.webp", "Plotly logo") },
        new Technology { Name = "Altair", Usage = CapabilityUsage.Occasional, Categories = [backend], Media = CreateImage("/media/webstack/placeholder.webp", "Altair logo") },
        new Technology { Name = "Folium", Usage = CapabilityUsage.Occasional, Categories = [backend], Media = CreateImage("/media/webstack/placeholder.webp", "Folium logo") },
        new Technology
        {
            Name = "HTML",
            Usage = CapabilityUsage.Regular,
            Categories = [frontend],
            Media = CreateImage(
                "/media/webstack/html5.webp",
                "HTML-logo")
        },
        new Technology
        {
            Name = "CSS",
            Usage = CapabilityUsage.Regular,
            Categories = [frontend],
            Media = CreateImage(
                "/media/webstack/css3.webp",
                "CSS-logo")
        },
        new Technology
        {
            Name = "SOAP",
            Usage = CapabilityUsage.Past,
            Categories = [backend],
            Media = CreateImage(
                "/media/webstack/soap-api.webp",
            "SOAP API-logo")
        },
        new Technology
        {
            Name = "JavaScript",
            Usage = CapabilityUsage.Regular,
            Categories = [frontend],
            Media = CreateImage(
                "/media/webstack/javascript.webp",
                "JavaScript-logo")
        },
        new Technology
        {
            Name = "Bootstrap",
            Usage = CapabilityUsage.Occasional,
            Categories = [frontend],
            Media = CreateImage(
                "/media/webstack/bootstrap.webp",
                "Bootstrap-logo")
        },
        new Technology
        {
            Name = "PHP",
            Usage = CapabilityUsage.Occasional,
            Categories = [backend],
            Media = CreateImage(
                "/media/webstack/php.webp",
                "PHP-logo")
        },
        new Technology
        {
            Name = "MySQL",
            Usage = CapabilityUsage.Daily,
            Categories = [backend],
            Media = CreateImage(
                "/media/webstack/mysql.webp",
                "MySQL-logo")
        },
        new Technology
        {
            Name = "Kotlin",
            Usage = CapabilityUsage.Occasional,
            Categories = [backend],
            Media = CreateImage(
                "/media/webstack/kotlin.webp",
                "Kotlin-logo")
        },
        new Technology
        {
            Name = "Ktor",
            Usage = CapabilityUsage.Occasional,
            Categories = [backend],
            Media = CreateImage(
                "/media/webstack/ktor.webp",
                "Ktor-logo")
        },
        new Technology
        {
            Name = "Exposed",
            Usage = CapabilityUsage.Occasional,
            Categories = [backend],
            Media = CreateImage(
                "/media/webstack/exposed.webp",
                "Exposed-logo")
        },
        new Technology
        {
            Name = "Python",
            Usage = CapabilityUsage.Daily,
            Categories = [backend],
            Media = CreateImage(
                "/media/webstack/python.webp",
                "Python-logo")
        },
        new Technology
        {
            Name = "Django",
            Usage = CapabilityUsage.Occasional,
            Categories = [backend],
            Media = CreateImage(
                "/media/webstack/django.webp",
                "Django-logo")
        },
        new Technology
        {
            Name = "Docker",
            Usage = CapabilityUsage.Daily,
            Categories = [devOps],
            Media = CreateImage(
                "/media/webstack/docker.webp",
                "Docker-logo")
        },
        new Technology
        {
            Name = "FFmpeg",
            Usage = CapabilityUsage.Occasional,
            Categories = [backend],
            Media = CreateImage(
                "/media/webstack/ffmpeg.webp",
                "FFmpeg-logo")
        },
        new Technology
        {
            Name = "Node.js",
            Usage = CapabilityUsage.Occasional,
            Categories = [backend],
            Media = CreateImage(
                "/media/webstack/node-js.webp",
                "Node.js-logo")
        },
        new Technology
        {
            Name = "REST API",
            Usage = CapabilityUsage.Regular,
            Categories = [backend],
            Media = CreateImage(
                "/media/webstack/rest-api.webp",
                "REST API-logo")
        },
        new Technology
        {
            Name = "C#",
            Usage = CapabilityUsage.Daily,
            Categories = [backend],
            Media = CreateImage(
                "/media/webstack/csharp.webp",
                "C# logo")
        },
        new Technology
        {
            Name = ".NET",
            Usage = CapabilityUsage.Daily,
            Categories = [backend],
            Media = CreateImage(
                "/media/webstack/dotnet.webp",
                ".NET-logo")
        },
        new Technology
        {
            Name = "Blazor",
            Usage = CapabilityUsage.Occasional,
            Categories = [frontend],
            Media = CreateImage(
                "/media/webstack/blazor.webp",
                "Blazor-logo")
        },
        new Technology
        {
            Name = "MudBlazor",
            Usage = CapabilityUsage.Occasional,
            Categories = [frontend],
            Media = CreateImage(
                "/media/webstack/mudblazor.webp",
                "MudBlazor-logo")
        },
        new Technology
        {
            Name = ".NET MAUI",
            Usage = CapabilityUsage.Occasional,
            Categories = [frontend],
            Media = CreateImage(
                "/media/webstack/dotnet-maui.webp",
                ".NET-logo")
        },
        new Technology
        {
            Name = "ASP.NET Core",
            Usage = CapabilityUsage.Regular,
            Categories = [backend],
            Media = CreateImage(
                "/media/webstack/asp-dotnet-core.webp",
                "ASP.NET-logo")
        },
        new Technology
        {
            Name = "Jetpack Compose",
            Usage = CapabilityUsage.Occasional,
            Categories = [frontend],
            Media = CreateImage(
                "/media/webstack/jetpack-compose.webp",
                "Jetpack-compose-logo")
        },
        new Technology
        {
            Name = "Linux",
            Usage = CapabilityUsage.Daily,
            Categories = [devOps],
            Media = CreateImage(
                "/media/webstack/linux.webp",
                "Linux-logo")
        },
        new Technology
        {
            Name = "RHEL",
            Usage = CapabilityUsage.Regular,
            Categories = [devOps],
            Media = CreateImage(
                "/media/webstack/rhel.webp",
                "Rhel-logo")
        },
        new Technology
        {
            Name = "Ansible",
            Usage = CapabilityUsage.Daily,
            Categories = [devOps],
            Media = CreateImage(
                "/media/webstack/ansible.webp",
                "Ansible-logo")
        },
        new Technology
        {
            Name = "Kubernetes",
            Usage = CapabilityUsage.Regular,
            Categories = [devOps],
            Media = CreateImage(
                "/media/webstack/kubernetes.webp",
                "Kubernetes-logo")
        },
        new Technology
        {
            Name = "K3s",
            Usage = CapabilityUsage.Regular,
            Categories = [devOps],
            Media = CreateImage(
                "/media/webstack/k3s.webp",
                "K3s-logo")
        },
        new Technology
        {
            Name = "Cilium",
            Usage = CapabilityUsage.Regular,
            Categories = [devOps],
            Media = CreateImage(
                "/media/webstack/cilium.webp",
                "Cilium-logo")
        },
        new Technology
        {
            Name = "Elasticsearch",
            Usage = CapabilityUsage.Daily,
            Categories = [backend],
            Media = CreateImage(
                "/media/webstack/elasticsearch.webp",
                "Elasticsearch-logo")
        },
        new Technology
        {
            Name = "Bash",
            Usage = CapabilityUsage.Daily,
            Categories = [devOps],
            Media = CreateImage(
                "/media/webstack/bash.webp",
                "Bash-logo")
        },
        new Technology
        {
            Name = "Selinux",
            Usage = CapabilityUsage.Occasional,
            Categories = [devOps],
            Media = CreateImage(
                "/media/webstack/selinux.webp",
                "Selinux-logo")
        },
        new Technology
        {
            Name = "UML",
            Usage = CapabilityUsage.Occasional,
            Categories = [backend],
            Media = CreateImage(
                "/media/webstack/uml.webp",
                "UML-logo")
        },
        new Technology
        {
            Name = "React",
            Usage = CapabilityUsage.Regular,
            Categories = [frontend],
            Media = CreateImage(
                "/media/webstack/react.webp",
                "React-logo")
        },
        new Technology
        {
            Name = "SUSE Linux Enterprise",
            Usage = CapabilityUsage.Daily,
            Categories = [devOps],
            Media = CreateImage(
                "/media/webstack/opensuse.webp",
                "SUSE Linux Enterprise logo")
        },
        new Technology
        {
            Name = "openSUSE Tumbleweed",
            Usage = CapabilityUsage.Daily,
            Categories = [devOps],
            Media = CreateImage(
                "/media/webstack/opensuse-tumbleweed.webp",
                "openSUSE Tumbleweed logo")
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
                Key = "etl",
                Translations =
                [
                    new SkillTranslation { Language = "nl", Name = "ETL" },
                    new SkillTranslation { Language = "en", Name = "ETL" }
                ],
                Type = SkillType.Technical
            },
            new Skill
            {
                Key = "business-intelligence",
                Translations =
                [
                    new SkillTranslation { Language = "nl", Name = "Business Intelligence" },
                    new SkillTranslation { Language = "en", Name = "Business Intelligence" }
                ],
                Type = SkillType.Technical
            },
            new Skill
            {
                Key = "data-modeling",
                Translations =
                [
                    new SkillTranslation { Language = "nl", Name = "Datamodellering" },
                    new SkillTranslation { Language = "en", Name = "Data modeling" }
                ],
                Type = SkillType.Technical
            },
            new Skill
            {
                Key = "data-visualization",
                Translations =
                [
                    new SkillTranslation { Language = "nl", Name = "Datavisualisatie" },
                    new SkillTranslation { Language = "en", Name = "Data visualization" }
                ],
                Type = SkillType.Technical
            },
            new Skill
            {
                Key = "data-validation",
                Translations =
                [
                    new SkillTranslation { Language = "nl", Name = "Datavalidatie" },
                    new SkillTranslation { Language = "en", Name = "Data validation" }
                ],
                Type = SkillType.Technical
            },
            new Skill
            {
                Key = "functional-programming",
                Translations =
                [
                    new SkillTranslation { Language = "nl", Name = "Functioneel programmeren" },
                    new SkillTranslation { Language = "en", Name = "Functional programming" }
                ],
                Type = SkillType.Technical
            },
            new Skill
            {
                Key = "software-testing",
                Translations =
                [
                    new SkillTranslation { Language = "nl", Name = "Software testing" },
                    new SkillTranslation { Language = "en", Name = "Software testing" }
                ],
                Type = SkillType.Technical
            },
            new Skill
            {
                Key = "agile-working",
                Translations =
                [
                    new SkillTranslation { Language = "nl", Name = "Agile werken" },
                    new SkillTranslation { Language = "en", Name = "Agile working" }
                ],
                Type = SkillType.SoftSkill
            },
            new Skill
            {
                Key = "scrum",
                Translations =
                [
                    new SkillTranslation { Language = "nl", Name = "Scrum" },
                    new SkillTranslation { Language = "en", Name = "Scrum" }
                ],
                Type = SkillType.SoftSkill
            },
            new Skill
            {
                Key = "design-patterns",
                Translations =
                [
                    new SkillTranslation { Language = "nl", Name = "Design patterns" },
                    new SkillTranslation { Language = "en", Name = "Design patterns" }
                ],
                Type = SkillType.Technical
            },
            new Skill
            {
                Key = "project-based-working",
                Translations =
                [
                    new SkillTranslation { Language = "nl", Name = "Projectmatig werken" },
                    new SkillTranslation { Language = "en", Name = "Project-based working" }
                ],
                Type = SkillType.SoftSkill
            },
            new Skill
            {
                Key = "system-design",
                Translations =
                [
                    new SkillTranslation { Language = "nl", Name = "Systeemontwerp" },
                    new SkillTranslation { Language = "en", Name = "System design" }
                ],
                Type = SkillType.Technical
            },
            new Skill
            {
                Key = "software-architecture",
                Translations =
                [
                    new SkillTranslation { Language = "nl", Name = "Softwarearchitectuur" },
                    new SkillTranslation { Language = "en", Name = "Software architecture" }
                ],
                Type = SkillType.Technical
            },
            new Skill
            {
                Key = "database-design",
                Translations =
                [
                    new SkillTranslation { Language = "nl", Name = "Databaseontwerp" },
                    new SkillTranslation { Language = "en", Name = "Database design" }
                ],
                Type = SkillType.Technical
            },
            new Skill
            {
                Key = "ci-cd-pipelines",
                Translations =
                [
                    new SkillTranslation { Language = "nl", Name = "CI/CD-pipelines" },
                    new SkillTranslation { Language = "en", Name = "CI/CD pipelines" }
                ],
                Type = SkillType.Technical
            },
            new Skill
            {
                Key = "object-oriented-programming",
                Translations =
                [
                    new SkillTranslation { Language = "nl", Name = "Objectgeoriënteerd programmeren" },
                    new SkillTranslation { Language = "en", Name = "Object-oriented programming" }
                ],
                Type = SkillType.Technical
            },

            // Softskills - vaardigheden

            new Skill
            {
                Key = "practical-mindset",
                Translations =
                [
                    new SkillTranslation { Language = "nl", Name = "Praktische instelling" },
                    new SkillTranslation { Language = "en", Name = "Practical mindset" }
                ],
                Type = SkillType.SoftSkill
            },
            new Skill
            {
                Key = "interpersonal-skills",
                Translations =
                [
                    new SkillTranslation { Language = "nl", Name = "Sociale vaardigheden" },
                    new SkillTranslation { Language = "en", Name = "Interpersonal skills" }
                ],
                Type = SkillType.SoftSkill
            },
            new Skill
            {
                Key = "independence",
                Translations =
                [
                    new SkillTranslation { Language = "nl", Name = "Zelfstandigheid" },
                    new SkillTranslation { Language = "en", Name = "Independence" }
                ],
                Type = SkillType.SoftSkill
            },
            new Skill
            {
                Key = "accuracy-and-precision",
                Translations =
                [
                    new SkillTranslation { Language = "nl", Name = "Nauwkeurig en exact" },
                    new SkillTranslation { Language = "en", Name = "Accuracy and precision" }
                ],
                Type = SkillType.SoftSkill
            },
            new Skill
            {
                Key = "planning-and-organization",
                Translations =
                [
                    new SkillTranslation { Language = "nl", Name = "Plannen en structureren" },
                    new SkillTranslation { Language = "en", Name = "Planning and organization" }
                ],
                Type = SkillType.SoftSkill
            },
            new Skill
            {
                Key = "effective-communication",
                Translations =
                [
                    new SkillTranslation { Language = "nl", Name = "Effectief communiceren" },
                    new SkillTranslation { Language = "en", Name = "Effective communication" }
                ],
                Type = SkillType.SoftSkill
            },
            new Skill
            {
                Key = "quick-learning-and-application",
                Translations =
                [
                    new SkillTranslation { Language = "nl", Name = "Snel leren en toepassen" },
                    new SkillTranslation { Language = "en", Name = "Quick learning and application" }
                ],
                Type = SkillType.SoftSkill
            },
            new Skill
            {
                Key = "clear-documentation",
                Translations =
                [
                    new SkillTranslation { Language = "nl", Name = "Helder documenteren" },
                    new SkillTranslation { Language = "en", Name = "Clear documentation" }
                ],
                Type = SkillType.SoftSkill
            },

            // Softskills - competenties

            new Skill
            {
                Key = "solution-oriented-thinking",
                Translations =
                [
                    new SkillTranslation { Language = "nl", Name = "Oplossingsgericht denken" },
                    new SkillTranslation { Language = "en", Name = "Solution-oriented thinking" }
                ],
                Type = SkillType.SoftSkill
            },
            new Skill
            {
                Key = "energy",
                Translations =
                [
                    new SkillTranslation { Language = "nl", Name = "Energie" },
                    new SkillTranslation { Language = "en", Name = "Energy" }
                ],
                Type = SkillType.SoftSkill
            },
            new Skill
            {
                Key = "empathy",
                Translations =
                [
                    new SkillTranslation { Language = "nl", Name = "Empathie" },
                    new SkillTranslation { Language = "en", Name = "Empathy" }
                ],
                Type = SkillType.SoftSkill
            },
            new Skill
            {
                Key = "creativity",
                Translations =
                [
                    new SkillTranslation { Language = "nl", Name = "Creativiteit" },
                    new SkillTranslation { Language = "en", Name = "Creativity" }
                ],
                Type = SkillType.SoftSkill
            },
            new Skill
            {
                Key = "analytical-thinking",
                Translations =
                [
                    new SkillTranslation { Language = "nl", Name = "Analytisch vermogen" },
                    new SkillTranslation { Language = "en", Name = "Analytical thinking" }
                ],
                Type = SkillType.SoftSkill
            },
            new Skill
            {
                Key = "independent-learning",
                Translations =
                [
                    new SkillTranslation { Language = "nl", Name = "Zelfstandig leren" },
                    new SkillTranslation { Language = "en", Name = "Independent learning" }
                ],
                Type = SkillType.SoftSkill
            },
            new Skill
            {
                Key = "quality-awareness",
                Translations =
                [
                    new SkillTranslation { Language = "nl", Name = "Kwaliteitsbewustzijn" },
                    new SkillTranslation { Language = "en", Name = "Quality awareness" }
                ],
                Type = SkillType.SoftSkill
            },
            new Skill
            {
                Key = "adaptability",
                Translations =
                [
                    new SkillTranslation { Language = "nl", Name = "Flexibiliteit" },
                    new SkillTranslation { Language = "en", Name = "Adaptability" }
                ],
                Type = SkillType.SoftSkill
            },
            new Skill
            {
                Key = "collaboration",
                Translations =
                [
                    new SkillTranslation { Language = "nl", Name = "Samenwerken" },
                    new SkillTranslation { Language = "en", Name = "Collaboration" }
                ],
                Type = SkillType.SoftSkill
            },

            // Softskills - karakter

            new Skill
            {
                Key = "curious",
                Translations =
                [
                    new SkillTranslation { Language = "nl", Name = "Nieuwsgierig" },
                    new SkillTranslation { Language = "en", Name = "Curious" }
                ],
                Type = SkillType.Character
            },
            new Skill
            {
                Key = "realistic",
                Translations =
                [
                    new SkillTranslation { Language = "nl", Name = "Realistisch" },
                    new SkillTranslation { Language = "en", Name = "Realistic" }
                ],
                Type = SkillType.Character
            },
            new Skill
            {
                Key = "customer-focused",
                Translations =
                [
                    new SkillTranslation { Language = "nl", Name = "Klantgericht" },
                    new SkillTranslation { Language = "en", Name = "Customer-focused" }
                ],
                Type = SkillType.Character
            },
            new Skill
            {
                Key = "balanced",
                Translations =
                [
                    new SkillTranslation { Language = "nl", Name = "Evenwichtig" },
                    new SkillTranslation { Language = "en", Name = "Balanced" }
                ],
                Type = SkillType.Character
            },
            new Skill
            {
                Key = "spontaneous",
                Translations =
                [
                    new SkillTranslation { Language = "nl", Name = "Spontaan" },
                    new SkillTranslation { Language = "en", Name = "Spontaneous" }
                ],
                Type = SkillType.Character
            },
            new Skill
            {
                Key = "integrity",
                Translations =
                [
                    new SkillTranslation { Language = "nl", Name = "Integer" },
                    new SkillTranslation { Language = "en", Name = "Integrity" }
                ],
                Type = SkillType.Character
            },
            new Skill
            {
                Key = "creative",
                Translations =
                [
                    new SkillTranslation { Language = "nl", Name = "Creatief" },
                    new SkillTranslation { Language = "en", Name = "Creative" }
                ],
                Type = SkillType.Character
            },
            new Skill
            {
                Key = "committed",
                Translations =
                [
                    new SkillTranslation { Language = "nl", Name = "Betrokken" },
                    new SkillTranslation { Language = "en", Name = "Committed" }
                ],
                Type = SkillType.Character
            },
            new Skill
            {
                Key = "decisive",
                Translations =
                [
                    new SkillTranslation { Language = "nl", Name = "Doortastend" },
                    new SkillTranslation { Language = "en", Name = "Decisive" }
                ],
                Type = SkillType.Character
            },

            new Skill
            {
                Key = "ui-ux",
                Translations =
                [
                    new SkillTranslation { Language = "nl", Name = "UI/UX" },
                    new SkillTranslation { Language = "en", Name = "UI/UX" }
                ],
                Type = SkillType.Technical
            },
            new Skill
            {
                Key = "creative-entrepreneurship",
                Translations =
                [
                    new SkillTranslation { Language = "nl", Name = "Creatief ondernemen" },
                    new SkillTranslation { Language = "en", Name = "Creative entrepreneurship" }
                ],
                Type = SkillType.SoftSkill
            },
            new Skill
            {
                Key = "presentation-skills",
                Translations =
                [
                    new SkillTranslation { Language = "nl", Name = "Presentatievaardigheden" },
                    new SkillTranslation { Language = "en", Name = "Presentation skills" }
                ],
                Type = SkillType.SoftSkill
            },
            new Skill
            {
                Key = "marketing-and-communication",
                Translations =
                [
                    new SkillTranslation { Language = "nl", Name = "Marketing en communicatie" },
                    new SkillTranslation { Language = "en", Name = "Marketing and communication" }
                ],
                Type = SkillType.SoftSkill
            },
            new Skill
            {
                Key = "methodical-working",
                Translations =
                [
                    new SkillTranslation { Language = "nl", Name = "Methodisch werken" },
                    new SkillTranslation { Language = "en", Name = "Methodical working" }
                ],
                Type = SkillType.SoftSkill
            }
        );
        
        await context.SaveChangesAsync();
    }

    private static async Task SeedToolingAsync(PortfolioDbContext context)
{
    if (await context.Tooling.AnyAsync())
        return;

    context.Tooling.AddRange(
        new Tooling { Name = "JetBrains PyCharm", Usage = CapabilityUsage.Occasional, Media = CreateImage("/media/webstack/placeholder.webp", "JetBrains PyCharm logo") },
        new Tooling { Name = "Draw.io", Usage = CapabilityUsage.Occasional, Media = CreateImage("/media/webstack/placeholder.webp", "Draw.io logo") },
        new Tooling
        {
            Name = "ChatGPT",
            Usage = CapabilityUsage.Daily,
            Media = CreateImage(
                "/media/webstack/chatgpt.webp",
                "ChatGPT logo")
        },
        new Tooling
        {
            Name = "Terminal",
            Usage = CapabilityUsage.Daily,
            Media = CreateImage(
                "/media/webstack/terminal.webp",
                "Terminal-logo")
        },
        new Tooling
        {
            Name = "Android Studio",
            Usage = CapabilityUsage.Occasional,
            Media = CreateImage(
                "/media/webstack/android-studio.webp",
                "Android Studio logo")
        },
        new Tooling
        {
            Name = "JetBrains Rider",
            Usage = CapabilityUsage.Regular,
            Media = CreateImage(
                "/media/webstack/jetbrains-rider.webp",
                "JetBrains Rider logo")
        },
        new Tooling
        {
            Name = "JetBrains WebStorm",
            Usage = CapabilityUsage.Regular,
            Media = CreateImage(
                "/media/webstack/jetbrains-webstorm.webp",
                "JetBrains WebStorm logo")
        },
        new Tooling
        {
            Name = "LazyVim",
            Usage = CapabilityUsage.Daily,
            Media = CreateImage(
                "/media/webstack/lazyvim.webp",
                "LazyVim logo")
        },
        new Tooling
        {
            Name = "AWX",
            Usage = CapabilityUsage.Daily,
            Media = CreateImage(
                "/media/webstack/awx.webp",
                "AWX logo")
        },
        new Tooling
        {
            Name = "Azure DevOps",
            Usage = CapabilityUsage.Daily,
            Media = CreateImage(
                "/media/webstack/azure-devops.webp",
                "Azure DevOps logo")
        },
        new Tooling
        {
            Name = "Harbor",
            Usage = CapabilityUsage.Regular,
            Media = CreateImage(
                "/media/webstack/harbor.webp",
                "Harbor logo")
        },
        new Tooling
        {
            Name = "Zabbix",
            Usage = CapabilityUsage.Daily,
            Media = CreateImage(
                "/media/webstack/zabbix.webp",
                "Zabbix logo")
        },
        new Tooling
        {
            Name = "Git",
            Usage = CapabilityUsage.Daily,
            Media = CreateImage(
                "/media/webstack/git.webp",
                "Git-logo")
        },
        new Tooling
        {
            Name = "GitHub",
            Usage = CapabilityUsage.Daily,
            Media = CreateImage(
                "/media/webstack/github.webp",
                "GitHub-logo")
        },
        new Tooling
        {
            Name = "GitHub Actions",
            Usage = CapabilityUsage.Regular,
            Media = CreateImage(
                "/media/webstack/github-actions.webp",
                "GitHub Actions-logo")
        },
        new Tooling
        {
            Name = "VSCode",
            Usage = CapabilityUsage.Occasional,
            Media = CreateImage(
                "/media/webstack/vsc.webp",
                "Visual Studio Code-logo")
        },
        new Tooling
        {
            Name = "Gimp",
            Usage = CapabilityUsage.Occasional,
            Media = CreateImage(
                "/media/webstack/gimp.webp",
                "GIMP-logo")
        },
        new Tooling
        {
            Name = "Photopea",
            Usage = CapabilityUsage.Regular,
            Media = CreateImage(
                "/media/webstack/photopea.webp",
                "Photopea-logo")
        },
        new Tooling
        {
            Name = "Figma",
            Usage = CapabilityUsage.Occasional,
            Media = CreateImage(
                "/media/webstack/figma.webp",
                "Figma-logo")
        },
        new Tooling
        {
            Name = "phpMyAdmin",
            Usage = CapabilityUsage.Regular,
            Media = CreateImage(
                "/media/webstack/phpmyadmin.webp",
                "phpMyAdmin-logo")
        },
        new Tooling
        {
            Name = "Gradle",
            Usage = CapabilityUsage.Occasional,
            Media = CreateImage(
                "/media/webstack/gradle.webp",
                "Gradle-logo")
        },
        new Tooling
        {
            Name = "Jira",
            Usage = CapabilityUsage.Daily,
            Media = CreateImage(
                "/media/webstack/jira.webp",
                "Jira-logo")
        },
        new Tooling
        {
            Name = "Confluence",
            Usage = CapabilityUsage.Regular,
            Media = CreateImage(
                "/media/webstack/confluence.webp",
                "Confluence-logo")
        },
        new Tooling
        {
            Name = "GitLab",
            Usage = CapabilityUsage.Occasional,
            Media = CreateImage(
                "/media/webstack/gitlab.webp",
                "GitLab-logo")
        },
        new Tooling
        {
            Name = "Zendesk",
            Usage = CapabilityUsage.Past,
            Media = CreateImage(
                "/media/webstack/zendesk.webp",
                "Zendesk-logo")
        },
        new Tooling
        {
            Name = "Postman",
            Usage = CapabilityUsage.Regular,
            Media = CreateImage(
                "/media/webstack/postman.webp",
                "Postman-logo")
        },
        new Tooling
        {
            Name = "WinSCP",
            Usage = CapabilityUsage.Past,
            Media = CreateImage(
                "/media/webstack/winscp.webp",
                "WinSCP-logo")
        },
        new Tooling
        {
            Name = "Microsoft Dynamics 365",
            Usage = CapabilityUsage.Past,
            Media = CreateImage(
                "/media/webstack/microsoft-dynamics.webp",
                "Microsoft Dynamics 365-logo")
        },
        new Tooling
        {
            Name = "Nginx",
            Usage = CapabilityUsage.Regular,
            Media = CreateImage(
                "/media/webstack/nginx.webp",
                "Nginx-logo")
        },
        new Tooling
        {
            Name = "Gunicorn",
            Usage = CapabilityUsage.Past,
            Media = CreateImage(
                "/media/webstack/gunicorn.webp",
                "Gunicorn-logo")
        },
        new Tooling
        {
            Name = "Certbot",
            Usage = CapabilityUsage.Occasional,
            Media = CreateImage(
                "/media/webstack/certbot.webp",
                "Certbot-logo")
        },
        new Tooling
        {
            Name = "SSH",
            Usage = CapabilityUsage.Daily,
            Media = CreateImage(
                "/media/webstack/ssh.webp",
                "SSH logo")
        },
        new Tooling
        {
            Name = "VPS",
            Usage = CapabilityUsage.Regular,
            Media = CreateImage(
                "/media/webstack/vps.webp",
                "VPS logo")
        },
        new Tooling
        {
            Name = "Microsoft Outlook",
            Usage = CapabilityUsage.Daily,
            Media = CreateImage(
                "/media/webstack/microsoft-outlook.webp",
                "Microsoft Outlook logo")
        },
        new Tooling
        {
            Name = "Microsoft Agenda",
            Usage = CapabilityUsage.Daily,
            Media = CreateImage(
                "/media/webstack/microsoft-agenda.webp",
                "Microsoft Agenda logo")
        },
        new Tooling
        {
            Name = "Microsoft Excel",
            Usage = CapabilityUsage.Daily,
            Media = CreateImage(
                "/media/webstack/microsoft-excel.webp",
                "Microsoft Excel logo")
        },
        new Tooling
        {
            Name = "Microsoft Word",
            Usage = CapabilityUsage.Daily,
            Media = CreateImage(
                "/media/webstack/microsoft-word.webp",
                "Microsoft Word logo")
        },
        new Tooling
        {
            Name = "Klantbeeld",
            Usage = CapabilityUsage.Past,
            Media = CreateImage(
                "/media/webstack/placeholder.webp",
                "Klantbeeld logo")
        },
        new Tooling
        {
            Name = "Microsoft Power BI",
            Usage = CapabilityUsage.Occasional,
            Media = CreateImage(
                "/media/webstack/powerbi.webp",
                "Microsoft Power BI logo")
        },
        new Tooling
        {
            Name = "Adeptia",
            Usage = CapabilityUsage.Regular,
            Media = CreateImage(
                "/media/webstack/adeptia.webp",
                "Adeptia logo")
        },
        new Tooling
        {
            Name = "Red Hat AMQ",
            Usage = CapabilityUsage.Regular,
            Media = CreateImage(
                "/media/webstack/rhel.webp",
                "Red Hat AMQ logo")
        },
        new Tooling
        {
            Name = "Kitodo",
            Usage = CapabilityUsage.Regular,
            Media = CreateImage(
                "/media/webstack/kitodo.webp",
                "Kitodo logo")
        }
    );

    await context.SaveChangesAsync();
}

    private static async Task SeedOrganizationsAsync(
    PortfolioDbContext context)
{
    if (await context.Organizations.AnyAsync())
        return;

    context.Organizations.AddRange(
        new Organization
        {
            Name = "Red Hat",
            Type = OrganizationType.TrainingProvider,
            Media = CreateImage(
                "/media/education/rhel.webp",
                "Red Hat logo")
        },
        new Organization
        {
            Name = "Avans Hogeschool",
            Type = OrganizationType.EducationalInstitution,
            Media = CreateImage(
                "/media/education/avans.webp",
                "Avans Hogeschool logo")
        },
        new Organization
        {
            Name = "Codecademy",
            Type = OrganizationType.TrainingProvider,
            Media = CreateImage(
                "/media/education/codecademy.webp",
                "Codecademy logo")
        },
        new Organization
        {
            Name = "Albeda College",
            Type = OrganizationType.EducationalInstitution,
            Media = CreateImage(
                "/media/education/albeda.png",
                "Albeda College logo")
        },
        new Organization
        {
            Name = "Koning Willem 1 College",
            Type = OrganizationType.EducationalInstitution,
            Media = CreateImage(
                "/media/education/kw1c.png",
                "Koning Willem 1 College logo")
        },
        new Organization
        {
            Name = "BCS HR Solutions",
            Type = OrganizationType.Employer,
            Media = CreateImage(
                "/media/work-experience/bcs.webp",
                "BCS HR Solutions logo")
        },
        new Organization
        {
            Name = "Gemeente Den Haag",
            Type = OrganizationType.Employer,
            Media = CreateImage(
                "/media/work-experience/gemeente-denhaag.webp",
                "Gemeente Den Haag logo")
        },
        new Organization
        {
            Name = "Gemeente Rotterdam",
            Type = OrganizationType.Employer,
            Media = CreateImage(
                "/media/work-experience/gemeente-rotterdam.webp",
                "Gemeente Rotterdam logo")
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
                CatchPhrase = "De wereld vooruit helpen.",
                Description =
                    "Ik houd me als Linux Engineer bezig met het automatiseren van infra, software en agentic systemen.",
                Media = heroImage
            },

            new Hero
            {
                Language = "en",
                Name = "Giel van Gaal",
                JobTitle = "Linux Engineer & Software Developer",
                CatchPhrase = "Helping move the world forward.",
                Description =
                    "I work as a Linux Engineer, building and automating infrastructure, software and agentic systems.",
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

    var php = technologies["PHP"];
    var mysql = technologies["MySQL"];

    var kotlin = technologies["Kotlin"];
    var ktor = technologies["Ktor"];
    var exposed = technologies["Exposed"];

    var python = technologies["Python"];
    var django = technologies["Django"];
    var docker = technologies["Docker"];

    var skills = await context.Skills
        .Include(x => x.Translations)
        .ToDictionaryAsync(x => x.Translations.Single(t => t.Language == "nl").Name);

    var tooling = await context.Tooling
        .ToDictionaryAsync(x => x.Name);

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
        Slug = "carebots",

        Title = "CareBots",

        CardDescription =
            "Webapplicatie en beheersysteem voor zorgrobots, gebouwd met HTML, CSS, PHP en MySQL.",

        Description =
            "CareBots begon als een teamproject rond zorgrobots. Hiermee doorliepen we als eerstejaars de volledige " +
            "development lifecycle: van functioneel naar technisch ontwerp en van frontend naar backend, " +
            "met alle architectuur- en UML-diagrammetjes van dien. Ook maakten we voor het eerst kennis met de wondere wereld van OOP. " +
            "We werkten onder andere met PHP en MySQL en bouwden onze eigen componentenlibrary. " +
            "Hier deed ik ook mijn eerste ervaring op met containers, om het bekende 'bij mij werkt het wel'-probleem te ondervangen. " +
            "Ik was eigenlijk meteen verkocht. " +
            "Onder de bezielende leiding van Ian Tiemann en samen met Ruben Leenknegt en Ivar Visser " +
            "rondde ik het eerste leerjaar cum laude af.",
        ProjectDate = new DateOnly(2024, 9, 1),
        ProjectType = ProjectType.Education,
        Role = "Full-stack Developer",
        TeamSize = null,
        Duration = null,

        GitHubUrl = null,
        LiveSiteUrl = "https://fdd.infra.iantiemann.nl",

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
            bootstrap,
            php,
            mysql,
            docker
        ],

        Skills =
        [
            skills["UI/UX"],
            skills["Projectmatig werken"],
            skills["Samenwerken"],
            skills["Effectief communiceren"],
            skills["Creativiteit"],
            skills["Flexibiliteit"],
            skills["Databaseontwerp"],
            skills["Software testing"],
            skills["Scrum"]
        ],

        Tooling =
        [
            tooling["Figma"],
            tooling["Git"],
            tooling["GitHub"],
            tooling["VSCode"],
            tooling["Gimp"],
            tooling["Jira"],
            tooling["phpMyAdmin"],
            tooling["ChatGPT"]
        ],

        Media = CreateMediaCollection(
            careBotsFrontendMain,
            careBotsFrontendAbout,
            careBotsFrontendFaq,
            careBotsBackendDashboard,
            careBotsBackendUsers,
            careBotsBackendContact)
    };

    var careBotsFrontendEn = new PortfolioItem
    {
        Language = "en",
        Slug = "carebots",

        Title = "CareBots",

        CardDescription =
            "Website and management system for healthcare robots, built with HTML, CSS, PHP and MySQL.",

        Description =
            "CareBots started as a team project centred around healthcare robots. As first-year students, we went through " +
            "the entire development lifecycle: from functional to technical design and from frontend to backend, " +
            "with all the architecture and UML diagrams that come with it. We also got our first taste of the wonderful world of OOP. " +
            "We worked with PHP and MySQL and built our own component library. " +
            "This was also my first experience with containers, tackling the familiar 'it works on my machine' problem. " +
            "I was pretty much hooked from the start. " +
            "Under the inspiring guidance of Ian Tiemann and alongside Ruben Leenknegt and Ivar Visser, " +
            "I completed my first year cum laude.",

        ProjectDate = new DateOnly(2024, 9, 1),
        ProjectType = ProjectType.Education,
        Role = "Full-stack Developer",
        TeamSize = null,
        Duration = null,

        GitHubUrl = null,
        LiveSiteUrl = "https://fdd.infra.iantiemann.nl",

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
            bootstrap,
            php,
            mysql,
            docker
        ],

        Skills =
        [
            skills["UI/UX"],
            skills["Projectmatig werken"],
            skills["Samenwerken"],
            skills["Effectief communiceren"],
            skills["Creativiteit"],
            skills["Flexibiliteit"],
            skills["Databaseontwerp"],
            skills["Software testing"],
            skills["Scrum"]
        ],

        Tooling =
        [
            tooling["Figma"],
            tooling["Git"],
            tooling["GitHub"],
            tooling["VSCode"],
            tooling["Gimp"],
            tooling["Jira"],
            tooling["phpMyAdmin"],
            tooling["ChatGPT"]
        ],

        Media = CreateMediaCollection(
            careBotsFrontendMain,
            careBotsFrontendAbout,
            careBotsFrontendFaq,
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
            "Autoverhuurapp met Android-frontend en Kotlin/Ktor REST API.",

        Description =
            "JoyRide besloeg de eerste twee periodes van leerjaar 2 en was een deep dive in de wereld van gecompileerde programmeertalen. " +
            "Voor aanvang van het schooljaar had ik een CI/CD-pipeline ontwikkeld waarmee we onze API via een (OT)AP-straat live konden brengen. " +
            "Dat kwam goed van pas, aangezien we met Kotlin en Jetpack Compose een native Android-app ontwikkelden. " +
            "Voor de backend maakten we gebruik van Ktor, Exposed en MySQL. " +
            "We leerden werken volgens het Layered Architecture-principe en verdiepten ons verder in de nodige basics, " +
            "zoals foutafhandeling, debugging en het samenwerken aan een gezamenlijke codebase.",

        ProjectDate = new DateOnly(2025, 11, 1),
        ProjectType = ProjectType.Education,
        Role = "Software Developer",
        TeamSize = null,
        Duration = null,

        GitHubUrl = null,
        LiveSiteUrl = null,

        Categories =
        [
            frontend,
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
            technologies["Jetpack Compose"],
            technologies["REST API"]
        ],

        Skills =
        [
            skills["Projectmatig werken"],
            skills["Systeemontwerp"],
            skills["Softwarearchitectuur"],
            skills["Databaseontwerp"],
            skills["CI/CD-pipelines"],
            skills["Objectgeoriënteerd programmeren"],
            skills["Oplossingsgericht denken"],
            skills["Effectief communiceren"],
            skills["Helder documenteren"],
            skills["Samenwerken"]
        ],

        Tooling =
        [
            tooling["Git"],
            tooling["GitHub"],
            tooling["Jira"],
            tooling["Gradle"],
            tooling["Android Studio"],
            tooling["ChatGPT"]
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
            "Car rental application with an Android frontend and Kotlin/Ktor REST API.",
        Description =
            "JoyRide covered the first two periods of my second year and was a deep dive into the world of compiled programming languages. " +
            "Before the academic year started, I had developed a CI/CD pipeline that allowed us to deploy our API across multiple environments. " +
            "This came in handy as we were developing a native Android app using Kotlin and Jetpack Compose. " +
            "For the backend, we used Ktor, Exposed and MySQL. " +
            "We learned to work with Layered Architecture and further explored the essentials of software development, " +
            "such as error handling, debugging and collaborating on a shared codebase.",

        ProjectDate = new DateOnly(2025, 11, 1),
        ProjectType = ProjectType.Education,
        Role = "Software Developer",
        TeamSize = null,
        Duration = null,

        GitHubUrl = null,
        LiveSiteUrl = null,

        Categories =
        [
            frontend,
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
            technologies["Jetpack Compose"],
            technologies["REST API"]
        ],

        Skills =
        [
            skills["Projectmatig werken"],
            skills["Systeemontwerp"],
            skills["Softwarearchitectuur"],
            skills["Databaseontwerp"],
            skills["CI/CD-pipelines"],
            skills["Objectgeoriënteerd programmeren"],
            skills["Oplossingsgericht denken"],
            skills["Effectief communiceren"],
            skills["Helder documenteren"],
            skills["Samenwerken"]
        ],

        Tooling =
        [
            tooling["Git"],
            tooling["GitHub"],
            tooling["Jira"],
            tooling["Gradle"],
            tooling["Android Studio"],
            tooling["ChatGPT"]
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
            "Nijntje begon als hobbyproject waarin ik zonder vast framework of vooraf uitgedachte architectuur verschillende technieken wilde onderzoeken. " +
            "Dit deed ik voor aanvang van het eerste leerjaar, om mijn kennis alvast enigszins op peil te brengen. " +
            "Ik experimenteerde met CSS Grid en bouwde met Django een messageboard. " +
            "Daarvoor zette ik mijn eigen VPS op, configureerde ik Gunicorn als WSGI-server en Nginx als reverse proxy, " +
            "en gebruikte ik Certbot voor TLS. Vanuit de frontend worden de berichten opgehaald met JavaScript. " +
            "Het was vooral een technische speeltuin waarin ik veel leerde over Linux-servers, poorten, reverse proxies en SSH-sleutels. " +
            "Gewoon lekker zelf uitzoeken hoe alles werkt en hoe je de verschillende onderdelen met elkaar laat samenwerken.",

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
            django
        ],

        Skills =
        [
            skills["Zelfstandig leren"],
            skills["Snel leren en toepassen"],
            skills["Creativiteit"],
            skills["Analytisch vermogen"],
            skills["Oplossingsgericht denken"],
            skills["Zelfstandigheid"],
            skills["Kwaliteitsbewustzijn"],
            skills["Projectmatig werken"],
            skills["Effectief communiceren"],
            skills["Nieuwsgierig"]
        ],

        Tooling =
        [
            tooling["Git"],
            tooling["GitHub"],
            tooling["Nginx"],
            tooling["Gunicorn"],
            tooling["Certbot"],
            tooling["SSH"],
            tooling["VPS"]
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
            "Nijntje started as a hobby project in which I wanted to explore different technologies without a predefined framework or architecture. " +
            "I did this before starting my first year to get my technical knowledge up to scratch. " +
            "I experimented with CSS Grid and built a message board using Django. " +
            "I set up my own VPS, configured Gunicorn as a WSGI server and Nginx as a reverse proxy, " +
            "and used Certbot for TLS. Messages are retrieved from the frontend using JavaScript. " +
            "It was mainly a technical playground where I learned a lot about Linux servers, ports, reverse proxies and SSH keys. " +
            "Just enjoying the process of figuring out how things work and getting all the different pieces to work together.",

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
            django
        ],

        Skills =
        [
            skills["Zelfstandig leren"],
            skills["Snel leren en toepassen"],
            skills["Creativiteit"],
            skills["Analytisch vermogen"],
            skills["Oplossingsgericht denken"],
            skills["Zelfstandigheid"],
            skills["Kwaliteitsbewustzijn"],
            skills["Projectmatig werken"],
            skills["Effectief communiceren"],
            skills["Nieuwsgierig"]
        ],

        Tooling =
        [
            tooling["Git"],
            tooling["GitHub"],
            tooling["Nginx"],
            tooling["Gunicorn"],
            tooling["Certbot"],
            tooling["SSH"],
            tooling["VPS"]
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
            "achtergrondinformatie en contactgegevens samen op één responsive website. " +
            "Ik gebruikte een bestaande template als uitgangspunt en paste de vormgeving, structuur en functionaliteit " +
            "met HTML, CSS, JavaScript en Bootstrap aan mijn eigen wensen aan. " +
            "Een leuk project waar ik veel plezier aan heb beleefd. Inmiddels wat achterhaald wellicht, maar dat mag de pret niet drukken.",

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

        Skills =
        [
            skills["Creativiteit"],
            skills["Projectmatig werken"],
            skills["Samenwerken"],
            skills["Effectief communiceren"],
            skills["Flexibiliteit"],
            skills["Analytisch vermogen"],
            skills["Nieuwsgierig"]
        ],

        Tooling =
        [
            tooling["Git"],
            tooling["GitHub"],
            tooling["VSCode"]
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
            "In 2018, I built a website for my work as a musician. The website brings together my discography, news, " +
            "background information and contact details in one responsive website. " +
            "I used an existing template as a starting point and adapted its design, structure and functionality " +
            "to my own liking using HTML, CSS, JavaScript and Bootstrap. " +
            "A fun project that I really enjoyed working on. Perhaps a little outdated by now, but that doesn't take away from the fun I had building it.",

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

        Skills =
        [
            skills["Creativiteit"],
            skills["Projectmatig werken"],
            skills["Samenwerken"],
            skills["Effectief communiceren"],
            skills["Flexibiliteit"],
            skills["Analytisch vermogen"],
            skills["Nieuwsgierig"]
        ],

        Tooling =
        [
            tooling["Git"],
            tooling["GitHub"],
            tooling["VSCode"]
        ],

        Media = CreateMediaCollection(
            gielMain,
            gielDiscography,
            gielNews)
    };

    // Recent school projects (dates are approximate and should be confirmed).
    var cinenetNl = new PortfolioItem
    {
        Language = "nl",
        Slug = "cinenet",
        Title = "Cine.NET",
        CardDescription = "Bioscoopapplicatie met C#, Blazor en MudBlazor.",
 
        Description =
            "Cine.NET betreft periode 3 van leerjaar 2. De opdracht was om met C# en .NET een bioscoopapplicatie " +
            "te ontwikkelen met films, voorstellingen, stoelkeuze en een beheeromgeving. " +
            "Voor aanvang van de periode had ik een CI/CD-pipeline gebouwd waarmee we zowel de API als de frontend live konden benaderen. " +
            "Na wat vooronderzoek heb ik voorgesteld om voor de frontend gebruik te maken van Blazor en MudBlazor, " +
            "met het oog op schaalbaarheid, uniformiteit, herbruikbaarheid van componenten en ontwikkelgemak. " +
            "Mijn bevindingen heb ik in een document gegoten en vervolgens gepitcht bij de groep. " +
            "Deze periode stond ook nadrukkelijk in het teken van Agile en Scrum. " +
            "We verdeelden het werk over sprints en hielden refinements, sprint reviews en retrospectives.",

        ProjectDate = new DateOnly(2026, 2, 1),
        ProjectType = ProjectType.Education,
        Role = "Full-stack Developer",
        Categories = [frontend, backend],
        Technologies = [technologies["C#"], technologies[".NET"], technologies["Blazor"], technologies["MudBlazor"], technologies["ASP.NET Core"], technologies["REST API"]],
        Skills = [skills["Software testing"], skills["Scrum"], skills["Samenwerken"], skills["Softwarearchitectuur"]],
        Tooling = [tooling["Git"], tooling["Jira"], tooling["JetBrains Rider"], tooling["ChatGPT"]]
    };

    var cinenetEn = new PortfolioItem
    {
        Language = "en",
        Slug = "cinenet",
        Title = "Cine.NET",
        CardDescription = "Cinema booking application built with C#, Blazor and MudBlazor.",

        Description =
            "Cine.NET was the project for the third period of my second year. The assignment was to develop a cinema application " +
            "using C# and .NET, featuring movies, screenings, seat selection and an administration interface. " +
            "Before the period started, I had built a CI/CD pipeline that allowed us to access both the API and the frontend online. " +
            "After some initial research, I proposed using Blazor and MudBlazor for the frontend, " +
            "with scalability, consistency, component reusability and ease of development in mind. " +
            "I documented my findings and pitched the proposal to the team. " +
            "This period also placed a strong emphasis on Agile and Scrum. " +
            "We organised our work into sprints and held refinement sessions, sprint reviews and retrospectives.",

        ProjectDate = new DateOnly(2026, 2, 1),
        ProjectType = ProjectType.Education,
        Role = "Full-stack Developer",
        Categories = [frontend, backend],
        Technologies = [technologies["C#"], technologies[".NET"], technologies["Blazor"], technologies["MudBlazor"], technologies["ASP.NET Core"], technologies["REST API"]],
        Skills = [skills["Software testing"], skills["Scrum"], skills["Samenwerken"], skills["Softwarearchitectuur"]],
        Tooling = [tooling["Git"], tooling["Jira"], tooling["JetBrains Rider"], tooling["ChatGPT"]]
    };

    var soulsearchNl = new PortfolioItem
    {
        Language = "nl",
        Slug = "soulsearch",
        Title = "SoulSearch",
        CardDescription = "Cross-platform applicatie met .NET MAUI Blazor Hybrid en een API.",
        
        Description =
            "SoulSearch is mijn afstudeeropdracht waarmee ik ditmaal zelfstandig mijn Associate Degree cum laude heb weten af te ronden. " +
            "Een ambitieus project: een soort Instagram voor aggressive inline skaters, met een API in C# en .NET " +
            "en een cross-platform frontend gebouwd met .NET MAUI, Blazor en MudBlazor. " +
            "Hierbij heb ik gebruikgemaakt van native device features, zoals locatiebepaling en de camera. " +
            "Daarnaast heb ik authenticatie en autorisatie met JWT, de opslag en verwerking van gebruikersmedia " +
            "en het delen van componenten tussen de web- en native applicatie gerealiseerd. " +
            "Van projectplanning en softwarearchitectuur tot realisatie en het opzetten van de CI/CD-pipeline, ditmaal lag de verantwoordelijkheid volledig bij mij. " +
            "Gedurende het hele ontwikkelproces heb ik dankbaar gebruikgemaakt van AI als sparringpartner en hulpmiddel bij de realisatie. " +
            "De versie die momenteel live staat is een demo die je gerust zelf kunt uitproberen. " +
            "De data wordt iedere nacht gereset om de boel een beetje schoon te houden.",

        ProjectDate = new DateOnly(2026, 5, 1),
        ProjectType = ProjectType.Education,
        Role = "Software Developer",
        LiveSiteUrl = "https://soulsearch.gielvangaal.dev",
        Categories = [frontend, backend],
        Technologies = [technologies["C#"], technologies[".NET"], technologies["Blazor"], technologies["MudBlazor"], technologies[".NET MAUI"], technologies["ASP.NET Core"], technologies["REST API"]],
        Skills = [skills["Software testing"], skills["Softwarearchitectuur"], skills["Samenwerken"]],
        Tooling = [tooling["Git"], tooling["Jira"], tooling["JetBrains Rider"], tooling["ChatGPT"]]
    };

    var soulsearchEn = new PortfolioItem
    {
        Language = "en",
        Slug = "soulsearch",
        Title = "SoulSearch",
        CardDescription = "Cross-platform application using .NET MAUI Blazor Hybrid and an API.",
        
        Description =
            "SoulSearch is my graduation project, through which I independently completed my Associate Degree cum laude. " +
            "An ambitious project: something like Instagram for aggressive inline skaters, with an API built using C# and .NET " +
            "and a cross-platform frontend using .NET MAUI, Blazor and MudBlazor. " +
            "I made use of native device features such as geolocation and the camera. " +
            "I also implemented JWT-based authentication and authorisation, user media storage and processing, " +
            "and shared components between the web and native applications. " +
            "From project planning and software architecture to development and setting up the CI/CD pipeline, this time the responsibility was entirely mine. " +
            "Throughout the development process, I made extensive use of AI as a sparring partner and development tool. " +
            "The version currently online is a demo that you're welcome to try out yourself. " +
            "The data is reset every night to keep things nice and tidy.",

        ProjectDate = new DateOnly(2026, 5, 1),
        ProjectType = ProjectType.Education,
        Role = "Software Developer",
        LiveSiteUrl = "https://soulsearch.gielvangaal.dev",
        Categories = [frontend, backend],
        Technologies = [technologies["C#"], technologies[".NET"], technologies["Blazor"], technologies["MudBlazor"], technologies[".NET MAUI"], technologies["ASP.NET Core"], technologies["REST API"]],
        Skills = [skills["Software testing"], skills["Softwarearchitectuur"], skills["Samenwerken"]],
        Tooling = [tooling["Git"], tooling["Jira"], tooling["JetBrains Rider"], tooling["ChatGPT"]]
    };

    var contosoNl = new PortfolioItem
    {
        Language = "nl",
        Slug = "business-intelligence",
        Title = "Business Intelligence",
        CardDescription = "Business Intelligence fundamentals met Power BI en Python.",
        
        Description =
            "In periode 1 van leerjaar 3 heb ik kennisgemaakt met de fundamenten van Business Intelligence. " +
            "Veel theorie deze periode: de BI-lifecycle, supervised en unsupervised learning, maturity levels, data governance " +
            "en natuurlijk architectuur. Ook het verschil tussen OLAP en OLTP en de achterliggende gedachte van een datawarehouse vond ik interessant. " +
            "Naast het functioneel en technisch ontwerp was de realisatie tweeledig: eenmaal in Power BI en eenmaal in Python. " +
            "Mijn casus betrof een Contoso-dataset met verkoopgegevens, die ik heb aangevuld met een weerdataset om te kijken of er een verband was tussen temperatuur en omzet (niet dus, althans niet zichtbaar). " +
            "Vooral bij het Python-gedeelte ging ik aan. Ik heb met veel plezier een modulaire ETL-pipeline opgezet waarin alle data stapsgewijs wordt verwerkt, " +
            "om uiteindelijk tot tien verschillende visualisaties te komen.",

        ProjectDate = new DateOnly(2026, 10, 25),
        ProjectType = ProjectType.Education,
        Role = "Data Engineer",
        TeamSize = 1,
        GitHubUrl = "https://github.com/gielvangaal/L3P1",
        Categories = [backend],
        Technologies = [technologies["Python"], technologies["pandas"], technologies["NumPy"], technologies["DAX"], technologies["Power Query"], technologies["Matplotlib"], technologies["Seaborn"], technologies["Plotly"], technologies["Altair"], technologies["Folium"]],
        Skills = [skills["ETL"], skills["Business Intelligence"], skills["Datamodellering"], skills["Datavisualisatie"], skills["Datavalidatie"], skills["Softwarearchitectuur"], skills["Analytisch vermogen"]],
        Tooling = [tooling["Microsoft Power BI"], tooling["JetBrains PyCharm"], tooling["Draw.io"], tooling["Git"], tooling["GitHub"], tooling["ChatGPT"]],
        Media = CreateMediaCollection(
            CreateImage("/media/portfolio/contoso-ceo.webp", "Power BI – CEO"),
            CreateImage("/media/portfolio/contoso-store-manager.webp", "Power BI – Store manager"))
    };

    var contosoEn = new PortfolioItem
    {
        Language = "en",
        Slug = "business-intelligence",
        Title = "Business Intelligence",
        CardDescription = "Business Intelligence fundamentals with Power BI and Python.",

        Description =
              "During the first period of my third year, I was introduced to the fundamentals of Business Intelligence. " +
              "Quite a bit of theory this time around: the BI lifecycle, supervised and unsupervised learning, maturity levels, data governance " +
              "and, of course, architecture. I also found the differences between OLAP and OLTP and the reasoning behind data warehouses particularly interesting. " +
              "Alongside the functional and technical design, the implementation was twofold: once in Power BI and once in Python. " +
              "My case involved a Contoso sales dataset, which I supplemented with weather data to see whether there was a relationship between temperature and revenue (apparently not, at least not a visible one). " +
              "The Python part was where I really got into it. I thoroughly enjoyed building a modular ETL pipeline that processes all the data step by step, " +
              "ultimately producing ten different visualisations.",

        ProjectDate = new DateOnly(2026, 10, 25),
        ProjectType = ProjectType.Education,
        Role = "Data Engineer",
        TeamSize = 1,
        GitHubUrl = "https://github.com/gielvangaal/L3P1",
        Categories = [backend],
        Technologies = [technologies["Python"], technologies["pandas"], technologies["NumPy"], technologies["DAX"], technologies["Power Query"], technologies["Matplotlib"], technologies["Seaborn"], technologies["Plotly"], technologies["Altair"], technologies["Folium"]],
        Skills = [skills["ETL"], skills["Business Intelligence"], skills["Datamodellering"], skills["Datavisualisatie"], skills["Datavalidatie"], skills["Softwarearchitectuur"], skills["Analytisch vermogen"]],
        Tooling = [tooling["Microsoft Power BI"], tooling["JetBrains PyCharm"], tooling["Draw.io"], tooling["Git"], tooling["GitHub"], tooling["ChatGPT"]],
        Media = CreateMediaCollection(
            CreateImage("/media/portfolio/contoso-ceo.webp", "Power BI – CEO"),
            CreateImage("/media/portfolio/contoso-store-manager.webp", "Power BI – Store manager"))
    };

    var portfolioNl = new PortfolioItem
    {
        Language = "nl",
        Slug = "portfolio-v2",
        Title = "Portfolio 2.0",
        CardDescription = "Mijn eigen portfolio, opnieuw gebouwd met React, C# en MySQL.",
        Description = "Dit is eigenlijk versie 2 van mijn portfolio. De eerste versie heb ik zelf ontworpen in Figma en vervolgens gebouwd met HTML en CSS. Met mijn nieuw verworven kennis van API's, mijn wens om agentic te leren werken en de nieuwsgierigheid om eens iets met React te doen, ben ik deze gaan herschrijven. Stap voor stap heb ik met behulp van Codex mijn oude portfolio omgebouwd naar een React-variant, met een API in C# en een MySQL-database. Daarbij heb ik ook een klein datamodel bedacht waarin skills, tools en technologieën gekoppeld kunnen worden aan projecten, opleidingen en werkervaring. Was dat per se nodig? Nee, maar ik vond het wel leuk om te bouwen.",
        ProjectDate = new DateOnly(2026, 9, 1),
        ProjectType = ProjectType.Personal,
        Role = "Full-stack Developer",
        TeamSize = 1,
        GitHubUrl = "https://github.com/gielvangaal/portfolio",
        LiveSiteUrl = "https://gielvangaal.dev",
        Categories = [frontend, backend, devOps],
        Technologies = [html, css, javascript, mysql, docker, technologies["React"], technologies["C#"], technologies[".NET"], technologies["ASP.NET Core"], technologies["REST API"], technologies["Kubernetes"], technologies["K3s"]],
        Skills = [skills["UI/UX"], skills["Datamodellering"], skills["Databaseontwerp"], skills["Softwarearchitectuur"], skills["Zelfstandig leren"], skills["Creativiteit"]],
        Tooling = [tooling["Figma"], tooling["Git"], tooling["GitHub"], tooling["ChatGPT"], tooling["GitHub Actions"]],
        Media = CreateMediaCollection(
            CreateImage("/media/portfolio/portfolio-1.webp", "Portfolio screenshot 1"),
            CreateImage("/media/portfolio/portfolio-2.webp", "Portfolio screenshot 2"))
    };

    var portfolioEn = new PortfolioItem
    {
        Language = "en",
        Slug = "portfolio-v2",
        Title = "Portfolio 2.0",
        CardDescription = "My own portfolio, rebuilt with React, C# and MySQL.",
        Description = "This is actually version 2 of my portfolio. I designed the first version myself in Figma and built it with HTML and CSS. With my newfound knowledge of APIs, a desire to learn agentic workflows and a curiosity about React, I decided to rewrite it. Step by step, with the help of Codex, I turned my old portfolio into a React application with a C# API and a MySQL database. Along the way, I came up with a little data model that lets me link skills, tools and technologies to projects, education and work experience. Was that strictly necessary? No, but I had fun building it.",
        ProjectDate = new DateOnly(2026, 9, 1),
        ProjectType = ProjectType.Personal,
        Role = "Full-stack Developer",
        TeamSize = 1,
        GitHubUrl = "https://github.com/gielvangaal/portfolio",
        LiveSiteUrl = "https://gielvangaal.dev",
        Categories = [frontend, backend, devOps],
        Technologies = [html, css, javascript, mysql, docker, technologies["React"], technologies["C#"], technologies[".NET"], technologies["ASP.NET Core"], technologies["REST API"], technologies["Kubernetes"], technologies["K3s"]],
        Skills = [skills["UI/UX"], skills["Datamodellering"], skills["Databaseontwerp"], skills["Softwarearchitectuur"], skills["Zelfstandig leren"], skills["Creativiteit"]],
        Tooling = [tooling["Figma"], tooling["Git"], tooling["GitHub"], tooling["ChatGPT"], tooling["GitHub Actions"]],
        Media = CreateMediaCollection(
            CreateImage("/media/portfolio/portfolio-1.webp", "Portfolio screenshot 1"),
            CreateImage("/media/portfolio/portfolio-2.webp", "Portfolio screenshot 2"))
    };

    var pahpNl = new PortfolioItem
    {
        Language = "nl",
        Slug = "pahp",
        Title = "PAHP – Persoonlijk Applicatie Hosting Platform",
        CardDescription = "Zelfontwikkeld hostingplatform op basis van K3s, Ansible en GitOps.",
        Description = "Om mijn eigen projecten ten behoeve van mijn portfolio te kunnen hosten, maar ook om websites van anderen te kunnen hosten, heb ik PAHP ontwikkeld. Een acroniem voor Persoonlijk Applicatie Hosting Platform. Daarnaast leek het me natuurlijk gewoon een leuke technische uitdaging. Het platform bestaat uit een single-node K3s-cluster op een RHEL VPS, met Cilium voor networking en Argo CD voor GitOps. De infrastructuur wordt uitgerold met Ansible. Daarbij is ook nagedacht over SSH-hardening, monitoring, een back-upstrategie en lifecycle management. Voor de versiebeheerstrategie maak ik gebruik van SemVer. Bij een push naar de applicatierepository wordt via de CI/CD-pipeline een nieuwe containerimage gebouwd, waarna Argo CD Image Updater ervoor zorgt dat een nieuwe versie die aan de updatevoorwaarden voldoet automagisch wordt gedeployed. Dit project is volledig agentic tot stand gekomen. Vanuit het functioneel en technisch ontwerp heb ik GitHub-issues opgesteld die vervolgens door AI-agents zijn uitgewerkt. Mijn rol verschoof daarmee steeds meer van het schrijven van code naar het bewaken van de architectuur, het reviewen en het bijsturen waar nodig. Een interessante manier van ontwikkelen, waarbij ik minstens zoveel bezig was met het ontwikkelproces zelf als met de techniek.",
        ProjectDate = new DateOnly(2026, 11, 1),
        ProjectType = ProjectType.Personal,
        Role = "Platform Engineer",
        TeamSize = 1,
        GitHubUrl = "https://github.com/gielvangaal/platform-infra",
        Categories = [devOps],
        Technologies = [technologies["Linux"], technologies["RHEL"], technologies["Ansible"], technologies["Kubernetes"], technologies["K3s"], technologies["Cilium"], technologies["Bash"], technologies["Docker"], technologies["Argo CD"], technologies["Helm"], technologies["Prometheus"], technologies["Grafana"], technologies["Restic"]],
        Skills = [skills["Systeemontwerp"], skills["Softwarearchitectuur"], skills["CI/CD-pipelines"], skills["Helder documenteren"], skills["Projectmatig werken"], skills["Kwaliteitsbewustzijn"], skills["Zelfstandig leren"]],
        Tooling = [tooling["Git"], tooling["GitHub"], tooling["GitHub Actions"], tooling["ChatGPT"], tooling["SSH"], tooling["VPS"], tooling["Terminal"]],
        Media = CreateMediaCollection(
            CreateImage("/media/portfolio/argocd-1.webp", "Argo CD dashboard"),
            CreateImage("/media/portfolio/grafana-1.webp", "Grafana dashboard"))
    };

    var pahpEn = new PortfolioItem
    {
        Language = "en",
        Slug = "pahp",
        Title = "PAHP – Personal Application Hosting Platform",
        CardDescription = "Self-developed hosting platform based on K3s, Ansible and GitOps.",
        Description = "To host my own portfolio projects, but also to be able to host websites for others, I developed PAHP, short for Persoonlijk Applicatie Hosting Platform (Personal Application Hosting Platform). And of course, it seemed like a fun technical challenge. The platform consists of a single-node K3s cluster on a RHEL VPS, with Cilium for networking and Argo CD for GitOps. The infrastructure is provisioned using Ansible. I also considered SSH hardening, monitoring, a backup strategy and lifecycle management. I use SemVer for versioning. A push to the application repository triggers the CI/CD pipeline to build a new container image, after which Argo CD Image Updater ensures that a new version meeting the update criteria is automagically deployed. This project was developed entirely through an agentic workflow. Based on the functional and technical designs, I created GitHub issues that were then implemented by AI agents. My role gradually shifted from writing code to overseeing the architecture, reviewing the work and steering things where necessary. An interesting way to develop software, where I spent at least as much time on the development process itself as on the technology.",
        ProjectDate = new DateOnly(2026, 11, 1),
        ProjectType = ProjectType.Personal,
        Role = "Platform Engineer",
        TeamSize = 1,
        GitHubUrl = "https://github.com/gielvangaal/platform-infra",
        Categories = [devOps],
        Technologies = [technologies["Linux"], technologies["RHEL"], technologies["Ansible"], technologies["Kubernetes"], technologies["K3s"], technologies["Cilium"], technologies["Bash"], technologies["Docker"], technologies["Argo CD"], technologies["Helm"], technologies["Prometheus"], technologies["Grafana"], technologies["Restic"]],
        Skills = [skills["Systeemontwerp"], skills["Softwarearchitectuur"], skills["CI/CD-pipelines"], skills["Helder documenteren"], skills["Projectmatig werken"], skills["Kwaliteitsbewustzijn"], skills["Zelfstandig leren"]],
        Tooling = [tooling["Git"], tooling["GitHub"], tooling["GitHub Actions"], tooling["ChatGPT"], tooling["SSH"], tooling["VPS"], tooling["Terminal"]],
        Media = CreateMediaCollection(
            CreateImage("/media/portfolio/argocd-1.webp", "Argo CD dashboard"),
            CreateImage("/media/portfolio/grafana-1.webp", "Grafana dashboard"))
    };

    context.PortfolioItems.AddRange(
        pahpNl,
        pahpEn,
        portfolioNl,
        portfolioEn,
        contosoNl,
        contosoEn,
        careBotsFrontendNl,
        careBotsFrontendEn,

        joyRideNl,
        joyRideEn,

        cinenetNl,
        cinenetEn,
        soulsearchNl,
        soulsearchEn,

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
                Mijn naam is **Giel** en ik werk als **Linux Engineer** bij de Gemeente Den Haag. Van oorsprong ben ik muzikant en inmiddels volg ik naast mijn werk de **bachelor Informatica** aan Avans Hogeschool.
              
                In mijn werk houd ik me bezig met Linux, infrastructuur en automatisering. In mijn schaarse vrije tijd bouw ik mijn eigen hostingplatform met **Kubernetes, Ansible en GitOps**, ontwikkel ik software en experimenteer ik met **agentic AI**.
              
                Voor mij is het simpel: als je niet weet waar je naartoe gaat, ga je er ook niet komen. Ik werk vanuit duidelijke requirements en een goed doordacht ontwerp, zodat alles begrijpelijk en beheersbaar blijft.
            
                Ik ben nieuwsgierig van aard en altijd wel bezig met een projectje, zoals je als het goed is ook terugziet in mijn portfolio. Uiteindelijk wil ik mooie, zinvolle dingen bouwen en daarmee de wereld een klein stukje vooruithelpen.
                """,
            ImagePath = "/media/giel2.webp"
        },

        new AboutProfile
        {
            Language = "en",
            Description =
                """
                My name is **Giel** and I work as a **Linux Engineer** at the Municipality of The Hague. Originally a musician, I'm now pursuing a **Bachelor's degree in Computer Science** at Avans University of Applied Sciences alongside my work.
            
                At work, I focus on Linux, infrastructure and automation. In what little spare time I have, I build my own hosting platform using **Kubernetes, Ansible and GitOps**, develop software and experiment with **agentic AI**.
            
                To me, it's simple: if you don't know where you're going, you won't get there. I like working with clear requirements and well-thought-out designs, keeping things understandable and manageable.
            
                I'm naturally curious and always working on some little project, as you'll hopefully notice throughout my portfolio. Ultimately, I want to build beautiful, meaningful things and help move the world forward, even if only a little.
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
        .Include(x => x.Translations)
        .ToDictionaryAsync(x => x.Translations.Single(t => t.Language == "nl").Name);

    var tooling = await context.Tooling
        .ToDictionaryAsync(x => x.Name);
    
    var organizations = await context.Organizations
        .ToDictionaryAsync(x => x.Name);

    var redhat = new Education
    {
        Organization = organizations["Red Hat"],
        Translations =

        [

            new EducationTranslation { Language = "nl", Program = "RHCSA" },

            new EducationTranslation { Language = "en", Program = "RHCSA" }

        ],
        StartYear = 2026,
        EndYear = null,
        SortOrder = 1,
        
        Sections =
        [
            new EducationSection
            {
                
                SortOrder = 1,

                Technologies =
                [
                    technologies["Linux"],
                    technologies["RHEL"],
                    technologies["Bash"],
                    technologies["Selinux"]
                ],
                Skills =
                [
                    skills["Systeemontwerp"],
                    skills["Oplossingsgericht denken"]
                ],
                Tooling =
                [
                    tooling["SSH"],
                    tooling["LazyVim"]
                ]
            }
        ]
    };
    
    var avans = new Education
    {
        Organization = organizations["Avans Hogeschool"],
        Translations =

        [

            new EducationTranslation { Language = "nl", Program = "Deeltijdopleiding Informatica" },

            new EducationTranslation { Language = "en", Program = "Part-time Bachelor of Computer Science" }

        ],
        StartYear = 2024,
        EndYear = null,
        SortOrder = 2,

        Sections =
        [
            new EducationSection
            {
                Translations =

                [

                    new EducationSectionTranslation { Language = "nl", Title = "Leerjaar 3" },

                    new EducationSectionTranslation { Language = "en", Title = "Year 3" }

                ],
                SortOrder = 0,
                
                Technologies = 
                [
                    technologies["Python"],
                    technologies["MySQL"],
                    technologies["pandas"],
                    technologies["NumPy"],
                    technologies["DAX"],
                    technologies["Power Query"],
                    technologies["Matplotlib"],
                    technologies["Seaborn"],
                    technologies["Plotly"],
                    technologies["Altair"],
                    technologies["Folium"]
                ],
                Skills =
                [
                    skills["Databaseontwerp"], 
                    skills["Analytisch vermogen"],
                    skills["ETL"],
                    skills["Business Intelligence"],
                    skills["Datamodellering"],
                    skills["Datavisualisatie"],
                    skills["Datavalidatie"],
                    skills["Softwarearchitectuur"]
                ],
                Tooling = 
                [
                    tooling["Microsoft Excel"],
                    tooling["Microsoft Power BI"],
                    tooling["JetBrains PyCharm"],
                    tooling["Draw.io"],
                    tooling["Git"],
                    tooling["GitHub"],
                    tooling["ChatGPT"]
                ]
            },
            new EducationSection
            {
                Translations =

                [

                    new EducationSectionTranslation { Language = "nl", Title = "Leerjaar 2" },

                    new EducationSectionTranslation { Language = "en", Title = "Year 2" }

                ],
                SortOrder = 1,

                Technologies =
                [
                    technologies["Kotlin"],
                    technologies["Ktor"],
                    technologies["Exposed"],
                    technologies["Jetpack Compose"],
                    technologies["C#"],
                    technologies[".NET"],
                    technologies[".NET MAUI"],
                    technologies["ASP.NET Core"],
                    technologies["Blazor"],
                    technologies["MudBlazor"],
                    technologies[".NET"],
                    technologies["Docker"],
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
                    tooling["GitHub Actions"],
                    tooling["Git"],
                    tooling["GitHub"],
                    tooling["Android Studio"],
                    tooling["JetBrains Rider"],
                    tooling["Jira"],
                    tooling["Microsoft Word"],
                    tooling["phpMyAdmin"],
                    tooling["Postman"],
                    tooling["SSH"],
                    tooling["Terminal"],
                    tooling["VPS"],
                ]
            },

            new EducationSection
            {
                Translations =

                [

                    new EducationSectionTranslation { Language = "nl", Title = "Leerjaar 1" },

                    new EducationSectionTranslation { Language = "en", Title = "Year 1" }

                ],
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
        Organization = organizations["Codecademy"],
        Translations =

        [

            new EducationTranslation { Language = "nl", Program = "Web Development" },

            new EducationTranslation { Language = "en", Program = "Web Development" }

        ],
        StartYear = 2023,
        EndYear = null,
        SortOrder = 3,

        Sections =
        [
            new EducationSection
            {
                
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
        Organization = organizations["Albeda College"],
        Translations =

        [

            new EducationTranslation { Language = "nl", Program = "Muzikant / Producer" },

            new EducationTranslation { Language = "en", Program = "Musician / Producer" }

        ],
        StartYear = 2012,
        EndYear = 2015,
        SortOrder = 4,

        Sections =
        [
            new EducationSection
            {
                
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
        Organization = organizations["Koning Willem 1 College"],
        Translations =

        [

            new EducationTranslation { Language = "nl", Program = "Sociaal Cultureel Werk" },

            new EducationTranslation { Language = "en", Program = "Social and Cultural Work" }

        ],
        StartYear = 2004,
        EndYear = 2009,
        SortOrder = 5,

        Sections =
        [
            new EducationSection
            {
                
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
        .Include(x => x.Translations)
        .ToDictionaryAsync(x => x.Translations.Single(t => t.Language == "nl").Name);

    var tooling = await context.Tooling
        .ToDictionaryAsync(x => x.Name);
    
    var organizations = await context.Organizations
        .ToDictionaryAsync(x => x.Name);

    var bcs = new WorkExperience
    {
        Organization = organizations["BCS HR Solutions"],
        Translations =

        [

            new WorkExperienceTranslation { Language = "nl", Role = "Software Support Specialist" },

            new WorkExperienceTranslation { Language = "en", Role = "Software Support Specialist" }

        ],
        StartYear = null,
        EndYear = null,
        SortOrder = 1,

        Responsibilities =
        [
            new WorkExperienceResponsibility
            {
                Translations =

                [

                    new WorkExperienceResponsibilityTranslation { Language = "nl", Description = "Ondersteunen van gebruikers bij softwareproblemen" },

                    new WorkExperienceResponsibilityTranslation { Language = "en", Description = "Supporting users with software issues" }

                ],
                SortOrder = 1
            },
            new WorkExperienceResponsibility
            {
                Translations =

                [

                    new WorkExperienceResponsibilityTranslation { Language = "nl", Description = "Analyseren en oplossen van technische issues" },

                    new WorkExperienceResponsibilityTranslation { Language = "en", Description = "Analyzing and resolving technical issues" }

                ],
                SortOrder = 2
            },
            new WorkExperienceResponsibility
            {
                Translations =

                [

                    new WorkExperienceResponsibilityTranslation { Language = "nl", Description = "Documenteren van oplossingen en processen" },

                    new WorkExperienceResponsibilityTranslation { Language = "en", Description = "Documenting solutions and processes" }

                ],
                SortOrder = 3
            },
            new WorkExperienceResponsibility
            {
                Translations =

                [

                    new WorkExperienceResponsibilityTranslation { Language = "nl", Description = "Samenwerken met ontwikkelteams voor bugfixes" },

                    new WorkExperienceResponsibilityTranslation { Language = "en", Description = "Collaborating with development teams on bug fixes" }

                ],
                SortOrder = 4
            },
            new WorkExperienceResponsibility
            {
                Translations =

                [

                    new WorkExperienceResponsibilityTranslation { Language = "nl", Description = "Testen van nieuwe softwareversies" },

                    new WorkExperienceResponsibilityTranslation { Language = "en", Description = "Testing new software releases" }

                ],
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
        Organization = organizations["Gemeente Rotterdam"],
        Translations =

        [

            new WorkExperienceTranslation { Language = "nl", Role = "Senior Klantcontact Centrum" },

            new WorkExperienceTranslation { Language = "en", Role = "Senior Customer Contact Center" }

        ],
        StartYear = null,
        EndYear = null,
        SortOrder = 2,

        Responsibilities =
        [
            new WorkExperienceResponsibility
            {
                Translations =

                [

                    new WorkExperienceResponsibilityTranslation { Language = "nl", Description = "Aanpakken van complexe klantvragen en problemen" },

                    new WorkExperienceResponsibilityTranslation { Language = "en", Description = "Handling complex customer questions and issues" }

                ],
                SortOrder = 1
            },
            new WorkExperienceResponsibility
            {
                Translations =

                [

                    new WorkExperienceResponsibilityTranslation { Language = "nl", Description = "Begeleiden en coachen van teamleden" },

                    new WorkExperienceResponsibilityTranslation { Language = "en", Description = "Mentoring and coaching team members" }

                ],
                SortOrder = 2
            },
            new WorkExperienceResponsibility
            {
                Translations =

                [

                    new WorkExperienceResponsibilityTranslation { Language = "nl", Description = "Optimaliseren van werkprocessen" },

                    new WorkExperienceResponsibilityTranslation { Language = "en", Description = "Optimizing workflows" }

                ],
                SortOrder = 3
            },
            new WorkExperienceResponsibility
            {
                Translations =

                [

                    new WorkExperienceResponsibilityTranslation { Language = "nl", Description = "Communiceren met diverse afdelingen" },

                    new WorkExperienceResponsibilityTranslation { Language = "en", Description = "Communicating across departments" }

                ],
                SortOrder = 4
            },
            new WorkExperienceResponsibility
            {
                Translations =

                [

                    new WorkExperienceResponsibilityTranslation { Language = "nl", Description = "Bijdragen aan klanttevredenheid en servicekwaliteit" },

                    new WorkExperienceResponsibilityTranslation { Language = "en", Description = "Contributing to customer satisfaction and service quality" }

                ],
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

    var denHaag = new WorkExperience
    {
        Organization = organizations["Gemeente Den Haag"],
        Translations =

        [

            new WorkExperienceTranslation { Language = "nl", Role = "Linux Engineer" },

            new WorkExperienceTranslation { Language = "en", Role = "Linux Engineer" }

        ],
        StartYear = 2026,
        EndYear = null,
        SortOrder = 0,
        Responsibilities =
        [
            new WorkExperienceResponsibility { Translations =
 [
     new WorkExperienceResponsibilityTranslation { Language = "nl", Description = "Beheren en troubleshooten van Linux-servers en enterprise-applicaties" },
     new WorkExperienceResponsibilityTranslation { Language = "en", Description = "Managing and troubleshooting Linux servers and enterprise applications" }
 ], SortOrder = 1 },
            new WorkExperienceResponsibility { Translations =
 [
     new WorkExperienceResponsibilityTranslation { Language = "nl", Description = "Automatiseren van configuratie en deployments met Ansible en AWX" },
     new WorkExperienceResponsibilityTranslation { Language = "en", Description = "Automating configuration and deployments with Ansible and AWX" }
 ], SortOrder = 2 },
            new WorkExperienceResponsibility { Translations =
 [
     new WorkExperienceResponsibilityTranslation { Language = "nl", Description = "Werken met onder andere Kubernetes en Elasticsearch" },
     new WorkExperienceResponsibilityTranslation { Language = "en", Description = "Working with Kubernetes, Elasticsearch and other technologies" }
 ], SortOrder = 3 },
            new WorkExperienceResponsibility { Translations =
 [
     new WorkExperienceResponsibilityTranslation { Language = "nl", Description = "Onderzoeken van incidenten, logging en monitoring" },
     new WorkExperienceResponsibilityTranslation { Language = "en", Description = "Investigating incidents, logging and monitoring" }
 ], SortOrder = 4 }
        ],
        Technologies =
        [
            technologies["Linux"],
            technologies["RHEL"],
            technologies["SUSE Linux Enterprise"],
            technologies["openSUSE Tumbleweed"],
            technologies["Ansible"],
            technologies["K3s"],
            technologies["Kubernetes"],
            technologies["Cilium"],
            technologies["Elasticsearch"],
            technologies["Bash"]
        ],
        Skills =
        [
            skills["Oplossingsgericht denken"], skills["Helder documenteren"],
            skills["Softwarearchitectuur"], skills["Samenwerken"]
        ],
        Tooling =
        [
            tooling["Git"],
            tooling["AWX"],
            tooling["Azure DevOps"],
            tooling["LazyVim"],
            tooling["Harbor"],
            tooling["Zabbix"],
            tooling["Adeptia"],
            tooling["Red Hat AMQ"],
            tooling["Kitodo"]
        ]
    };

    context.WorkExperiences.AddRange(
        denHaag,
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
        .Include(x => x.Translations)
        .ToDictionaryAsync(x => x.Translations.Single(t => t.Language == "nl").Name);

    // Books

    var htmlCss = new LibraryItem
    {
        Title = "HTML 5 en CSS",
        Creator = "Peter Doolaard",
        Type = LibraryItemType.Book,
        SortOrder = 1,
        Media = CreateImage(
            "/media/library/book-htmlencss-doolaard.webp",
            "Boekcover HTML 5 en CSS van Peter Doolaard"),
        Technologies = [technologies["HTML"], technologies["CSS"]]
    };

    var informatiemanagement = new LibraryItem
    {
        Title = "Informatiemanagement",
        Creator = "Roel Grit",
        Type = LibraryItemType.Book,
        SortOrder = 2,
        Media = CreateImage(
            "/media/library/book-informatiemanagement-grit.webp",
            "Boekcover Informatiemanagement van Roel Grit")
    };

    var inleidingDatabases = new LibraryItem
    {
        Title = "Inleiding databases",
        Creator = "Ben Groenendijk",
        Type = LibraryItemType.Book,
        SortOrder = 3,
        Media = CreateImage(
            "/media/library/book-inleidingdatabases-groenendijk.webp",
            "Boekcover Inleiding databases van Ben Groenendijk"),
        Skills = [skills["Databaseontwerp"]]
    };

    var devOpsForTheDesperate = new LibraryItem
    {
        Title = "DevOps for the Desperate",
        Creator = "Bradley Smith",
        Type = LibraryItemType.Book,
        SortOrder = 4,
        Media = CreateImage(
            "/media/library/book-devops-for-the-desperate.webp",
            "Boekcover DevOps for the Desperate van Bradley Smith")
    };

    var javascriptJquery = new LibraryItem
    {
        Title = "JavaScript & jQuery",
        Creator = "Peter Kassenaar",
        Type = LibraryItemType.Book,
        SortOrder = 5,
        Media = CreateImage(
            "/media/library/book-javascript&jquery-kassenaar.webp",
            "Boekcover JavaScript & jQuery van Peter Kassenaar"),
        Technologies = [technologies["JavaScript"]]
    };

    var praktischUml = new LibraryItem
    {
        Title = "Praktisch UML",
        Creator = "Jos Warmer & Anneke Kleppe",
        Type = LibraryItemType.Book,
        SortOrder = 6,
        Media = CreateImage(
            "/media/library/book-praktischuml-warmer-kleppe.webp",
            "Boekcover Praktisch UML van Jos Warmer & Anneke Kleppe"),
        Technologies = [technologies["UML"]],
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
            "/media/library/book-pythoncrashcourse-matthes.webp",
            "Boekcover Python Crash Course van Eric Matthes"),
        Technologies = [technologies["Python"]]
    };

    var subliemWebdesign = new LibraryItem
    {
        Title = "Principes van subliem webdesign",
        Creator = "Jason Beaird & James George",
        Type = LibraryItemType.Book,
        SortOrder = 8,
        Media = CreateImage(
            "/media/library/book-subliemwebdesign.webp",
            "Boekcover Principes van subliem webdesign"),
        Skills = [skills["UI/UX"]]
    };

    var linuxCommandLine = new LibraryItem
    {
        Title = "The Linux Command Line",
        Creator = "William Shotts",
        Type = LibraryItemType.Book,
        SortOrder = 9,
        Media = CreateImage(
            "/media/library/book-linuxcommandline.webp",
            "Boekcover The Linux Command Line van William Shotts"),
        Technologies = [technologies["Bash"]]
    };

    var grafischOntwerpen = new LibraryItem
    {
        Title = "Grafisch Ontwerpen",
        Creator = "David Dabner & Sandra Stewart",
        Type = LibraryItemType.Book,
        SortOrder = 10,
        Media = CreateImage(
            "/media/library/book-grafischontwerpen.webp",
            "Boekcover Grafisch Ontwerpen"),
        Skills = [skills["UI/UX"]]
    };

    var thisIsIt = new LibraryItem
    {
        Title = "This is IT!",
        Creator = "Victor Peters",
        Type = LibraryItemType.Book,
        SortOrder = 11,
        Media = CreateImage(
            "/media/library/book-thisisit.webp",
            "Boekcover This is IT! van Victor Peters")
    };

    var wordpress6 = new LibraryItem
    {
        Title = "Handboek Wordpress 6",
        Creator = "Dirkjan van Ittersum",
        Type = LibraryItemType.Book,
        SortOrder = 12,
        Media = CreateImage(
            "/media/library/book-wordpress6.webp",
            "Boekcover Handboek Wordpress 6"),
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
            "/media/library/book-inleidinguml.webp",
            "Boekcover Inleiding UML"),
        Technologies = [technologies["UML"]],
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
            "/media/library/book-principes-van-databases.webp",
            "Boekcover Principes van Databases"),
        Skills = [skills["Databaseontwerp"]]
    };

    var creativeAct = new LibraryItem
    {
        Title = "The Creative Act",
        Creator = "Rick Rubin",
        Type = LibraryItemType.Book,
        SortOrder = 15,
        Media = CreateImage(
            "/media/library/book-the-creative-act.webp",
            "Boekcover The Creative Act"),
        Skills = [skills["Creativiteit"]]
    };

    var kotlinInAction = new LibraryItem
    {
        Title = "Kotlin in Action",
        Creator = "Dmitry Jemerov",
        Type = LibraryItemType.Book,
        SortOrder = 16,
        Media = CreateImage(
            "/media/library/book-kotlin-in-action.webp",
            "Boekcover Kotlin in Action"),
        Technologies = [technologies["Kotlin"]],
        Skills = [skills["Objectgeoriënteerd programmeren"]]
    };

    var shellScripting = new LibraryItem
    {
        Title = "Shell Scripting",
        Creator = "Steve Parker",
        Type = LibraryItemType.Book,
        SortOrder = 17,
        Media = CreateImage(
            "/media/library/book-shell-scripting.webp",
            "Boekcover Shell Scripting"),
        Technologies = [technologies["Bash"]]
    };

    var krachtVanHetNu = new LibraryItem
    {
        Title = "De kracht van het Nu",
        Creator = "Eckhart Tolle",
        Type = LibraryItemType.Book,
        SortOrder = 18,
        Media = CreateImage(
            "/media/library/book-de-kracht-van-het-nu.webp",
            "Boekcover De kracht van het Nu")
    };

    // Video

    var chungkingExpress = new LibraryItem
    {
        Title = "Chungking Express",
        Creator = "Wong Kar-wai",
        Type = LibraryItemType.Video,
        SortOrder = 1,
        Media = CreateImage(
            "/media/library/movie-chungkingexpress.webp",
            "Filmposter Chungking Express")
    };

    var graveOfTheFireflies = new LibraryItem
    {
        Title = "Grave of the Fireflies",
        Creator = "Isao Takahata",
        Type = LibraryItemType.Video,
        SortOrder = 2,
        Media = CreateImage(
            "/media/library/movie-graveofthefireflies.webp",
            "Filmposter Grave of the Fireflies")
    };

    var bootstrapCrashCourse = new LibraryItem
    {
        Title = "Bootstrap 5 Tutorial",
        Creator = "The Net Ninja",
        Type = LibraryItemType.Video,
        SortOrder = 3,
        Media = CreateImage(
            "/media/library/movie-netninja-bootstrapcrashcourse.webp",
            "Bootstrap 5 tutorial van The Net Ninja")
    };

    var dockerCrashCourse = new LibraryItem
    {
        Title = "Docker Crash Course",
        Creator = "The Net Ninja",
        Type = LibraryItemType.Video,
        SortOrder = 4,
        Media = CreateImage(
            "/media/library/movie-netninja-dockercrashcource.webp",
            "Docker Crash Course van The Net Ninja")
    };

    var phpCrashCourse = new LibraryItem
    {
        Title = "PHP & MySQL Tutorial",
        Creator = "The Net Ninja",
        Type = LibraryItemType.Video,
        SortOrder = 5,
        Media = CreateImage(
            "/media/library/movie-netninja-phpcrashcourse.webp",
            "PHP en MySQL tutorial van The Net Ninja")
    };

    var freeCcna = new LibraryItem
    {
        Title = "Free CCNA Complete Course",
        Creator = "NetworkChuck",
        Type = LibraryItemType.Video,
        SortOrder = 6,
        Media = CreateImage(
            "/media/library/movie-networkchuck-freeccna.webp",
            "Free CCNA Complete Course van NetworkChuck")
    };

    var rockers = new LibraryItem
    {
        Title = "Rockers",
        Creator = "Theodoros Bafaloukos",
        Type = LibraryItemType.Video,
        SortOrder = 7,
        Media = CreateImage(
            "/media/library/movie-rockers.webp",
            "Filmposter Rockers")
    };

    // Music

    var plingelyPlang = new LibraryItem
    {
        Title = "Plingely Plang",
        Creator = "Spotify",
        Type = LibraryItemType.Music,
        SortOrder = 1,
        Media = CreateImage(
            "/media/library/music-spotify-plingelyplang.webp",
            "Spotify playlist Plingely Plang")
    };

    var freewheelin = new LibraryItem
    {
        Title = "The Freewheelin' Bob Dylan",
        Creator = "Bob Dylan",
        Type = LibraryItemType.Music,
        SortOrder = 2,
        Media = CreateImage(
            "/media/library/music-bobdylan-thefreewheelin.webp",
            "Albumcover The Freewheelin' Bob Dylan")
    };

    var jazzImpressions = new LibraryItem
    {
        Title = "Jazz Impressions of Japan",
        Creator = "The Dave Brubeck Quartet",
        Type = LibraryItemType.Music,
        SortOrder = 3,
        Media = CreateImage(
            "/media/library/music-davebrubeck-jazzimpressionsofjapan.webp",
            "Albumcover Jazz Impressions of Japan")
    };

    var blonde = new LibraryItem
    {
        Title = "Blonde",
        Creator = "Frank Ocean",
        Type = LibraryItemType.Music,
        SortOrder = 4,
        Media = CreateImage(
            "/media/library/music-frankocean-blonde.webp",
            "Albumcover Blonde")
    };

    var onYourOwnLoveAgain = new LibraryItem
    {
        Title = "On Your Own Love Again",
        Creator = "Jessica Pratt",
        Type = LibraryItemType.Music,
        SortOrder = 5,
        Media = CreateImage(
            "/media/library/music-jessicapratt-onyourownloveagain.webp",
            "Albumcover On Your Own Love Again")
    };

    var whatsGoingOn = new LibraryItem
    {
        Title = "What's Going On",
        Creator = "Marvin Gaye",
        Type = LibraryItemType.Music,
        SortOrder = 6,
        Media = CreateImage(
            "/media/library/music-marvingaye-whatsgoingon.webp",
            "Albumcover What's Going On")
    };

    context.LibraryItems.AddRange(
        // Books
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
        krachtVanHetNu,

        // Video
        chungkingExpress,
        graveOfTheFireflies,
        bootstrapCrashCourse,
        dockerCrashCourse,
        phpCrashCourse,
        freeCcna,
        rockers,

        // Music
        plingelyPlang,
        freewheelin,
        jazzImpressions,
        blonde,
        onYourOwnLoveAgain,
        whatsGoingOn
    );

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
