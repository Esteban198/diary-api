namespace Diary.Api.Domain;

public sealed class Entry
{
    public Guid Id { get; init; }
    public required Guid UserId { get; set; }
    public string? Title { get; set; }
    public required string Content { get; set; }
    public string? Mood { get; set; }
    public string? TemplateKey { get; set; }
    public DateTimeOffset CreatedAtUtc { get; init; }
    public DateTimeOffset UpdatedAtUtc { get; set; }
    public DateTimeOffset? DeletedAtUtc { get; set; }

    public User? User { get; init; }
    public List<Photo> Photos { get; init; } = [];
}
