namespace Diary.Api.Features.Entries;

// TODO: soft-delete via DiaryDbContext once Entries is implemented.
public static class DeleteEntry
{
    public static IResult HandleAsync(Guid id) =>
        TypedResults.StatusCode(StatusCodes.Status501NotImplemented);
}
