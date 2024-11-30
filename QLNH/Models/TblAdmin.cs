using System;
using System.Collections.Generic;

namespace QLNH.Models;

public partial class TblAdmin
{
    public int AdminId { get; set; }

    public string? Username { get; set; }

    public string? Email { get; set; }

    public string? Password { get; set; }

    public string? Phone { get; set; }

    public int? RoleId { get; set; }

    public bool IsActive { get; set; }

    public virtual TblRole? Role { get; set; }
}
