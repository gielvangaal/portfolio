
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data;

public class PortfolioDbContext : DbContext
{
    public PortfolioDbContext(DbContextOptions options)
        : base(options)
    {
    }

    // Page sections
    public DbSet<Hero> Heroes { get; set; }
    public DbSet<PortfolioItem> PortfolioItems { get; set; }
    public DbSet<AboutProfile> AboutProfiles { get; set; }
    public DbSet<Education> Educations { get; set; }
    public DbSet<WorkExperience> WorkExperiences { get; set; }
    public DbSet<LibraryItem> LibraryItems { get; set; }
    public DbSet<Contact> Contacts { get; set; }

    // Supporting entities
    public DbSet<Technology> Technologies { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<GitHubLink> GitHubLinks { get; set; }
    public DbSet<EducationSection> EducationSections { get; set; }
    public DbSet<WorkExperienceResponsibility> WorkExperienceResponsibilities { get; set; }
    public DbSet<Skill> Skills { get; set; }
    public DbSet<Tooling> Tooling { get; set; }
    public DbSet<Organization> Organizations { get; set; }
    public DbSet<Credential> Credentials { get; set; }

    // Translations
    public DbSet<SkillTranslation> SkillTranslations { get; set; }
    public DbSet<EducationTranslation> EducationTranslations { get; set; }
    public DbSet<EducationSectionTranslation> EducationSectionTranslations { get; set; }
    public DbSet<WorkExperienceTranslation> WorkExperienceTranslations { get; set; }
    public DbSet<WorkExperienceResponsibilityTranslation> WorkExperienceResponsibilityTranslations { get; set; }

    // Media and relationships
    public DbSet<Media> Media { get; set; }
    public DbSet<PortfolioItemMedia> PortfolioItemMedia { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(
            typeof(PortfolioDbContext).Assembly
        );

        modelBuilder.Entity<Skill>()
            .HasIndex(x => x.Key)
            .IsUnique();

        modelBuilder.Entity<SkillTranslation>()
            .HasIndex(x => new { x.SkillId, x.Language })
            .IsUnique();

        modelBuilder.Entity<EducationTranslation>()
            .HasIndex(x => new { x.EducationId, x.Language })
            .IsUnique();

        modelBuilder.Entity<EducationSectionTranslation>()
            .HasIndex(x => new { x.EducationSectionId, x.Language })
            .IsUnique();

        modelBuilder.Entity<WorkExperienceTranslation>()
            .HasIndex(x => new { x.WorkExperienceId, x.Language })
            .IsUnique();

        modelBuilder.Entity<WorkExperienceResponsibilityTranslation>()
            .HasIndex(x => new { x.WorkExperienceResponsibilityId, x.Language })
            .IsUnique();

        base.OnModelCreating(modelBuilder);
    }
}
