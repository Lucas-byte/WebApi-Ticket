using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi_Ticket.Models
{
    [Table("ticket")]
    public class Ticket : BaseModel
    {
        [Column("descricao")]
        public string Descricao { get; set; }

        [Column("autor")]
        public string NomeAutor { get; set; }

        [Column("data")]
        public DateTime Data { get; set; }

    }
}
