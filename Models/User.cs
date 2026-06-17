using System;
using System.Collections.Generic;

namespace popka.Models;

public partial class User
{
    public string? Role { get; set; }

    public string FullName { get; set; } = null!;

    public string Login { get; set; } = null!;

    public string Password { get; set; } = null!;
}
