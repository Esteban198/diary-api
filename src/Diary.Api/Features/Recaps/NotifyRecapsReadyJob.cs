namespace Diary.Api.Features.Recaps;

// TODO: sweep users and send recap push notifications via IPushSender once Recaps is implemented.
public sealed class NotifyRecapsReadyJob : BackgroundService
{
    protected override Task ExecuteAsync(CancellationToken stoppingToken) => Task.CompletedTask;
}
