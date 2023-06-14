namespace BuberBreakfast.Contracts.Breakfast

{
    public record UpsertBreakfastRequest(
        string Name,
        string Description,
        DateTime StartDataTime,
        DateTime EndDataTime,
        List<string> Savory,
        List<string> Sweet
    );
}