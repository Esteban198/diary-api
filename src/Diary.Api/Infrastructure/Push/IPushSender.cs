namespace Diary.Api.Infrastructure.Push;

public interface IPushSender
{
    Task SendAsync(
        string deviceToken,
        string title,
        string body,
        IReadOnlyDictionary<string, string>? data,
        CancellationToken cancellationToken);
}
