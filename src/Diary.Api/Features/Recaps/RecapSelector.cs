using Diary.Api.Domain;

namespace Diary.Api.Features.Recaps;

public static class RecapSelector
{
    public static IReadOnlyList<Entry> SelectForDate(IEnumerable<Entry> entries, DateOnly referenceDate, int lookBackYears = 5)
    {
        return entries
            .Where(e => e.DeletedAtUtc is null)
            .Where(e =>
            {
                var entryDate = DateOnly.FromDateTime(e.CreatedAtUtc.UtcDateTime);
                var yearsAgo = referenceDate.Year - entryDate.Year;

                return yearsAgo > 0
                    && yearsAgo <= lookBackYears
                    && entryDate.Month == referenceDate.Month
                    && entryDate.Day == referenceDate.Day;
            })
            .OrderByDescending(e => e.CreatedAtUtc)
            .ToList();
    }
}
