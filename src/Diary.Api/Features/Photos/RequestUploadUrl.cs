namespace Diary.Api.Features.Photos;

public sealed record RequestUploadUrlRequest(Guid EntryId, string ContentType);

// TODO: create the photo row and a presigned upload URL via IObjectStorage once Photos is implemented.
public static class RequestUploadUrl
{
    public static IResult HandleAsync(RequestUploadUrlRequest request) =>
        TypedResults.StatusCode(StatusCodes.Status501NotImplemented);
}
