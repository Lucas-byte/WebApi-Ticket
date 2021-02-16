using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi_Ticket.Models;
using WebApi_Ticket.Repository;

namespace WebApi_Ticket.Business
{
    public class TicketBusinessImplementation : ITicketBusiness
    {
        private readonly IRepository<Ticket> _repository;

        public TicketBusinessImplementation(IRepository<Ticket> repository)
        {
            _repository = repository;
        }
        public List<Ticket> FindAll()
        {
            return _repository.FindAll();
        }

        public Ticket FindById(long id)
        {
            return _repository.FindByID(id);
        }


        public Ticket Create(Ticket ticket)
        {
            return _repository.Create(ticket);
        }

        public Ticket Update(Ticket ticket)
        {
            return _repository.Update(ticket);
        }
        public void Delete(long id)
        {
            _repository.Delete(id);
        }
    }
}
