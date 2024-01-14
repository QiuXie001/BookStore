﻿using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace BookStore.DBStandard.Models;

public partial class DBContext : DbContext
{
    public DbSet<Custom> Custom{ get;set;}
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("data source=Qiu;initial catalog=Store;persist security info=True;user id=sa;password=123qwe;multipleactiveresultsets=True;encrypt=False;trustservercertificate=True;" );
    }
}
