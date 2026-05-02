using Acme.BookStore.Promotions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Acme.BookStore.EntityFrameworkCore.Configurations.Promotions;

public class PromotionProductConfiguration : IEntityTypeConfiguration<PromotionProduct>
{
    public void Configure(EntityTypeBuilder<PromotionProduct> builder)
    {
        builder.ToTable(BookStoreConsts.DbTablePrefix + "PromotionProducts", BookStoreConsts.DbSchema);
        builder.HasKey(x => x.Id);
    }
}
