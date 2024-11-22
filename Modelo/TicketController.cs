
using Datos;

namespace Modelo
{
    public static class TicketController
    {
        public static string Create(Ticket t) 
        {
            var res = TicketEntityCollection.ListadoTicket.Find(x => x.Id == t.Id);
            if (res != null)
                return $"El ticket {t.Id} ya existe";


            TicketEntity ticketEntity = new TicketEntity()
            {
                Producto = t.Producto,
                Descripcion = t.Descripción,
                Estado = t.Estado
            };

            if (t.Cliente is Empresa emp) {

                EmpresaEntity empresa = new EmpresaEntity()
                {
                    Nombre = emp.Nombre,
                    Rut = emp.Rut,
                    Telefono = emp.Telefono,
                    Email = emp.Email,
                    RazonSocial = emp.RazonSocial
                };
                ticketEntity.Cliente = empresa;
            };

            if (t.Cliente is PersonaNatural per) {

                PersonaNaturalEntity personaNatural = new PersonaNaturalEntity()
                {
                    Nombre = per.Nombre,
                    Rut = per.Rut,
                    Telefono = per.Telefono,
                    Email = per.Email
                };
                ticketEntity.Cliente= personaNatural;
            };
                                               

            return $"El ticket {t.Id} ha sido agregado con éxito";
        }

        public static TicketEntity Read(string id) 
        {
            var res = TicketEntityCollection.ListadoTicket.Find(x => x.Id == id);
            if (res == null)
                return null;
            TicketEntity ticketEntity = res;

            return ticketEntity;
        }
        public static void Update() { }
        public static void Delete() { }
        public static void ReadAll() { }
        public static void Search() { }

    }
}
