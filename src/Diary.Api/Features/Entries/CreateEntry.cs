namespace Diary.Api.Features.Entries;

public sealed record CreateEntryRequest(string? Title, string Content, string? Mood, string? TemplateKey);

// TODO: persist via DiaryDbContext once Entries is implemented.
public static class CreateEntry
{
    public static IResult HandleAsync(CreateEntryRequest request) =>
        TypedResults.StatusCode(StatusCodes.Status501NotImplemented);
}
