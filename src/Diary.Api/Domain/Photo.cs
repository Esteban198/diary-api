namespace Diary.Api.Domain;

public enum PhotoStatus
{
    PendingUpload,
    Confirmed
}

public sealed class Photo
{
    public Guid Id { get; init; }
    public required Guid EntryId { get; set; }
    public required string StorageKey { get; set; }
    public required string ContentType { get; set; }
    public long SizeBytes { get; set; }
    public PhotoStatus Status { get; set; } = PhotoStatus.PendingUpload;
    public DateTimeOffset CreatedAtUtc { get; init; }

    public Entry? Entry { get; init; }
}
