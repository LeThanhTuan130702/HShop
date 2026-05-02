using System;
using Volo.Abp.Domain.Entities.Auditing;

namespace Acme.BookStore.Products;

public class Review : CreationAuditedAggregateRoot<Guid>
{
    public Guid ProductId { get; set; }
    public Guid ParentId { get; set; }
    public int Rating { get; set; }
    public string Title { get; set; }
    public double RatingValue { get; set; }
    public DateTime PublishDate { get; set; }
    public string Content { get; set; }
    public Guid OrderId { get; set; }
}