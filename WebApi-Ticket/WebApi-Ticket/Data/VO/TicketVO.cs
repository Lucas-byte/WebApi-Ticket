using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApi_Ticket.Data.VO
{
   
    public class TicketVO
    {
        public long Id { get; set; }
        public string Descricao { get; set; }
        public string NomeAutor { get; set; }
        public DateTime Data { get; set; }
        public string Telefone { get; set; }
    }
}
