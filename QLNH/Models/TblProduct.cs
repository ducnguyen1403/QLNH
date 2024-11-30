using System;
using System.Collections.Generic;

namespace QLNH.Models;

public partial class TblProduct
{
    public int ProductId { get; set; }

    public string? ProductName { get; set; }

    public int? ProductCategoryId { get; set; }

    public string? Description { get; set; }

    public int? Price { get; set; }

    public int? PriceSale { get; set; }

    public int? Quantity { get; set; }

    public bool IsActive { get; set; }

    public virtual TblProductCategory? ProductCategory { get; set; }

    public virtual ICollection<TblProductReview> TblProductReviews { get; set; } = new List<TblProductReview>();
}
