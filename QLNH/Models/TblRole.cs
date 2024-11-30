using System;
using System.Collections.Generic;

namespace QLNH.Models;

public partial class TblRole
{
    public int RoleId { get; set; }

    public string? RoleName { get; set; }

    public virtual ICollection<TblAdmin> TblAdmins { get; set; } = new List<TblAdmin>();
}
