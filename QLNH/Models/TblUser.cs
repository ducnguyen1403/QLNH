using System;
using System.Collections.Generic;

namespace QLNH.Models;

public partial class TblUser
{
    public int UserId { get; set; }

    public string? UserName { get; set; }

    public string? Phone { get; set; }

    public string? Email { get; set; }

    public string? Address { get; set; }

    public DateTime? LastLogin { get; set; }

    public bool? IsActive { get; set; }

    public virtual ICollection<TblBill> TblBills { get; set; } = new List<TblBill>();
}
