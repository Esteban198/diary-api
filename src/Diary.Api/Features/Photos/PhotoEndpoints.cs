namespace Diary.Api.Features.Photos;

public static class PhotoEndpoints
{
    public static IEndpointRouteBuilder MapPhotoEndpoints(this IEndpointRouteBuilder app)
    {
        var group = app.MapGroup("/photos").WithTags("Photos");

        group.MapPost("/upload-url", RequestUploadUrl.HandleAsync);
        group.MapPost("/{id:guid}/confirm", ConfirmUpload.HandleAsync);
        group.MapDelete("/{id:guid}", DeletePhoto.HandleAsync);

        return app;
    }
}
