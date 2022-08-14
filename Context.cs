using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WebApiForBank
{
    //класс контекста БД, с помощью которой уже и будем работать с БД из SQL Express
    public class Context : DbContext
{
    public DbSet<TableMoneyAccounts> TMA { get; set; } = null!;
    public DbSet<TableCards> TC { get; set; } = null!;
    public DbSet<TableHisOfOper> THO { get; set; } = null!;
    public DbSet<TableFavourites> TF { get; set; } = null!;
    public Context(DbContextOptions<Context> options)
    : base(options)
        {

    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        
    }
}
}
