using Diary.Api.Infrastructure.Identity;
using Diary.Api.Infrastructure.Persistence;
using Diary.Api.Infrastructure.Push;
using Diary.Api.Infrastructure.Storage;
using Microsoft.EntityFrameworkCore;

namespace Diary.Api.Common;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddDiaryPersistence(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<DiaryDbContext>(options =>
            options.UseNpgsql(configuration.GetConnectionString("Postgres")));

        return services;
    }

    public static IServiceCollection AddDiaryIdentity(this IServiceCollection services)
    {
        services.AddHttpContextAccessor();
        services.AddScoped<ICurrentUser, CurrentUser>();
        services.AddSingleton<IGoogleTokenValidator, GoogleTokenValidator>();
        services.AddSingleton<IJwtIssuer, JwtIssuer>();

        return services;
    }

    public static IServiceCollection AddDiaryObjectStorage(this IServiceCollection services)
    {
        services.AddSingleton<IObjectStorage, R2ObjectStorage>();
        return services;
    }

    public static IServiceCollection AddDiaryPush(this IServiceCollection services)
    {
        services.AddSingleton<IPushSender, FcmPushSender>();
        return services;
    }
}
