namespace Diary.Api.Features.Templates;

public sealed record TemplateResponse(string Key, string Title, string Prompt);

public static class GetTemplates
{
    private static readonly IReadOnlyList<TemplateResponse> Templates =
    [
        new("gratitude", "Gratitude", "What are three things you're grateful for today?"),
        new("reflection", "Daily Reflection", "What went well today, and what would you do differently?"),
        new("free-write", "Free Write", "Write freely about whatever is on your mind."),
        new("highlight", "Today's Highlight", "What was the best part of your day?")
    ];

    public static IResult Handle() => TypedResults.Ok(Templates);
}
