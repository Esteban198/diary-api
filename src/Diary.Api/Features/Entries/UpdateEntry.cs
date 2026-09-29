namespace Diary.Api.Features.Entries;

public sealed record UpdateEntryRequest(string? Title, string Content, string? Mood, string? TemplateKey);

// TODO: persist via DiaryDbContext once Entries is implemented.
public static class UpdateEntry
{
    public static IResult HandleAsync(Guid id, UpdateEntryRequest request) =>
        TypedResults.StatusCode(StatusCodes.Status501NotImplemented);
}
