namespace Diary.Api.Features.Auth;

public static class AuthEndpoints
{
    public static IEndpointRouteBuilder MapAuthEndpoints(this IEndpointRouteBuilder app)
    {
        var group = app.MapGroup("/auth").WithTags("Auth");

        group.MapPost("/google", SignInWithGoogle.HandleAsync);
        group.MapPost("/refresh", RefreshSession.HandleAsync);

        return app;
    }
}
