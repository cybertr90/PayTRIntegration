using PayTRIntegration.API.Domain.Entities.Common;
using PayTRIntegration.API.Domain.Enums;

namespace PayTRIntegration.API.Domain.Entities;

public sealed class OrderHistory : EntityBase
{
    public Guid OrderId { get; set; }
    public Order Order { get; set; }
    public OrderStatus Status { get; set; }
    public string? Description { get; set; }

}