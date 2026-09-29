using Diary.Api.Common;
using Diary.Api.Features.Auth;
using Diary.Api.Features.Entries;
using Diary.Api.Features.Photos;
using Diary.Api.Features.Recaps;
using Diary.Api.Features.Templates;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddOpenApi();
builder.Services.AddDiaryProblemDetails();
builder.Services.AddDiaryPersistence(builder.Configuration);
builder.Services.AddDiaryIdentity();
builder.Services.AddDiaryObjectStorage();
builder.Services.AddDiaryPush();
builder.Services.AddSingleton(TimeProvider.System);
builder.Services.AddHostedService<NotifyRecapsReadyJob>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseExceptionHandler();

app.MapAuthEndpoints();
app.MapEntryEndpoints();
app.MapPhotoEndpoints();
app.MapRecapEndpoints();
app.MapTemplateEndpoints();

app.MapGet("/health", () => Results.Ok(new { status = "healthy" })).WithTags("Health");

app.Run();

public partial class Program;
