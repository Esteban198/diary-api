namespace Diary.Api.Infrastructure.Storage;

public interface IObjectStorage
{
    Task<PresignedUpload> CreateUploadUrlAsync(string key, string contentType, CancellationToken cancellationToken);

    Task DeleteAsync(string key, CancellationToken cancellationToken);

    string GetPublicUrl(string key);
}

public sealed record PresignedUpload(string UploadUrl, string Key, DateTimeOffset ExpiresAtUtc);
