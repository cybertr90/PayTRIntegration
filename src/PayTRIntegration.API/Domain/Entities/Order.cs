using PayTRIntegration.API.Domain.Entities.Common;
using PayTRIntegration.API.Domain.Enums;

namespace PayTRIntegration.API.Domain.Entities;

public sealed class Order : EntityBase
{
    public Guid TenantId { get; set; }
    public Tenant Tenant { get; set; } = null!;
    public Guid? UserId { get; set; }
    public User? User { get; set; }
    public string? ProductId { get; set; }
    public Product Product { get; set; } 
    public Guid? PromotionId { get; set; }
    public Promotion? Promotion { get; set; }
    public string MerchantOid { get; set; } = null!;
    public decimal PaymentAmount { get; set; }
    public CurrencyCode Currency { get; set; }
    public OrderStatus Status { get; set; }
    
    public ICollection<Payment> Payments { get; set; } = [];
    public ICollection<OrderHistory> Histories { get; set; } = [];
}
