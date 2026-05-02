using Acme.BookStore.Inventories;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Acme.BookStore.EntityFrameworkCore.Configurations.Inventories;

public class InventoryTicketDetailConfiguration : IEntityTypeConfiguration<InventoryTicketDetail>
{
    public void Configure(EntityTypeBuilder<InventoryTicketDetail> builder)
    {
        builder.ToTable(BookStoreConsts.DbTablePrefix + "InventoryTicketDetails", BookStoreConsts.DbSchema);
        builder.HasKey(x => x.Id);
        builder.Property(x => x.SKU).IsUnicode(false).HasMaxLength(50).IsRequired();
        builder.Property(x => x.BatchNumber).IsUnicode(false).HasMaxLength(50);
    }
}
