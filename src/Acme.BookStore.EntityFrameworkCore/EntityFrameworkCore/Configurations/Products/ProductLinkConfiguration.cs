using Acme.BookStore.Products;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Acme.BookStore.EntityFrameworkCore.Configurations.Products;

public class ProductLinkConfiguration : IEntityTypeConfiguration<ProductLink>
{
    public void Configure(EntityTypeBuilder<ProductLink> builder)
    {
        builder.ToTable(BookStoreConsts.DbTablePrefix + "ProductLinks", BookStoreConsts.DbSchema);
        builder.HasKey(x => new { x.ProductId, x.LinkedProductId });
    }
}
