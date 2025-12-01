using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Test_1_12.Models;

public partial class Product
{
    [RegularExpression(@"^[A-Z]{2}[0-9]{4}$", ErrorMessage = "Mã hàng phải có dạng XX0000")]
    public string Id { get; set; } = null!;

    public string Name { get; set; } = null!;

    public double UnitPrice { get; set; }

    public string? Image { get; set; }

    public bool Available { get; set; }

    public int CategoryId { get; set; }

    public string? Description { get; set; }

    public virtual Category Category { get; set; } = null!;

    public virtual ICollection<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();
}
