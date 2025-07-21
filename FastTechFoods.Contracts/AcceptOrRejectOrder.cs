using FastTechFoods.Contracts.Enum;

namespace FastTechFoods.Contracts;
public record AcceptOrRejectOrder
(
    Guid Id,
    EnumStatus Status,
    string? CancellationReason
);
