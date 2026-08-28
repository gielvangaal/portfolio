using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Configurations;

public class ContactConfiguration
    : IEntityTypeConfiguration<Contact>
{
    public void Configure(EntityTypeBuilder<Contact> builder)
    {
        builder.ToTable("Contact");

        builder.HasKey(x => x.Id);

        builder.Property(x => x.Language)
            .IsRequired()
            .HasMaxLength(2);

        builder.HasIndex(x => x.Language)
            .IsUnique();

        builder.Property(x => x.Name)
            .IsRequired()
            .HasMaxLength(100);

        builder.Property(x => x.Phone)
            .IsRequired()
            .HasMaxLength(50);

        builder.Property(x => x.Email)
            .IsRequired()
            .HasMaxLength(150);

        builder.Property(x => x.Location)
            .IsRequired()
            .HasMaxLength(100);

        builder.Property(x => x.GitHubUrl)
            .IsRequired()
            .HasMaxLength(500);

        builder.Property(x => x.LinkedInUrl)
            .IsRequired()
            .HasMaxLength(500);

        builder.Property(x => x.InstagramUrl)
            .IsRequired()
            .HasMaxLength(500);

        builder.Property(x => x.SpotifyUrl)
            .IsRequired()
            .HasMaxLength(500);

        builder.Property(x => x.CreditText)
            .IsRequired()
            .HasMaxLength(150);
    }
}