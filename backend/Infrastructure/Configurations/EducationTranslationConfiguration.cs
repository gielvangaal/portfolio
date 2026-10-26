using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Configurations;

public class EducationTranslationConfiguration
    : IEntityTypeConfiguration<EducationTranslation>
{
    public void Configure(EntityTypeBuilder<EducationTranslation> builder)
    {
        builder.HasKey(x => x.Id);

        builder.Property(x => x.Language)
            .IsRequired()
            .HasMaxLength(2);

        builder.Property(x => x.Program)
            .IsRequired()
            .HasMaxLength(150);
    }
}