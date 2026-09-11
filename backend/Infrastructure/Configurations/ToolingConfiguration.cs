using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Configurations;

public class ToolingConfiguration : IEntityTypeConfiguration<Tooling>
{
    public void Configure(EntityTypeBuilder<Tooling> builder)
    {
        builder.HasKey(x => x.Id);

        builder.Property(x => x.Name)
            .IsRequired()
            .HasMaxLength(150);

        builder.Property(x => x.Usage)
            .IsRequired();

        builder.HasIndex(x => x.Name)
            .IsUnique();

        builder.HasOne(x => x.Media)
            .WithMany()
            .HasForeignKey(x => x.MediaId)
            .OnDelete(DeleteBehavior.SetNull);
    }
}