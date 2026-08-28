using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Configurations;

public class EducationConfiguration : IEntityTypeConfiguration<Education>
{
    public void Configure(EntityTypeBuilder<Education> builder)
    {
        builder.HasKey(x => x.Id);

        builder.Property(x => x.Institution)
            .IsRequired()
            .HasMaxLength(150);

        builder.Property(x => x.Program)
            .IsRequired()
            .HasMaxLength(150);

        builder.Property(x => x.StartYear)
            .IsRequired();

        builder.Property(x => x.SortOrder)
            .IsRequired();

        builder.HasOne(x => x.Media)
            .WithMany()
            .HasForeignKey(x => x.MediaId)
            .OnDelete(DeleteBehavior.SetNull);

        builder.HasMany(x => x.Sections)
            .WithOne(x => x.Education)
            .HasForeignKey(x => x.EducationId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}