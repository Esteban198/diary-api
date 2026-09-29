namespace Diary.Api.Features.Entries;

public sealed record EntryResponse(
    Guid Id,
    string? Title,
    string Content,
    string? Mood,
    string? TemplateKey,
    DateTimeOffset CreatedAtUtc,
    DateTimeOffset UpdatedAtUtc,
    bool IsDeleted);
