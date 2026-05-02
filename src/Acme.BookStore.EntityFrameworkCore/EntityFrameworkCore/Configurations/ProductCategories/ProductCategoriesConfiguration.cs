using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Acme.BookStore.EntityFrameworkCore.Configurations.ProductCategories;

public class ProductCategoriesConfiguration : IEntityTypeConfiguration<BookStore.ProductCategories.ProductCategories>
{
    public void Configure(EntityTypeBuilder<BookStore.ProductCategories.ProductCategories> builder)
    {
        builder.ToTable(BookStoreConsts.DbTablePrefix + "ProductCategories", BookStoreConsts.DbSchema);
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Name).IsRequired().HasMaxLength(50);
        builder.Property(x => x.Code).IsUnicode(false).IsRequired().HasMaxLength(50);
        builder.Property(x => x.Slug).IsUnicode(false).IsRequired().HasMaxLength(50);
        builder.Property(x => x.CoverPicture).HasMaxLength(250);
        builder.Property(x => x.SeoMetaDescription).HasMaxLength(250);
    }
}
