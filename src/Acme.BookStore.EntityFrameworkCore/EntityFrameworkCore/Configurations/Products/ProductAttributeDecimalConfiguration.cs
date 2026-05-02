using Acme.BookStore.Products;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Acme.BookStore.EntityFrameworkCore.Configurations.Products;

public class ProductAttributeDecimalConfiguration : IEntityTypeConfiguration<ProductAttributeDecimal>
{
    public void Configure(EntityTypeBuilder<ProductAttributeDecimal> builder)
    {
        builder.ToTable(BookStoreConsts.DbTablePrefix + "ProductAttributeDecimals", BookStoreConsts.DbSchema);
        builder.HasKey(x => x.Id);
    }
}
