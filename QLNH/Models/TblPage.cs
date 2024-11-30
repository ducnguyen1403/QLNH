using System;
using System.Collections.Generic;

namespace QLNH.Models;

public partial class TblPage
{
    public int PageId { get; set; }

    public string? Title { get; set; }

    public string? Description { get; set; }

    public string? Image { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public virtual ICollection<TblPageComment> TblPageComments { get; set; } = new List<TblPageComment>();
}
