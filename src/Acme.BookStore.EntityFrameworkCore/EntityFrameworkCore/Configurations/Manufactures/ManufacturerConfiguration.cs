using Acme.BookStore.Manufactures;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Acme.BookStore.EntityFrameworkCore.Configurations.Manufactures;

public class ManufacturerConfiguration : IEntityTypeConfiguration<Manufacturer>
{
    public void Configure(EntityTypeBuilder<Manufacturer> builder)
    {
        builder.ToTable(BookStoreConsts.DbTablePrefix + "Manufacturers", BookStoreConsts.DbSchema);
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Name).IsRequired().HasMaxLength(250);
        builder.Property(x => x.Code).IsUnicode(false).IsRequired().HasMaxLength(50);
        builder.Property(x => x.Slug).IsUnicode(false).IsRequired().HasMaxLength(50);
        builder.Property(x => x.CoverPicture).HasMaxLength(250);
    }
}
