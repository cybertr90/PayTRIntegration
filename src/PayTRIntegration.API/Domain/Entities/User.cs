using PayTRIntegration.API.Domain.Entities.Common;
using PayTRIntegration.API.Domain.ValueObjects;

namespace PayTRIntegration.API.Domain.Entities;

public sealed class User : EntityBase
{
    public Guid TenantId { get; set; }
    public Tenant Tenant { get; set; } = null!;
    public string? ExternalUserId { get; set; }
    public string Email { get; set; }
    public FullName FullName { get; set; }
    public ICollection<Order> Orders { get; set; } = [];
}