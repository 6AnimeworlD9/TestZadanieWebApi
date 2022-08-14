using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WebApiForBank
{
    //модель таблицы счетов пользователей
    [Table("MoneyAccounts")]
    public class TableMoneyAccounts
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("number")]
        public string Number { get; set; }="";
    }
}
