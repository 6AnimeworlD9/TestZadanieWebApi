using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WebApiForBank
{
    public class Context : DbContext
{
    public DbSet<TableMoneyAccounts> TMA { get; set; } = null!;
    public DbSet<TableCards> TC { get; set; } = null!;
    public DbSet<TableHisOfOper> THO { get; set; } = null!;
    public DbSet<TableFavourites> TF { get; set; } = null!;
    public Context()
    {

    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer (Resource.StringConnection);
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        
    }
}
}
