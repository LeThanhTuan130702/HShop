using Acme.BookStore.Promotions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Acme.BookStore.EntityFrameworkCore.Configurations.Promotions;

public class PromotionManufacturerConfiguration : IEntityTypeConfiguration<PromotionManufacturer>
{
    public void Configure(EntityTypeBuilder<PromotionManufacturer> builder)
    {
        builder.ToTable(BookStoreConsts.DbTablePrefix + "PromotionManufacturers", BookStoreConsts.DbSchema);
        builder.HasKey(x => x.Id);
    }
}
