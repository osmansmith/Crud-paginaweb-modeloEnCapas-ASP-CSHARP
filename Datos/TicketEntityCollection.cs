using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public static class TicketEntityCollection
    {
        private static List<TicketEntity> _listadoTickets = new List<TicketEntity>();

        public static List<TicketEntity> ListadoTicket
        {
            get
            {
                return _listadoTickets;
            }
            set
            {
                _listadoTickets = value;
            }
        }
    }
}
