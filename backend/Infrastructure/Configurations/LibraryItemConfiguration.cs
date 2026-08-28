using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Configurations;

public class LibraryItemConfiguration
    : IEntityTypeConfiguration<LibraryItem>
{
    public void Configure(
        EntityTypeBuilder<LibraryItem> builder)
    {
        builder.HasKey(x => x.Id);

        builder.Property(x => x.Title)
            .IsRequired()
            .HasMaxLength(200);

        builder.Property(x => x.Creator)
            .IsRequired()
            .HasMaxLength(150);

        builder.Property(x => x.Type)
            .IsRequired();

        builder.Property(x => x.SortOrder)
            .IsRequired();

        builder.HasOne(x => x.Media)
            .WithMany()
            .HasForeignKey(x => x.MediaId)
            .OnDelete(DeleteBehavior.SetNull);

        builder.HasMany(x => x.Technologies)
            .WithMany();

        builder.HasMany(x => x.Skills)
            .WithMany();

        builder.HasMany(x => x.Tooling)
            .WithMany();
    }
}