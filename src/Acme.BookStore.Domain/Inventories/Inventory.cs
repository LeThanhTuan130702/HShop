using System;
using Volo.Abp.Domain.Entities.Auditing;

namespace Acme.BookStore.Inventories;

public class Inventory : AuditedAggregateRoot<Guid>
{
    public Guid ProductId { get; set; }
    public string SKU { get; set; }
    public int StockQuantity { get; set; }
}
