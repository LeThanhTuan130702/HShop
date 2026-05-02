using System;
using Volo.Abp.Domain.Entities;

namespace Acme.BookStore.Products;

public class Tag : Entity<string>
{
    public string Name { get; set; }
}
