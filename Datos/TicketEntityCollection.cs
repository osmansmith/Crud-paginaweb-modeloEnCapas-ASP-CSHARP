
using System.Collections.Generic;

namespace Datos
{
    public static class TicketEntityCollection
    {
        private static List<TicketEntity> _listadoTickets;

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
