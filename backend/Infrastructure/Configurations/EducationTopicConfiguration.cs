using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Configurations;

public class EducationTopicConfiguration
    : IEntityTypeConfiguration<EducationTopic>
{
    public void Configure(EntityTypeBuilder<EducationTopic> builder)
    {
        builder.HasKey(x => x.Id);

        builder.Property(x => x.Name)
            .IsRequired()
            .HasMaxLength(150);

        builder.Property(x => x.SortOrder)
            .IsRequired();
    }
}