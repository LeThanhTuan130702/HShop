using Acme.BookStore.Inventories;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Acme.BookStore.EntityFrameworkCore.Configurations.Inventories;

public class InventoryTicketConfiguration : IEntityTypeConfiguration<InventoryTicket>
{
    public void Configure(EntityTypeBuilder<InventoryTicket> builder)
    {
        builder.ToTable(BookStoreConsts.DbTablePrefix + "InventoryTickets", BookStoreConsts.DbSchema);
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Code).IsUnicode(false).IsRequired().HasMaxLength(50);
    }
}
