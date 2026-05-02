using System;
using Volo.Abp.Domain.Entities;

namespace Acme.BookStore.Products;

public class ProductAttributeDatetime : Entity<Guid>
{
    public Guid AttributeId { get; set; }
    public Guid ProductId { get; set; }
    public DateTime Value { get; set; }
}
