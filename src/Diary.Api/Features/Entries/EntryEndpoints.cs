namespace Diary.Api.Features.Entries;

public static class EntryEndpoints
{
    public static IEndpointRouteBuilder MapEntryEndpoints(this IEndpointRouteBuilder app)
    {
        var group = app.MapGroup("/entries").WithTags("Entries");

        group.MapGet("/", SyncEntries.HandleAsync);
        group.MapPost("/", CreateEntry.HandleAsync);
        group.MapPut("/{id:guid}", UpdateEntry.HandleAsync);
        group.MapDelete("/{id:guid}", DeleteEntry.HandleAsync);

        return app;
    }
}
