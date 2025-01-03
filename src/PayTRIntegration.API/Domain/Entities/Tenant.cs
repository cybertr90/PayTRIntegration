using PayTRIntegration.API.Domain.Entities.Common;

namespace PayTRIntegration.API.Domain.Entities;

public sealed class Tenant: EntityBase
{
    public string Name { get; set; } = null!;
    public string Domain { get; set; } = null!;

    public ICollection<User> Users { get; set; } = [];
    public ICollection<Order> Orders { get; set; } = [];

}