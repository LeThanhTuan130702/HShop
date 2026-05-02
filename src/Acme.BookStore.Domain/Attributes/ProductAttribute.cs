using System;
using Volo.Abp.Domain.Entities.Auditing;

namespace Acme.BookStore.Attributes;

public class Attribute : CreationAuditedAggregateRoot<Guid>
{
    public string Code { get; set; }
    public string Label { get; set; }
    public int SortOrder { get; set; }
    public bool Visible { get; set; }
    public bool IsActive { get; set; }
    public bool IsRequired { get; set; }
    public bool IsUnique { get; set; }
    public string Note { get; set; }
    public AttributeType Type { get; set; }
}
