using System;
using System.Collections.Generic;

namespace QLNH.Models;

public partial class TblBill
{
    public int BillId { get; set; }

    public string? BillCode { get; set; }

    public string? UserName { get; set; }

    public string? Phone { get; set; }

    public string? Address { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? UserId { get; set; }

    public bool IsActive { get; set; }

    public virtual TblUser? User { get; set; }
}
