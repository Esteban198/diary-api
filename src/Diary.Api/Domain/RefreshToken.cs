namespace Diary.Api.Domain;

public sealed class RefreshToken
{
    public Guid Id { get; init; }
    public required Guid UserId { get; set; }
    public required string TokenHash { get; set; }
    public DateTimeOffset ExpiresAtUtc { get; set; }
    public DateTimeOffset CreatedAtUtc { get; init; }
    public DateTimeOffset? RevokedAtUtc { get; set; }
    public Guid? ReplacedByTokenId { get; set; }

    public bool IsActive => RevokedAtUtc is null && ExpiresAtUtc > DateTimeOffset.UtcNow;

    public User? User { get; init; }
}
