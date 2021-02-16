using System;
using System.ComponentModel.DataAnnotations.Schema;

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
