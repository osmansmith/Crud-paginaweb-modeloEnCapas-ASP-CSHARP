using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services.Description;
using System.Web.UI;
using System.Web.UI.WebControls;
using Modelo;

namespace WebApplication1.Ticket
{
    public partial class DetalleTicket : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string id = Request.Params["id"];
            if (id != null)
            {
                CargarRegistro(id);
            }
            else
            {
                lblMessage.Text = $"Debe proporcionar el ID del vehículo";

            }
        }

        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            string id = lblIdValue.Text;
            string url = string.Format("~/Ticket/EditarTicket.aspx?id={0}", id);
            Response.Redirect(url);
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            string Id = lblIdValue.Text;

            string message = TicketController.Delete(Id);

            string url = string.Format("~/Ticket/ListarTicket.aspx?message={0}", message);

            Response.Redirect(url);
        }

        private void CargarRegistro(string id)
        {
            var ticket = Modelo.TicketController.Read(id);

            if (ticket != null)
            {
                if (ticket.Cliente is Empresa emp)
                {
                    trRazonSocial.Visible = true;
                    lblIdValue.Text = ticket.Id;
                    lblNombreValue.Text = emp.Nombre;
                    lblRazonSocialValue.Text = emp.RazonSocial;
                    lblRutValue.Text = emp.Rut;
                    lblTelefonoValue.Text = emp.Telefono;
                    lblEmailValue.Text = emp.Email;
                    lblProductoValue.Text = ticket.Producto;
                    lblDescripcionValue.Text = ticket.Descripcion;
                    lblEstadoValue.Text = ticket.Estado;

                }
                else if (ticket.Cliente is PersonaNatural perNat) 
                {
                    trRazonSocial.Visible = false;
                    lblIdValue.Text = ticket.Id;
                    lblNombreValue.Text = perNat.Nombre;                   
                    lblRutValue.Text = perNat.Rut;
                    lblTelefonoValue.Text = perNat.Telefono;
                    lblEmailValue.Text = perNat.Email;
                    lblProductoValue.Text = ticket.Producto;
                    lblDescripcionValue.Text = ticket.Descripcion;
                    lblEstadoValue.Text = ticket.Estado;
                }
            }
            else {
                lblMessage.Text = $"Ticket n° {id} no encontrado";
            }
        }
    }
}