using Acme.BookStore.Promotions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Acme.BookStore.EntityFrameworkCore.Configurations.Promotions;

public class PromotionCategoryConfiguration : IEntityTypeConfiguration<PromotionCategory>
{
    public void Configure(EntityTypeBuilder<PromotionCategory> builder)
    {
        builder.ToTable(BookStoreConsts.DbTablePrefix + "PromotionCategories", BookStoreConsts.DbSchema);
        builder.HasKey(x => x.Id);
    }
}
