using Acme.BookStore.Orders;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Acme.BookStore.EntityFrameworkCore.Configurations.Orders;

public class OrderDetailConfiguration : IEntityTypeConfiguration<OrderDetail>
{
    public void Configure(EntityTypeBuilder<OrderDetail> builder)
    {
        builder.ToTable(BookStoreConsts.DbTablePrefix + "OrderDetails", BookStoreConsts.DbSchema);
        builder.HasKey(x => new { x.OrderId, x.ProductId });
        builder.Property(x => x.SKU).IsRequired().IsUnicode(false).HasMaxLength(50);
    }
}
