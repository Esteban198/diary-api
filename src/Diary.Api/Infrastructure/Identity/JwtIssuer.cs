namespace Diary.Api.Infrastructure.Identity;

public interface IJwtIssuer
{
    string IssueAccessToken(Guid userId, string email);

    (string Token, string Hash) IssueRefreshToken();

    string HashRefreshToken(string token);
}

// TODO: issue real signed JWTs (e.g. via System.IdentityModel.Tokens.Jwt) once Auth is implemented.
public sealed class JwtIssuer : IJwtIssuer
{
    public string IssueAccessToken(Guid userId, string email) => throw new NotImplementedException();

    public (string Token, string Hash) IssueRefreshToken() => throw new NotImplementedException();

    public string HashRefreshToken(string token) => throw new NotImplementedException();
}
