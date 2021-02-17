using System.Collections.Generic;
using WebApi_Ticket.Data.VO;
using WebApi_Ticket.Models;
namespace WebApi_Ticket.Business
{
    public interface ITicketBusiness
    {
        List<TicketVO> FindAll();

        TicketVO FindById(long id);

        TicketVO Create(TicketVO ticket);

        TicketVO Update(TicketVO ticket);

        void Delete(long id);
    }
}
