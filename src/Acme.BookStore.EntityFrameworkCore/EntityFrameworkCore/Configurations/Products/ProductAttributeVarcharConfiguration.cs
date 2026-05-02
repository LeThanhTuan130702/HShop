using Acme.BookStore.Attributes;
using Acme.BookStore.Products;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Acme.BookStore.EntityFrameworkCore.Configurations.Products;

public class ProductAttributeVarcharConfiguration : IEntityTypeConfiguration<ProductAttributeVarchar>
{
    public void Configure(EntityTypeBuilder<ProductAttributeVarchar> builder)
    {
        builder.ToTable(BookStoreConsts.DbTablePrefix + "ProductAttributeVarchars", BookStoreConsts.DbSchema);
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Value).HasMaxLength(500);
    }
}
