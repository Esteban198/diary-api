using Diary.Api.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Diary.Api.Infrastructure.Persistence.Configurations;

public sealed class EntryConfiguration : IEntityTypeConfiguration<Entry>
{
    public void Configure(EntityTypeBuilder<Entry> builder)
    {
        builder.ToTable("entries");
        builder.HasKey(e => e.Id);

        builder.Property(e => e.Title).HasMaxLength(200);
        builder.Property(e => e.Content).IsRequired();
        builder.Property(e => e.Mood).HasMaxLength(50);
        builder.Property(e => e.TemplateKey).HasMaxLength(100);

        builder.HasIndex(e => new { e.UserId, e.UpdatedAtUtc });

        builder.HasOne(e => e.User)
            .WithMany(u => u.Entries)
            .HasForeignKey(e => e.UserId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}
