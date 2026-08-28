using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Configurations;

public class EducationSectionConfiguration
    : IEntityTypeConfiguration<EducationSection>
{
    public void Configure(EntityTypeBuilder<EducationSection> builder)
    {
        builder.HasKey(x => x.Id);

        builder.Property(x => x.Title)
            .HasMaxLength(150);

        builder.Property(x => x.SortOrder)
            .IsRequired();

        builder.HasMany(x => x.Topics)
            .WithOne(x => x.EducationSection)
            .HasForeignKey(x => x.EducationSectionId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasMany(x => x.Technologies)
            .WithMany();
    }
}