using FastTechFoods.Contracts.Enum;

namespace FastTechFoods.Contracts;
public record OrderItemEvent(Guid Id, Guid MenuItemId, int Quantity, decimal UnitPrice);

public record OrderCreatedEvent
    (
        Guid Id,
        string CustomerId,
        DateTime CreatedAt,
        EnumStatus Status,
        EnumDeliveryMethod DeliveryMethod,
        List<OrderItemEvent> Items
    );