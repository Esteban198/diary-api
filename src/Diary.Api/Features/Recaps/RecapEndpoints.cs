namespace Diary.Api.Features.Recaps;

public static class RecapEndpoints
{
    public static IEndpointRouteBuilder MapRecapEndpoints(this IEndpointRouteBuilder app)
    {
        app.MapGet("/recaps/manifest", GetRecapManifest.HandleAsync).WithTags("Recaps");

        return app;
    }
}
