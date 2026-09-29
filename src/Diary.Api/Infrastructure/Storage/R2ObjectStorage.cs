namespace Diary.Api.Infrastructure.Storage;

// TODO: implement against Cloudflare R2 (S3-compatible, e.g. via AWSSDK.S3) once Photos is implemented.
public sealed class R2ObjectStorage : IObjectStorage
{
    public Task<PresignedUpload> CreateUploadUrlAsync(string key, string contentType, CancellationToken cancellationToken) =>
        throw new NotImplementedException();

    public Task DeleteAsync(string key, CancellationToken cancellationToken) =>
        throw new NotImplementedException();

    public string GetPublicUrl(string key) => throw new NotImplementedException();
}
