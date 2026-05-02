using Acme.BookStore.Promotions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Acme.BookStore.EntityFrameworkCore.Configurations.Promotions;

public class PromotionUsageHistoryConfiguration : IEntityTypeConfiguration<PromotionUsageHistory>
{
    public void Configure(EntityTypeBuilder<PromotionUsageHistory> builder)
    {
        builder.ToTable(BookStoreConsts.DbTablePrefix + "PromotionUsageHistories", BookStoreConsts.DbSchema);
        builder.HasKey(x => x.Id);
    }
}
