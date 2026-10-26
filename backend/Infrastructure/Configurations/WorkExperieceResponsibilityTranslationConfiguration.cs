using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Configurations;

public class WorkExperienceResponsibilityTranslationConfiguration
    : IEntityTypeConfiguration<WorkExperienceResponsibilityTranslation>
{
    public void Configure(
        EntityTypeBuilder<WorkExperienceResponsibilityTranslation> builder)
    {
        builder.HasKey(x => x.Id);

        builder.Property(x => x.Language)
            .IsRequired()
            .HasMaxLength(2);

        builder.Property(x => x.Description)
            .IsRequired()
            .HasMaxLength(500);
    }
}