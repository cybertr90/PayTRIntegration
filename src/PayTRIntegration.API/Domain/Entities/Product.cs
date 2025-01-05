using PayTRIntegration.API.Domain.Entities.Common;

namespace PayTRIntegration.API.Domain.Entities;

public sealed class Product : EntityBase
{
    public string Name { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
    public int Stock { get; set; }
    public bool IsActive { get; set; }

    public ICollection<Promotion> Promotions { get; set; } = [];
}