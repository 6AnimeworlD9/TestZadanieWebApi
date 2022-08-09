using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WebApiForBank
{
    public class TableHisOfOper
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("info")]
        public string info { get; set; } = "";
        [Column("imageInfo")]
        public byte[] Image { get; set; }
    }
}
