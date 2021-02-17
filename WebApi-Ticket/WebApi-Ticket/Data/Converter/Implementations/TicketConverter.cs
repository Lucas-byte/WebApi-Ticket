using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi_Ticket.Data.Converter.Contract;
using WebApi_Ticket.Data.VO;
using WebApi_Ticket.Models;

namespace WebApi_Ticket.Data.Converter.Implementations
{
    public class TicketConverter : IParser<TicketVO, Ticket>, IParser<Ticket,TicketVO>
    {
        public Ticket Parse(TicketVO origem)
        {
            if (origem == null) return null;
            return new Ticket
            {
                Id = origem.Id,
                Descricao = origem.Descricao,
                NomeAutor = origem.NomeAutor,
                Data = origem.Data,
                Telefone = origem.Telefone
            };
        }
        public TicketVO Parse(Ticket origem)
        {
            if (origem == null) return null;
            return new TicketVO
            {
                Id = origem.Id,
                Descricao = origem.Descricao,
                NomeAutor = origem.NomeAutor,
                Data = origem.Data,
                Telefone = origem.Telefone
            };
        }

        public List<Ticket> Parse(List<TicketVO> origem)
        {
            return origem.Select(item => Parse(item)).ToList();
        }
        public List<TicketVO> Parse(List<Ticket> origem)
        {
            return origem.Select(item => Parse(item)).ToList();
        }
    }
}
