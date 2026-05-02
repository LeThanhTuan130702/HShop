using System;
using System.Security.Permissions;
using Volo.Abp.Domain.Entities.Auditing;

namespace Acme.BookStore.ProductCategories;

public class ProductCategories : CreationAuditedAggregateRoot<Guid>
{
    public string Name {get; set;}
    public string Code {get; set;}
    public string Slug {get; set;}
    public int SortOrder {get; set;}
    public string CoverPicture {get; set;}
    public bool Visibile {get; set;}
    public bool IsActive {get; set;}
    public Guid? ParentId {get; set;}
    public string SeoMetaDescription {get; set;}
}
