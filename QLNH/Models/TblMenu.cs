using System;
using System.Collections.Generic;

namespace QLNH.Models;

public partial class TblMenu
{
    public int MenuId { get; set; }

    public string? Title { get; set; }

    public string? ControllerName { get; set; }

    public int? Levels { get; set; }

    public int? ParentId { get; set; }

    public bool IsActive { get; set; }

    public int? MenuOrder { get; set; }

    public int? Position { get; set; }
}
