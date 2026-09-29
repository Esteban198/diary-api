namespace Diary.Api.Features.Entries;

// TODO: query DiaryDbContext for entries updated since the given timestamp once Entries is implemented.
public static class SyncEntries
{
    public static IResult HandleAsync(DateTimeOffset? since) =>
        TypedResults.StatusCode(StatusCodes.Status501NotImplemented);
}
