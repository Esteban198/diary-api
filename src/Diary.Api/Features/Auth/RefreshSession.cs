namespace Diary.Api.Features.Auth;

public sealed record RefreshSessionRequest(string RefreshToken);

// TODO: validate and rotate the refresh token once Identity infrastructure is implemented.
public static class RefreshSession
{
    public static IResult HandleAsync(RefreshSessionRequest request) =>
        TypedResults.StatusCode(StatusCodes.Status501NotImplemented);
}
