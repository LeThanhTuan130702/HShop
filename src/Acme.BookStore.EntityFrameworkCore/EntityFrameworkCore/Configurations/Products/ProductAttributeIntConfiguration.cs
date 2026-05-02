using Acme.BookStore.Products;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Acme.BookStore.EntityFrameworkCore.Configurations.Products;

public class ProductAttributeIntConfiguration : IEntityTypeConfiguration<ProductAttributeInt>
{
    public void Configure(EntityTypeBuilder<ProductAttributeInt> builder)
    {
        builder.ToTable(BookStoreConsts.DbTablePrefix + "ProductAttributeInts", BookStoreConsts.DbSchema);
        builder.HasKey(x => x.Id);
    }
}
