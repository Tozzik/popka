using System;
using System.Collections.Generic;

namespace popka.Models;

public partial class PickupPoint
{
    public int Id { get; set; }

    public string Adress { get; set; } = null!;

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}
