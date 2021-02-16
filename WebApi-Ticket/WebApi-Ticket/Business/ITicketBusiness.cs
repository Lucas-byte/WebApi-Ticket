using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi_Ticket.Models;
namespace WebApi_Ticket.Business
{
    public interface ITicketBusiness
    {
        List<Ticket> FindAll();

        Ticket FindById(long id);

        Ticket Create(Ticket ticket);

        Ticket Update(Ticket ticket);

        void Delete(long id);
    }
}
