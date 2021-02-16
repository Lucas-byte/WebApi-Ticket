using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi_Ticket.Models;

namespace WebApi_Ticket.Repository
{
    public interface IRepository<T> where T : BaseModel
    {
        List<T> FindAll();

        T FindByID(long id);

        T Create(T item);

        T Update(T item);

        void Delete(long id);
    }
}
