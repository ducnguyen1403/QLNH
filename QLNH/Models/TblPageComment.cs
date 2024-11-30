using System;
using System.Collections.Generic;

namespace QLNH.Models;

public partial class TblPageComment
{
    public int PageCommentId { get; set; }

    public string? UserName { get; set; }

    public string? Email { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? PageId { get; set; }

    public bool IsActive { get; set; }

    public virtual TblPage? Page { get; set; }
}
