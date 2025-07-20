using FastTechFoods.Contracts.Enum;

namespace FastTechFoods.Contracts;
public record CancellationReasonEvent
(
    Guid Id,
    EnumStatus Status,
    string CancellationReason
    );