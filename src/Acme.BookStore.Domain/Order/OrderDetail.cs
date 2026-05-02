using System;
using Volo.Abp.Domain.Entities;
using Volo.Abp.Domain.Entities.Auditing;

namespace Acme.BookStore.Orders;

public class OrderDetail : Entity
{
    public Guid OrderId { get; set; }
    public Guid ProductId { get; set; }
    public string SKU { get; set; }
    public int Quantity { get; set; }
    public double Price { get; set; }

    public override object[] GetKeys()
    {
        return new object[] { OrderId, ProductId };
    }
}
