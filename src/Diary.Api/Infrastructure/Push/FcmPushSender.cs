namespace Diary.Api.Infrastructure.Push;

// TODO: send via Firebase Cloud Messaging (e.g. the FirebaseAdmin SDK) once Recaps notifications are implemented.
public sealed class FcmPushSender : IPushSender
{
    public Task SendAsync(
        string deviceToken,
        string title,
        string body,
        IReadOnlyDictionary<string, string>? data,
        CancellationToken cancellationToken) =>
        throw new NotImplementedException();
}
