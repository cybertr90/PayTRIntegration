using PayTRIntegration.API.Domain.Entities.Common;

namespace PayTRIntegration.API.Domain.Entities;

public sealed class Payment : EntityBase
{
     public Guid OrderId { get; set; }
     public string PayTrStatus { get; set; } = null!;
     public int? TotalAmount { get; set; }
     public string? FailedReasonCode { get; set; }
     public string? FailedReasonMsg { get; set; }
     public string Hash { get; set; } = null!;
     public string? PaymentType { get; set; }
     public bool TestMode { get; set; } = false;
     //public DateTime NotifyDate { get; set; }
     
     public Order Order { get; set; } = null!;
}