using Acme.BookStore.Inventories;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace Acme.BookStore.EntityFrameworkCore.Configurations.Inventories;

public class InventoryConfiguration : IEntityTypeConfiguration<Inventory>
{
    public void Configure(EntityTypeBuilder<Inventory> builder)
    {
        builder.ToTable(BookStoreConsts.DbTablePrefix + "Inventories", BookStoreConsts.DbSchema);
        builder.HasKey(x => x.Id);
        builder.Property(x => x.SKU).IsUnicode(false).IsRequired().HasMaxLength(50);
        builder.Property(x => x.StockQuantity).IsRequired();
    }
}
