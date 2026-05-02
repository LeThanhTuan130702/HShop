using Acme.BookStore.Products;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Acme.BookStore.EntityFrameworkCore.Configurations.Products;

public class ProductTagConfiguration : IEntityTypeConfiguration<ProductTag>
{
    public void Configure(EntityTypeBuilder<ProductTag> builder)
    {
        builder.ToTable(BookStoreConsts.DbTablePrefix + "ProductTags", BookStoreConsts.DbSchema);
        builder.HasKey(x => new { x.ProductId, x.TagId });
    }
}
