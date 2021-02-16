using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi_Ticket.Models
{
    public class BaseModel
    {
        [Column("id")]
        public long Id { get; set; }
    }
}
