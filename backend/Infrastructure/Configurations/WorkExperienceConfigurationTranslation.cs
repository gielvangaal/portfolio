using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Configurations;

public class WorkExperienceTranslationConfiguration
    : IEntityTypeConfiguration<WorkExperienceTranslation>
{
    public void Configure(
        EntityTypeBuilder<WorkExperienceTranslation> builder)
    {
        builder.HasKey(x => x.Id);

        builder.Property(x => x.Language)
            .IsRequired()
            .HasMaxLength(2);

        builder.Property(x => x.Role)
            .IsRequired()
            .HasMaxLength(150);
    }
}