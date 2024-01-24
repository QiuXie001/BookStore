using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace BookStore.DBStandard.Models;

public partial class DBContext : DbContext
{
    public DbSet<Admin> Admin{ get;set;}
    public DbSet<Custom> Custom{ get;set;}
    public DbSet<Book> Book{ get;set;}
    public DbSet<BookType> BookType{ get;set;}
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("data source=Qiu;initial catalog=Store;persist security info=True;user id=sa;password=123qwe;multipleactiveresultsets=True;encrypt=False;trustservercertificate=True;" );
    }
}
