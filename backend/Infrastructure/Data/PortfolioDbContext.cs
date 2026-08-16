using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data;

public class PortfolioDbContext : DbContext
{
    public PortfolioDbContext(DbContextOptions options)
        : base(options)
    {
    }

    public DbSet<Hero> Heroes { get; set; }
    public DbSet<Media> Media { get; set; }

    public DbSet<PortfolioItem> PortfolioItems { get; set; }
    public DbSet<Technology> Technologies { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<GitHubLink> GitHubLinks { get; set; }
    public DbSet<PortfolioItemMedia> PortfolioItemMedia { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(PortfolioDbContext).Assembly);

        base.OnModelCreating(modelBuilder);
    }
}