using System.Collections.Generic;
using WebApi_Ticket.Data.Converter.Implementations;
using WebApi_Ticket.Data.VO;
using WebApi_Ticket.Models;
using WebApi_Ticket.Repository;
namespace WebApi_Ticket.Business
{
    public class TicketBusinessImplementation : ITicketBusiness
    {
        private readonly IRepository<Ticket> _repository;

        private readonly TicketConverter _converter;
        public TicketBusinessImplementation(IRepository<Ticket> repository)
        {
            _repository = repository;
            _converter = new TicketConverter();
        }
        public List<TicketVO> FindAll()
        {
            return _converter.Parse(_repository.FindAll());
        }

        public TicketVO FindById(long id)
        {
            return _converter.Parse(_repository.FindByID(id));
        }


        public TicketVO Create(TicketVO ticket)
        {
            var ticketEntity = _converter.Parse(ticket);
            ticketEntity = _repository.Create(ticketEntity);
            return _converter.Parse(ticketEntity);
        }

        public TicketVO Update(TicketVO ticket)
        {
            var ticketEntity = _converter.Parse(ticket);
            ticketEntity = _repository.Update(ticketEntity);
            return _converter.Parse(ticketEntity);
        }
        public void Delete(long id)
        {
            _repository.Delete(id);
        }
    }
}
