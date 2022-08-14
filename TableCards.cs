using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WebApiForBank
{
    //модель таблицы банковских карт пользователей
    [Table("Cards")]
    public class TableCards
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("idMonAcc")]
        public int IdMonAcc { get; set; }
        [Column("number")]
        public string Number { get; set; } = "";
        [Column("value")]
        public double Value { get; set; }
    }
}
