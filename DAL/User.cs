using System;
using System.Collections.Generic;

namespace CustomerCareModule.DAL;

public partial class User
{
    public int Id { get; set; }
    public virtual Role? Role { get; set; }
    public string Email { get; internal set; }
    public string Password { get; internal set; }
    public string? Name { get; internal set; }
    public int? RoleId { get; internal set; }
}
