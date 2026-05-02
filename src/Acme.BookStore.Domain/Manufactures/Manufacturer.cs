using System;
using Volo.Abp.Domain.Entities.Auditing;

namespace Acme.BookStore.Manufactures;

public class Manufacturer : AuditedAggregateRoot<Guid>
{
    public string Name { get; set; }
    public string Code { get; set; }
    public string Slug { get; set; }
    public string CoverPicture { get; set; }
    public bool Visible { get; set; }
    public bool IsActive { get; set; }
    public string Country { get; set; }
}
