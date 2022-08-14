using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WebApiForBank
{
    //модель таблицы избранных операций пользователей
    [Table("Favourites")]
    public class TableFavourites
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("info")]
        public string info { get; set; } = "";
        [Column("imageInfo")]
        public string Image { get; set; }
    }
}
