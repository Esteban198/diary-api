namespace Diary.Api.Features.Templates;

public static class TemplateEndpoints
{
    public static IEndpointRouteBuilder MapTemplateEndpoints(this IEndpointRouteBuilder app)
    {
        app.MapGet("/templates", GetTemplates.Handle).WithTags("Templates");

        return app;
    }
}
