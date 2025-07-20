namespace FastTechFoods.Contracts
{
    public record MenuCreatedEvent(
    Guid Id,
    string Name,
    string Description,
    decimal Price,
    string Category,
    bool IsAvailable,
    DateTime? CreatedAt
    );
}
