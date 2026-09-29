namespace Diary.Api.Features.Recaps;

// TODO: query DiaryDbContext and apply RecapSelector once Recaps is implemented.
public static class GetRecapManifest
{
    public static IResult HandleAsync() =>
        TypedResults.StatusCode(StatusCodes.Status501NotImplemented);
}
