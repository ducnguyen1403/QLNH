using System;
using System.Collections.Generic;

namespace QLNH.Models;

public partial class TblProductReview
{
    public int ProductReviewId { get; set; }

    public string? Title { get; set; }

    public string? Email { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? Detail { get; set; }

    public int? Star { get; set; }

    public int? ProductId { get; set; }

    public bool IsActive { get; set; }

    public virtual TblProduct? Product { get; set; }
}
