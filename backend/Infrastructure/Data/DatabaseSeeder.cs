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
                Name = "Functioneel programmeren",
                Type = SkillType.Technical
            },
            new Skill
            {
                Name = "Software testing",
                Type = SkillType.Technical
            },
            new Skill
            {
                Name = "Agile werken",
                Type = SkillType.SoftSkill
            },
            new Skill
            {
                Name = "Scrum",
                Type = SkillType.SoftSkill
            },
            new Skill
            {
                Name = "Design patterns",
                Type = SkillType.Technical
            },
            new Skill
            {
                Name = "Projectmatig werken",
                Type = SkillType.SoftSkill
            },
            new Skill
            {
                Name = "Systeemontwerp",
                Type = SkillType.Technical
            },
            new Skill
            {
                Name = "Softwarearchitectuur",
                Type = SkillType.Technical
            },
            new Skill
            {
                Name = "Databaseontwerp",
                Type = SkillType.Technical
            },
            new Skill
            {
                Name = "CI/CD-pipelines",
                Type = SkillType.Technical
            },
            new Skill
            {
                Name = "Objectgeoriënteerd programmeren",
                Type = SkillType.Technical
            },

            // Softskills - vaardigheden

            new Skill
            {
                Name = "Praktische instelling",
                Type = SkillType.SoftSkill
            },
            new Skill
            {
                Name = "Sociale vaardigheden",
                Type = SkillType.SoftSkill
            },
            new Skill
            {
                Name = "Zelfstandigheid",
                Type = SkillType.SoftSkill
            },
            new Skill
            {
                Name = "Nauwkeurig en exact",
                Type = SkillType.SoftSkill
            },
            new Skill
            {
                Name = "Plannen en structureren",
                Type = SkillType.SoftSkill
            },
            new Skill
            {
                Name = "Effectief communiceren",
                Type = SkillType.SoftSkill
            },
            new Skill
            {
                Name = "Snel leren en toepassen",
                Type = SkillType.SoftSkill
            },
            new Skill
            {
                Name = "Helder documenteren",
                Type = SkillType.SoftSkill
            },

            // Softskills - competenties

            new Skill
            {
                Name = "Oplossingsgericht denken",
                Type = SkillType.SoftSkill
            },
            new Skill
            {
                Name = "Energie",
                Type = SkillType.SoftSkill
            },
            new Skill
            {
                Name = "Empathie",
                Type = SkillType.SoftSkill
            },
            new Skill
            {
                Name = "Creativiteit",
                Type = SkillType.SoftSkill
            },
            new Skill
            {
                Name = "Analytisch vermogen",
                Type = SkillType.SoftSkill
            },
            new Skill
            {
                Name = "Zelfstandig leren",
                Type = SkillType.SoftSkill
            },
            new Skill
            {
                Name = "Kwaliteitsbewustzijn",
                Type = SkillType.SoftSkill
            },
            new Skill
            {
                Name = "Flexibiliteit",
                Type = SkillType.SoftSkill
            },
            new Skill
            {
                Name = "Samenwerken",
                Type = SkillType.SoftSkill
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
                Type = SkillType.Technical
            },
            new Skill
            {
                Name = "Creatief ondernemen",
                Type = SkillType.SoftSkill
            },
            new Skill
            {
                Name = "Presentatievaardigheden",
                Type = SkillType.SoftSkill
            },
            new Skill
            {
                Name = "Marketing en communicatie",
                Type = SkillType.SoftSkill
            },
            new Skill
            {
                Name = "Methodisch werken",
                Type = SkillType.SoftSkill
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

    var php = technologies["PHP"];
    var mysql = technologies["MySQL"];

    var kotlin = technologies["Kotlin"];
    var ktor = technologies["Ktor"];
    var exposed = technologies["Exposed"];

    var python = technologies["Python"];
    var django = technologies["Django"];
    var docker = technologies["Docker"];

    var skills = await context.Skills
        .ToDictionaryAsync(x => x.Name);

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
            "CareBots begon als een teamproject rond zorgrobots. We ontwikkelden eerst een responsive website " +
            "en bouwden later een beheersysteem met gebruikersrollen en databasefunctionaliteit. " +
            "Ik werkte aan de frontend, PHP/MySQL-backend en herbruikbare componenten, " +
            "met aandacht voor ontwerp, samenwerking, testing en CI/CD.",

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
            "CareBots started as a team project focused on healthcare robots. We first developed a responsive website " +
            "and later added a management system with user roles and database functionality. " +
            "I worked on the frontend, PHP/MySQL backend and reusable components, " +
            "with a focus on design, collaboration, testing and CI/CD.",

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
            "JoyRide is een autoverhuurapp met een Android-frontend in Kotlin en Jetpack Compose " +
            "en een REST API in Kotlin/Ktor. De backend gebruikt Exposed en MySQL en is opgebouwd " +
            "in controllers, services en repositories. Binnen het team werkten we in sprints aan " +
            "de integratie, foutafhandeling en een overzichtelijke softwarearchitectuur.",

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
            "JoyRide is a car rental application with an Android frontend in Kotlin and Jetpack Compose " +
            "and a Kotlin/Ktor REST API. The backend uses Exposed and MySQL, organized into controllers, " +
            "services and repositories. Working in sprints, our team focused on integration, " +
            "error handling and maintainable software architecture.",

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
        Description = "Cine.NET is een bioscoopapplicatie met films, voorstellingen, stoelkeuze en een beheeromgeving. Binnen een team werkte ik aan de frontend in Blazor en MudBlazor en de koppeling met een .NET API. We organiseerden het werk met Scrum en Jira.",
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
        Description = "Cine.NET is a cinema booking application featuring movies, screenings, seat selection and an administration interface. As part of a team I worked on a Blazor/MudBlazor frontend and its integration with a .NET API, using Scrum and Jira.",
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
        Description = "SoulSearch is een cross-platform applicatie ontwikkeld met C#, .NET MAUI Blazor Hybrid en een afzonderlijke API. De gedeelde Blazor-interface combineert webtechnologie met een native app. Tijdens dit project lag de nadruk op softwarearchitectuur, API-integratie en het testen van functionaliteit.",
        ProjectDate = new DateOnly(2026, 5, 1),
        ProjectType = ProjectType.Education,
        Role = "Software Developer",
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
        Description = "SoulSearch is a cross-platform application developed using C#, .NET MAUI Blazor Hybrid and a separate API. Its shared Blazor interface combines web technology with a native application, with a focus on software architecture, API integration and functional testing.",
        ProjectDate = new DateOnly(2026, 5, 1),
        ProjectType = ProjectType.Education,
        Role = "Software Developer",
        Categories = [frontend, backend],
        Technologies = [technologies["C#"], technologies[".NET"], technologies["Blazor"], technologies["MudBlazor"], technologies[".NET MAUI"], technologies["ASP.NET Core"], technologies["REST API"]],
        Skills = [skills["Software testing"], skills["Softwarearchitectuur"], skills["Samenwerken"]],
        Tooling = [tooling["Git"], tooling["Jira"], tooling["JetBrains Rider"], tooling["ChatGPT"]]
    };

    context.PortfolioItems.AddRange(
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
    
    var organizations = await context.Organizations
        .ToDictionaryAsync(x => x.Name);

    var redhat = new Education
    {
        Organization = organizations["Red Hat"],
        Program = "RHCSA",
        StartYear = 2026,
        EndYear = null,
        SortOrder = 1,
        
        Sections =
        [
            new EducationSection
            {
                Title = null,
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
        Program = "Deeltijdopleiding Informatica",
        StartYear = 2024,
        EndYear = null,
        SortOrder = 2,

        Sections =
        [
            new EducationSection
            {
                Title = "Leerjaar 3",
                SortOrder = 0,
                
                Technologies = 
                [
                    technologies["Python"],
                    technologies["MySQL"]
                ],
                Skills =
                [
                    skills["Databaseontwerp"], 
                    skills["Analytisch vermogen"]
                ],
                Tooling = 
                [
                    tooling["Microsoft Excel"],
                    tooling["Microsoft Power BI"]
                ]
            },
            new EducationSection
            {
                Title = "Leerjaar 2",
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
        Organization = organizations["Codecademy"],
        Program = "Web Development",
        StartYear = 2023,
        EndYear = null,
        SortOrder = 3,

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
        Organization = organizations["Albeda College"],
        Program = "Muzikant / Producer",
        StartYear = 2012,
        EndYear = 2015,
        SortOrder = 4,

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
        Organization = organizations["Koning Willem 1 College"],
        Program = "Sociaal Cultureel Werk",
        StartYear = 2004,
        EndYear = 2009,
        SortOrder = 5,

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
    
    var organizations = await context.Organizations
        .ToDictionaryAsync(x => x.Name);

    var bcs = new WorkExperience
    {
        Organization = organizations["BCS HR Solutions"],
        Role = "Software Support Specialist",
        StartYear = null,
        EndYear = null,
        SortOrder = 1,

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
        Organization = organizations["Gemeente Rotterdam"],
        Role = "Senior Klantcontact Centrum",
        StartYear = null,
        EndYear = null,
        SortOrder = 2,

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

    var denHaag = new WorkExperience
    {
        Organization = organizations["Gemeente Den Haag"],
        Role = "Linux Engineer",
        StartYear = 2026,
        EndYear = null,
        SortOrder = 0,
        Responsibilities =
        [
            new WorkExperienceResponsibility { Description = "Beheren en troubleshooten van Linux-servers en enterprise-applicaties", SortOrder = 1 },
            new WorkExperienceResponsibility { Description = "Automatiseren van configuratie en deployments met Ansible en AWX", SortOrder = 2 },
            new WorkExperienceResponsibility { Description = "Werken met onder andere Kubernetes en Elasticsearch", SortOrder = 3 },
            new WorkExperienceResponsibility { Description = "Onderzoeken van incidenten, logging en monitoring", SortOrder = 4 }
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
            technologies["Bash"]
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
            technologies["Bash"]
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
