using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Ticket
    {
        public string Id { get; set; }
        public Cliente Cliente { get; set; }
        public string Producto { get; set; }
        public string Descripcion { get; set; }
        public string Estado { get; set; }
        private DateTime CreatedAt_ { get; set; } = DateTime.Now;

        public DateTime GetCreatedAt()
        {
            return CreatedAt_;
        }
    }
}
