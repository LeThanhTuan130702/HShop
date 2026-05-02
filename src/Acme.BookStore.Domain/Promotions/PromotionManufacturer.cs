using System;
using Volo.Abp.Domain.Entities;

namespace Acme.BookStore.Promotions;

public class PromotionManufacturer : Entity<Guid>
{
    public Guid ManufacturerId { get; set; }
    public Guid PromotionId { get; set; }

}
