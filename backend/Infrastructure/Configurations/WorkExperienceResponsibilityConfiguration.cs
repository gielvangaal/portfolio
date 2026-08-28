using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Configurations;

public class WorkExperienceResponsibilityConfiguration
    : IEntityTypeConfiguration<WorkExperienceResponsibility>
{
    public void Configure(
        EntityTypeBuilder<WorkExperienceResponsibility> builder)
    {
        builder.HasKey(x => x.Id);

        builder.Property(x => x.Description)
            .IsRequired()
            .HasMaxLength(500);

        builder.Property(x => x.SortOrder)
            .IsRequired();
    }
}