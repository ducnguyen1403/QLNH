using System;
using System.Collections.Generic;

namespace QLNH.Models;

public partial class TblProductCategory
{
    public int ProductCategoryId { get; set; }

    public string? Title { get; set; }

    public string? Description { get; set; }

    public bool IsActive { get; set; }

    public virtual ICollection<TblProduct> TblProducts { get; set; } = new List<TblProduct>();
}
