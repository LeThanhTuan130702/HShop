using System;
using Volo.Abp.Domain.Entities.Auditing;

namespace Acme.BookStore.Orders;

public class OrderTransaction : CreationAuditedEntity<Guid>
{
    public string Code { get; set; }
    public Guid OrderId { get; set; }
    public string UserId { get; set; }
    public double Amount { get; set; }
    public TransactionStatus Status { get; set; }
    public string Note { get; set; }
}
