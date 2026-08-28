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

    // Supporting entities
    public DbSet<Technology> Technologies { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<GitHubLink> GitHubLinks { get; set; }
    public DbSet<EducationSection> EducationSections { get; set; }
    public DbSet<EducationTopic> EducationTopics { get; set; }
    public DbSet<Skill> Skills { get; set; }

    // Media and relationships
    public DbSet<Media> Media { get; set; }
    public DbSet<PortfolioItemMedia> PortfolioItemMedia { get; set; }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(PortfolioDbContext).Assembly);

        base.OnModelCreating(modelBuilder);
    }
}