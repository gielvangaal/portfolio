using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Configurations;

public class EducationSectionTranslationConfiguration
    : IEntityTypeConfiguration<EducationSectionTranslation>
{
    public void Configure(
        EntityTypeBuilder<EducationSectionTranslation> builder)
    {
        builder.HasKey(x => x.Id);

        builder.Property(x => x.Language)
            .IsRequired()
            .HasMaxLength(2);

        builder.Property(x => x.Title)
            .IsRequired()
            .HasMaxLength(150);
    }
}