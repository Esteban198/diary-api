using Diary.Api.Features.Entries;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;

namespace Diary.Api.Tests.Features.Entries;

// TODO: replace with real persistence assertions once CreateEntry is implemented.
public class CreateEntryTests
{
    [Fact]
    public void HandleAsync_ReturnsNotImplemented()
    {
        var request = new CreateEntryRequest("Title", "Content", null, null);

        var result = CreateEntry.HandleAsync(request);

        var statusCodeResult = Assert.IsAssignableFrom<IStatusCodeHttpResult>(result);
        Assert.Equal(StatusCodes.Status501NotImplemented, statusCodeResult.StatusCode);
    }
}
