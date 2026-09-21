namespace Diary.Api.Domain;

public sealed class User
{
    public Guid Id { get; init; }
    public required string Email { get; set; }
    public required string GoogleSubjectId { get; set; }
    public string? DisplayName { get; set; }
    public string? PushToken { get; set; }
    public DateTimeOffset CreatedAtUtc { get; init; }

    public List<Entry> Entries { get; init; } = [];
    public List<RefreshToken> RefreshTokens { get; init; } = [];
}
