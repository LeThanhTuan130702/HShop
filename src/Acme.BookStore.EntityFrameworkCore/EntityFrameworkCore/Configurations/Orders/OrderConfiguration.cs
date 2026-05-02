using Acme.BookStore.Orders;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Acme.BookStore.EntityFrameworkCore.Configurations.Orders;

public class OrderConfiguration : IEntityTypeConfiguration<Order>
{
    public void Configure(EntityTypeBuilder<Order> builder)
    {
        builder.ToTable(BookStoreConsts.DbTablePrefix + "Orders", BookStoreConsts.DbSchema);
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Code).IsUnicode(false).IsRequired().HasMaxLength(50);
        builder.Property(x => x.CustomerName).HasMaxLength(50).IsRequired();
        builder.Property(x => x.CustomerPhoneNumber).IsUnicode(false).IsRequired().HasMaxLength(20);
        builder.Property(x => x.CustomerAddress).HasMaxLength(250).IsRequired();
    }
}
