using System;
using Volo.Abp.Domain.Entities.Auditing;

namespace Acme.BookStore.Products;

public class ProductTag : CreationAuditedEntity<Guid>
{
    public Guid ProductId { get; set; }
    public Guid TagId { get; set; }
}
