namespace BuberBreakfast.Contracts.Breakfast

{
    public record BreakfastResponse(
        Guid Id,
        string Name,
        string Description,
        DateTime StartDataTime,
        DateTime EndDataTime,
        DateTime LastModifiedDateTime,
        List<string> Savory,
        List<string> Sweet
    );
}