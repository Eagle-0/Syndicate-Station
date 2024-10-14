namespace Content.Shared.Medical.Surgery.Conditions;

/// <summary>
///     Raised on the entity that is receiving surgery.
/// </summary>
[ByRefEvent]
public record struct SurgeryValidEvent(EntityUid Body, EntityUid Part, bool Cancelled = false);