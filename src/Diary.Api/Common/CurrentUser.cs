namespace Diary.Api.Common;

public interface ICurrentUser
{
    Guid Id { get; }
    string Email { get; }
}

// TODO: populate from the authenticated request once Auth is implemented.
public sealed class CurrentUser(IHttpContextAccessor httpContextAccessor) : ICurrentUser
{
    public Guid Id
    {
        get
        {
            var value = httpContextAccessor.HttpContext?.User.FindFirst("sub")?.Value
                ?? throw new InvalidOperationException("No authenticated user in the current request context.");
            return Guid.Parse(value);
        }
    }

    public string Email =>
        httpContextAccessor.HttpContext?.User.FindFirst("email")?.Value
        ?? throw new InvalidOperationException("No authenticated user in the current request context.");
}
