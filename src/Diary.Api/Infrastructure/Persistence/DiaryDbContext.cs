using Diary.Api.Domain;
using Microsoft.EntityFrameworkCore;

namespace Diary.Api.Infrastructure.Persistence;

public sealed class DiaryDbContext(DbContextOptions<DiaryDbContext> options) : DbContext(options)
{
    public DbSet<User> Users => Set<User>();
    public DbSet<Entry> Entries => Set<Entry>();
    public DbSet<Photo> Photos => Set<Photo>();
    public DbSet<RefreshToken> RefreshTokens => Set<RefreshToken>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(DiaryDbContext).Assembly);

        modelBuilder.Entity<User>(user =>
        {
            user.ToTable("users");
            user.HasKey(u => u.Id);
            user.Property(u => u.Email).IsRequired().HasMaxLength(320);
            user.Property(u => u.GoogleSubjectId).IsRequired().HasMaxLength(255);
            user.Property(u => u.DisplayName).HasMaxLength(200);
            user.Property(u => u.PushToken).HasMaxLength(500);
            user.HasIndex(u => u.Email).IsUnique();
            user.HasIndex(u => u.GoogleSubjectId).IsUnique();
        });

        modelBuilder.Entity<RefreshToken>(token =>
        {
            token.ToTable("refresh_tokens");
            token.HasKey(t => t.Id);
            token.Property(t => t.TokenHash).IsRequired().HasMaxLength(200);
            token.HasIndex(t => t.TokenHash).IsUnique();

            token.HasOne(t => t.User)
                .WithMany(u => u.RefreshTokens)
                .HasForeignKey(t => t.UserId)
                .OnDelete(DeleteBehavior.Cascade);
        });
    }
}
