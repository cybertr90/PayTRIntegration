namespace PayTRIntegration.API.Domain.Entities.Common;

public abstract class EntityBase
{
    public Guid Id { get; }
    public DateTimeOffset CreateDate { get; }
    public DateTimeOffset UpdateDate { get; }
}