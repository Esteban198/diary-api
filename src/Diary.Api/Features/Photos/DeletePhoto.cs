namespace Diary.Api.Features.Photos;

// TODO: remove the photo via DiaryDbContext and IObjectStorage once Photos is implemented.
public static class DeletePhoto
{
    public static IResult HandleAsync(Guid id) =>
        TypedResults.StatusCode(StatusCodes.Status501NotImplemented);
}
