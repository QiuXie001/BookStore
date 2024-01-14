using System;
using System.Collections.Generic;

namespace BookStore.DBStandard.Models;

public partial class Custom
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public string Password { get; set; } = null!;

    public string? Age { get; set; }

    public string Telephone { get; set; } = null!;

    public string? IdentityId { get; set; }

}
