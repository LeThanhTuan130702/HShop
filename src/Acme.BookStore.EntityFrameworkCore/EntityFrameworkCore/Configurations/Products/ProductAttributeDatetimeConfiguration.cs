using Acme.BookStore.Products;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace Acme.BookStore.EntityFrameworkCore.Configurations.Products;

public class ProductAttributeDatetimeConfiguration : IEntityTypeConfiguration<ProductAttributeDatetime>
{
    public void Configure(EntityTypeBuilder<ProductAttributeDatetime> builder)
    {
        builder.ToTable(BookStoreConsts.DbTablePrefix + "ProductAttributeDatetimes", BookStoreConsts.DbSchema);
        builder.HasKey(x => x.Id);
    }
}
