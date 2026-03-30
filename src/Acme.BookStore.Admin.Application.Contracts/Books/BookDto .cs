using Acme.BookStore.Books;
using System;
using Volo.Abp.Application.Dtos;

namespace Acme.BookStore.Admin.Books;

public class BookDto : AuditedEntityDto<Guid>
{
    public required string Name { get; set; }

    public BookType Type { get; set; }

    public DateTime PublishDate { get; set; }

    public float Price { get; set; }
}