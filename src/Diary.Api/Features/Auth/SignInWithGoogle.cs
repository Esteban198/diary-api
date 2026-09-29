namespace Diary.Api.Features.Auth;

public sealed record SignInWithGoogleRequest(string IdToken);

// TODO: validate the Google ID token and issue tokens once Identity infrastructure is implemented.
public static class SignInWithGoogle
{
    public static IResult HandleAsync(SignInWithGoogleRequest request) =>
        TypedResults.StatusCode(StatusCodes.Status501NotImplemented);
}
