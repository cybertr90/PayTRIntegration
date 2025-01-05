using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PayTRIntegration.API.Domain.Entities;
using PayTRIntegration.API.Domain.Enums;

namespace PayTRIntegration.API.Persistence.EntityFramework.Configurations;

public class OrderHistoryConfiguration : IEntityTypeConfiguration<OrderHistory>
{
    public void Configure(EntityTypeBuilder<OrderHistory> builder)
    {
        
        //ID Primary Key
        builder.HasKey(x => x.Id);

        //OrderStatus Enum
        builder.Property(x => x.Status)
            .HasConversion<int>()
            .IsRequired()
            .HasDefaultValue(OrderStatus.Pending)
            .HasColumnType("tinyint");
        
        //Description
        builder.Property(x => x.Description)
            .HasMaxLength(2500)
            .IsRequired(false);
        
        //Common Properties
        builder.Property(x => x.CreateDate)
            .IsRequired()
            .HasDefaultValue(DateTimeOffset.UtcNow);

        builder.Property(x => x.UpdateDate)
            .IsRequired(false);
        
        
        builder.ToTable("OrderHistory");

    }
}