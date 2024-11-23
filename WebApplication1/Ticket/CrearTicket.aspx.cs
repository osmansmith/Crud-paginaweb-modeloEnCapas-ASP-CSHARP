using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Modelo;

namespace WebApplication1.Ticket
{
    public partial class CrearTicket : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void AgregarTicket(object sender, EventArgs e)
        {
           
                Modelo.Ticket ticket = new Modelo.Ticket()
                {
                    Producto = txtProducto.Text,
                    Descripcion = txtDescripción.Text,
                    Estado = txtEstado.Text
                };
                if (txtRazonSocial.Text != "")
                {
                    Modelo.Empresa empresa = new Modelo.Empresa()
                    {
                        Nombre = txtNombre.Text,
                        Rut = txtRut.Text,
                        Telefono = txtTelefono.Text,
                        Email = txtEmail.Text,
                        RazonSocial = txtRazonSocial.Text
                    };
                    ticket.Cliente = empresa;
                }
                else {

                    Modelo.PersonaNatural personaNatural = new Modelo.PersonaNatural()
                    {
                        Nombre = txtNombre.Text,
                        Rut = txtRut.Text,
                        Telefono = txtTelefono.Text,
                        Email = txtEmail.Text

                    };
                    ticket.Cliente = personaNatural;
                }
                string message = Modelo.TicketController.Create(ticket);
              
                Response.Redirect($"~/Ticket/ListarTicket.aspx?message={message}");
            
        }

        protected void DdlTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlTipo.SelectedValue == "Empresa")
            {
                divRazonSocial.Visible = true;
            }
            else
            {
                divRazonSocial.Visible = false;
            }
        }
    }
}