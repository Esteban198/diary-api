using Diary.Api.Domain;
using Diary.Api.Features.Recaps;

namespace Diary.Api.Tests.Features.Recaps;

public class RecapSelectorTests
{
    [Fact]
    public void SelectForDate_ReturnsEntriesFromSameDayInPastYears()
    {
        var referenceDate = new DateOnly(2026, 9, 18);

        Entry[] entries =
        [
            MakeEntry(new DateTimeOffset(2024, 9, 18, 8, 0, 0, TimeSpan.Zero)),
            MakeEntry(new DateTimeOffset(2024, 9, 19, 8, 0, 0, TimeSpan.Zero)),
            MakeEntry(new DateTimeOffset(2026, 9, 18, 8, 0, 0, TimeSpan.Zero))
        ];

        var result = RecapSelector.SelectForDate(entries, referenceDate);

        Assert.Single(result);
        Assert.Equal(entries[0].Id, result[0].Id);
    }

    [Fact]
    public void SelectForDate_ExcludesDeletedEntries()
    {
        var referenceDate = new DateOnly(2026, 9, 18);
        var entry = MakeEntry(new DateTimeOffset(2024, 9, 18, 8, 0, 0, TimeSpan.Zero));
        entry.DeletedAtUtc = DateTimeOffset.UtcNow;

        var result = RecapSelector.SelectForDate([entry], referenceDate);

        Assert.Empty(result);
    }

    private static Entry MakeEntry(DateTimeOffset createdAtUtc) => new()
    {
        Id = Guid.NewGuid(),
        UserId = Guid.NewGuid(),
        Content = "test",
        CreatedAtUtc = createdAtUtc,
        UpdatedAtUtc = createdAtUtc
    };
}
