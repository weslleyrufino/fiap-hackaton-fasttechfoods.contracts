namespace FastTechFoods.Contracts;
public record CancellationReasonEvent
(
    Guid Id,
    string CancellationReason
    );