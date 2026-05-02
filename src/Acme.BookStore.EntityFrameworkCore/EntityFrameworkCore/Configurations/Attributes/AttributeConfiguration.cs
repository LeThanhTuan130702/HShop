using Acme.BookStore.Attributes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Volo.Abp.EntityFrameworkCore.Modeling;
using Attribute = Acme.BookStore.Attributes.Attribute;

namespace Acme.BookStore.EntityFrameworkCore.Configurations.Attributes;

public class AttributeConfiguration : IEntityTypeConfiguration<Attribute>
{
    public void Configure(EntityTypeBuilder<Attribute> builder)
    {
        builder.ToTable(BookStoreConsts.DbTablePrefix + "Attributes", BookStoreConsts.DbSchema);
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Code)
        .IsUnicode(false)
        .IsRequired()
        .HasMaxLength(50);


        builder.Property(x => x.Label)
        .IsRequired()
        .HasMaxLength(50);
    }
}
