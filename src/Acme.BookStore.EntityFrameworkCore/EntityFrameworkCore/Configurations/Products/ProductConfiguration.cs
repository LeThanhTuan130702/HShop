using Acme.BookStore.Products;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Acme.BookStore.EntityFrameworkCore.Configurations.Products;

public class ProductConfiguration : IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {
        builder.ToTable(BookStoreConsts.DbTablePrefix + "Products", BookStoreConsts.DbSchema);
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Name).IsRequired().HasMaxLength(50);
        builder.Property(x => x.Code).IsUnicode(false).IsRequired().HasMaxLength(50);
        builder.Property(x => x.Sku).IsUnicode(false).IsRequired().HasMaxLength(50);
        builder.Property(x => x.Slug).IsUnicode(false).IsRequired().HasMaxLength(50);
        builder.Property(x => x.Thumbnail).HasMaxLength(250);
        builder.Property(x => x.SeoMetaDescription).HasMaxLength(250);
    }
}
