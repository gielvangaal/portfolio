using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Configurations;

public class WorkExperienceConfiguration
    : IEntityTypeConfiguration<WorkExperience>
{
    public void Configure(
        EntityTypeBuilder<WorkExperience> builder)
    {
        builder.HasKey(x => x.Id);

        builder.Property(x => x.Role)
            .IsRequired()
            .HasMaxLength(150);

        builder.Property(x => x.SortOrder)
            .IsRequired();

        builder.HasOne(x => x.Organization)
            .WithMany(x => x.WorkExperiences)
            .HasForeignKey(x => x.OrganizationId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasMany(x => x.Responsibilities)
            .WithOne(x => x.WorkExperience)
            .HasForeignKey(x => x.WorkExperienceId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasMany(x => x.Technologies)
            .WithMany();

        builder.HasMany(x => x.Skills)
            .WithMany();

        builder.HasMany(x => x.Tooling)
            .WithMany();
    }
}