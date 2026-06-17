using System;
using System.Collections.Generic;

namespace popka.Models;

public partial class Product
{
    public string Article { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string? Unit { get; set; }

    public decimal? Price { get; set; }

    public string? Supplier { get; set; }

    public string Manufacturer { get; set; } = null!;

    public string? Category { get; set; }

    public int? Discount { get; set; }

    public int? Quantity { get; set; }

    public string Description { get; set; } = null!;

    public string? Photo { get; set; }
}
