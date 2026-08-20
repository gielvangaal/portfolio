using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Configurations;

public class PortfolioItemConfiguration
    : IEntityTypeConfiguration<PortfolioItem>
{
    public void Configure(EntityTypeBuilder<PortfolioItem> builder)
    {
        builder.Property(x => x.Language)
            .IsRequired()
            .HasMaxLength(2);

        builder.Property(x => x.Slug)
            .IsRequired()
            .HasMaxLength(150);

        builder.Property(x => x.Title)
            .IsRequired()
            .HasMaxLength(150);

        builder.Property(x => x.CardDescription)
            .IsRequired()
            .HasMaxLength(300);

        builder.Property(x => x.Description)
            .IsRequired();

        builder.Property(x => x.ProjectDate)
            .IsRequired();

        builder.Property(x => x.ProjectType)
            .IsRequired();

        builder.Property(x => x.Role)
            .IsRequired()
            .HasMaxLength(100);

        builder.Property(x => x.Duration)
            .HasMaxLength(100);

        builder.Property(x => x.GitHubUrl)
            .HasMaxLength(500);

        builder.Property(x => x.LiveSiteUrl)
            .HasMaxLength(500);

        builder.HasIndex(x => new
        {
            x.Slug,
            x.Language
        }).IsUnique();

        builder.HasIndex(x => x.ProjectDate);
    }
}