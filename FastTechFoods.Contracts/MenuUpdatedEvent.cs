namespace FastTechFoods.Contracts
{
    public record MenuUpdatedEvent(
    Guid Id,
    string Name,
    string Description,
    decimal Price,
    string Category,
    bool IsAvailable,
    DateTime? UpdatedAt
    );
}
