
using Datos;
using System;

namespace Modelo
{
    public class Ticket
    {
        public string Id { get; set; }
        public Cliente Cliente { get; set; }
        public string Producto { get; set; }
        public string Descripción { get; set; }
        public string Estado { get; set; }
        private DateTime _createdAt { get; set; } = DateTime.Now;

        public DateTime getCreatedAt()
        {
            return _createdAt;
        }
    }
}
