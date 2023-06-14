namespace BuberBreakfast.Contracts.Breakfast

{
    public record CreateBreakfastRequest(
        string Name,
        string Description,
        DateTime StartDataTime,
        DateTime EndDataTime,
        List<string> Savory,
        List<string> Sweet
    );
}