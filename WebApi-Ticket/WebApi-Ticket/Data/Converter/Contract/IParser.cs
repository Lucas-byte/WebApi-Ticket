using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi_Ticket.Data.Converter.Contract
{
    public interface IParser<O,D>
    {
        D Parse(O origem);

        List<D> Parse(List<O> origem);
    }
}
