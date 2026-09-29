namespace Diary.Api.Features.Photos;

public sealed record ConfirmUploadRequest(long SizeBytes);

// TODO: mark the photo confirmed via DiaryDbContext once Photos is implemented.
public static class ConfirmUpload
{
    public static IResult HandleAsync(Guid id, ConfirmUploadRequest request) =>
        TypedResults.StatusCode(StatusCodes.Status501NotImplemented);
}
