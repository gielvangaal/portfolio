using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Configurations;

public class PortfolioItemConfiguration : IEntityTypeConfiguration<PortfolioItem>
{
    public void Configure(EntityTypeBuilder<PortfolioItem> builder)
    {
        builder.ToTable("PortfolioItem");

        builder.HasKey(x => x.Id);

        builder.Property(x => x.Language)
            .IsRequired()
            .HasMaxLength(2);

        builder.Property(x => x.Slug)
            .IsRequired()
            .HasMaxLength(100);

        builder.Property(x => x.Title)
            .IsRequired()
            .HasMaxLength(150);

        builder.Property(x => x.CardDescription)
            .IsRequired()
            .HasMaxLength(300);

        builder.Property(x => x.Description)
            .HasColumnType("longtext");

        builder.Property(x => x.GitHubUrl)
            .HasMaxLength(500);

        builder.Property(x => x.LiveSiteUrl)
            .HasMaxLength(500);

        builder.HasIndex(x => new
        {
            x.Slug,
            x.Language
        }).IsUnique();
    }
}