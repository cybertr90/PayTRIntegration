using PayTRIntegration.API.Domain.Entities.Common;

namespace PayTRIntegration.API.Domain.Entities;

public sealed class Order : EntityBase
{
    public Guid TenantId { get; set; }
    public Guid? UserId { get; set; }
    public string MerchantOid { get; set; } = null!;
    public string? ProductId { get; set; }
    public string? ProductName { get; set; }
    public int PaymentAmount { get; set; }
    public string Currency { get; set; } = "TRY";
    public string Status { get; set; } = "pending";
    
    public Tenant Tenant { get; set; } = null!;
    public User? User { get; set; }
    public ICollection<Payment> Payments { get; set; } = [];
}