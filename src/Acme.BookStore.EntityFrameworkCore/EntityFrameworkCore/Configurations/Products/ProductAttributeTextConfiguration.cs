using Acme.BookStore.Attributes;
using Acme.BookStore.Products;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Acme.BookStore.EntityFrameworkCore.Configurations.Products;

public class ProductAttributeTextConfiguration : IEntityTypeConfiguration<ProductAttributeText>
{
    public void Configure(EntityTypeBuilder<ProductAttributeText> builder)
    {
        builder.ToTable(BookStoreConsts.DbTablePrefix + "ProductAttributeTexts", BookStoreConsts.DbSchema);
        builder.HasKey(x => x.Id);
    }
}
