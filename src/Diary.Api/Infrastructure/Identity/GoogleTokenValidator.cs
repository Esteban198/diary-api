namespace Diary.Api.Infrastructure.Identity;

public interface IGoogleTokenValidator
{
    Task<GoogleUserInfo> ValidateAsync(string idToken, CancellationToken cancellationToken);
}

public sealed record GoogleUserInfo(string Subject, string Email, string? Name);

// TODO: validate the ID token against Google (e.g. via Google.Apis.Auth) once Auth is implemented.
public sealed class GoogleTokenValidator : IGoogleTokenValidator
{
    public Task<GoogleUserInfo> ValidateAsync(string idToken, CancellationToken cancellationToken) =>
        throw new NotImplementedException();
}
