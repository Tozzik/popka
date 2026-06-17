using System;
using System.Collections.Generic;

namespace popka.Models;

public partial class Order
{
    public int Id { get; set; }

    public string OrderArticle { get; set; } = null!;

    public DateOnly OrderDate { get; set; }

    public DateOnly OrderDelivery { get; set; }

    public int? Address { get; set; }

    public string? FullName { get; set; }

    public int Code { get; set; }

    public string? Status { get; set; }

    public virtual PickupPoint? AddressNavigation { get; set; }
}
