using PayTRIntegration.API.Domain.Entities.Common;
using PayTRIntegration.API.Domain.Enums;

namespace PayTRIntegration.API.Domain.Entities;

public sealed class Promotion : EntityBase
{
    public Guid ProductId { get; set; }
    public Product Product { get; set; }
    public string Code { get; set; } // PROG2025 like code
    public string Name { get; set; }
    public string? Description { get; set; }
    public decimal DiscountAmount { get; set; }
    public DateTimeOffset StartDate { get; set; }
    public DateTimeOffset EndDate { get; set; }
    public PromotionType Type { get; set; }
    public bool IsActive { get; set; }
    public int MaxUsageCount { get; set; }
    public int UsageCount { get; set; }
    //Concurrency
    public byte[] RowVersion { get; set; }
}

