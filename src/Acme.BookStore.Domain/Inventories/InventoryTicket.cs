using System;
using Volo.Abp.Domain.Entities.Auditing;

namespace Acme.BookStore.Inventories;

public class InventoryTicket : AuditedAggregateRoot<Guid>
{
    public string Code { get; set; }
    public InventoryTicketType TicketType { get; set; }
    public bool IsApproved { get; set; }
    public Guid? ApproverId { get; set; }
    public DateTime? ApprovedDate { get; set; }
}
