using System;
using System.Collections.Generic;

namespace BookStore.DBStandard.Models;

public partial class Admin
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Password { get; set; } = null!;

    public int? Age { get; set; }

    public string Telephone { get; set; } = null!;

    public string? IdentityId { get; set; }
}
