using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Modelo
{
    public static class TicketController
    {
        public static string Create(Ticket t)
        {
            var res = Datos.TicketEntityCollection.ListadoTicket.Find(x => x.Cliente.Rut == t.Cliente.Rut);
            if (res != null)
                return $"El ticket {t.Id} ya existe";


            TicketEntity ticketEntity = new TicketEntity()
            {
                Producto = t.Producto,
                Descripcion = t.Descripcion,
                Estado = t.Estado,
                Cliente = ClientType(t.Cliente)
            };

            TicketEntityCollection.ListadoTicket.Add(ticketEntity);


            return $"El ticket {TicketEntityCollection.ListadoTicket.Count} ha sido agregado con éxito";
        }

        public static Ticket Read(string id)
        {
            var res = TicketEntityCollection.ListadoTicket.Find(x => x.Id == id);
            if (res == null)
                return null;

            Ticket ticket = new Ticket()
            {
                Id = res.Id,                
                Producto = res.Producto,
                Descripcion = res.Descripcion,
                Estado = res.Estado

            };
            if (res.Cliente is EmpresaEntity emp)
            {

                Empresa empresa = new Empresa()
                {
                    Nombre = res.Cliente.Nombre,
                    Rut = res.Cliente.Rut,
                    Telefono = res.Cliente.Telefono,
                    Email = res.Cliente.Email,
                    RazonSocial = emp.RazonSocial
                };
                ticket.Cliente = empresa;
            };

            if (res.Cliente is PersonaNaturalEntity)
            {

                PersonaNatural personaNatural = new PersonaNatural()
                { 
                    Nombre = res.Cliente.Nombre,
                    Rut = res.Cliente.Rut,
                    Telefono = res.Cliente.Telefono,
                    Email = res.Cliente.Email
                };
                ticket.Cliente = personaNatural;
            };


            return ticket;
        }
        public static string Update(string id, string telefono, string email, string producto, string descripcion) 
        {
            var res = TicketEntityCollection.ListadoTicket.Find(x => x.Id == id);
            if (res == null)
                return $"El ticket con id : {id} no ha sido encontrado";

            res.Cliente.Telefono = telefono;
            res.Cliente.Email = email;
            res.Producto = producto;
            res.Descripcion = descripcion;

            return $"El ticket con id : {id} ha sido actualizado exitosamente";

        }
        public static string Delete(string Id) 
        {
            var res = TicketEntityCollection.ListadoTicket.Find(x => x.Id == Id);
            if (res == null)
                return $"El ticket con id : {Id} no ha sido encontrado";

            TicketEntityCollection.ListadoTicket.Remove(res);

            return $"El ticket con id : {Id} ha sido eliminado exitosamente";
        }
        public static List<Ticket> ReadAll() 
        { 
            List<Ticket> tickets = new List<Ticket>();

            TicketEntityCollection.ListadoTicket.ForEach(x =>
            {
                Ticket ticket = new Ticket()
                {
                    Id = x.Id,                    
                    Producto = x.Producto,
                    Descripcion = x.Descripcion,
                    Estado = x.Estado
                };
                if (x.Cliente is EmpresaEntity emp)
                {

                    Empresa empresa = new Empresa()
                    {
                        Nombre = x.Cliente.Nombre,
                        Rut = x.Cliente.Rut,
                        Telefono = x.Cliente.Telefono,
                        Email = x.Cliente.Email,
                        RazonSocial = emp.RazonSocial
                    };
                    ticket.Cliente = empresa;
                };

                if (x.Cliente is PersonaNaturalEntity per)
                {

                    PersonaNatural personaNatural = new PersonaNatural()
                    {
                        Nombre = x.Cliente.Nombre,
                        Rut = x.Cliente.Rut,
                        Telefono = x.Cliente.Telefono,
                        Email = x.Cliente.Email
                    };
                    ticket.Cliente = personaNatural;
                }               
               
                tickets.Add(ticket);
            });
            return tickets;
        
        }
        public static List<Ticket> Search(string filter) {
        
            List<Ticket> tickets = new List<Ticket>();

            TicketEntityCollection.ListadoTicket.Where(x =>
               x.Cliente.Nombre.Contains(filter) ||
               x.Cliente.Rut.Contains(filter) ||
               x.Estado.Contains(filter)).ToList().ForEach(x => {
                   Ticket ticket = new Ticket()
                   {
                       Id = x.Id,
                       Producto = x.Producto,
                       Descripcion = x.Descripcion,
                       Estado = x.Estado
                   };
                   if (x.Cliente is EmpresaEntity emp)
                   {

                       Empresa empresa = new Empresa()
                       {
                           Nombre = x.Cliente.Nombre,
                           Rut = x.Cliente.Rut,
                           Telefono = x.Cliente.Telefono,
                           Email = x.Cliente.Email,
                           RazonSocial = emp.RazonSocial
                       };
                       ticket.Cliente = empresa;
                   };

                   if (x.Cliente is PersonaNaturalEntity per)
                   {

                       PersonaNatural personaNatural = new PersonaNatural()
                       {
                           Nombre = x.Cliente.Nombre,
                           Rut = x.Cliente.Rut,
                           Telefono = x.Cliente.Telefono,
                           Email = x.Cliente.Email
                       };
                       ticket.Cliente = personaNatural;
                   }

                   tickets.Add(ticket);


               });
            return tickets;
        }

        private static ClienteEntity ClientType(Cliente cliente) {

            ClienteEntity clienteEntity = new ClienteEntity();

            if (cliente is Empresa emp)
            {

                EmpresaEntity empresa = new EmpresaEntity()
                {
                    Nombre = cliente.Nombre,
                    Rut = cliente.Rut,
                    Telefono = cliente.Telefono,
                    Email = cliente.Email,
                    RazonSocial = emp.RazonSocial
                };
                clienteEntity = empresa;
            };

            if (cliente is PersonaNatural)
            {

                PersonaNaturalEntity personaNatural = new PersonaNaturalEntity()
                {
                    Nombre = cliente.Nombre,
                    Rut = cliente.Rut,
                    Telefono = cliente.Telefono,
                    Email = cliente.Email
                };
                clienteEntity = personaNatural;
            };
            return clienteEntity;

        }

    }
}
