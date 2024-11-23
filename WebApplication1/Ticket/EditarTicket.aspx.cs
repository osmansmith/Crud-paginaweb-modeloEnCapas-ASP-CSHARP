using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Modelo;

namespace WebApplication1.Ticket
{
    public partial class EditarTicket : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string id = Request.Params["id"];
                if (id != null)
                {
                    CargarRegistro(id);
                }
                else
                {
                    lblMessage.Text = "Es necesario el id del ticket";
                }
            }
         }

        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            string id = lblIdValue.Text;
            string telefono = txtTelefonoValue.Text;
            string email = txtEmailValue.Text;
            string producto = txtProductoValue.Text;
            string descripcion = txtDescripcionValue.Text;

            string message = TicketController.Update(id,telefono,email,producto,descripcion);

            Response.Redirect($"~/Ticket/ListarTicket.aspx?message={message}");
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
                    txtTelefonoValue.Text = emp.Telefono;
                    txtEmailValue.Text = emp.Email;
                    txtProductoValue.Text = ticket.Producto;
                    txtDescripcionValue.Text = ticket.Descripcion;
                    lblEstadoValue.Text = ticket.Estado;

                }
                else if (ticket.Cliente is PersonaNatural perNat)
                {
                    trRazonSocial.Visible = false;
                    lblIdValue.Text = ticket.Id;
                    lblNombreValue.Text = perNat.Nombre;
                    lblRutValue.Text = perNat.Rut;
                    txtTelefonoValue.Text = perNat.Telefono;
                    txtEmailValue.Text = perNat.Email;
                    txtProductoValue.Text = ticket.Producto;
                    txtDescripcionValue.Text = ticket.Descripcion;
                    lblEstadoValue.Text = ticket.Estado;
                }
            }
            else
            {
                lblMessage.Text = $"Ticket n° {id} no encontrado";
            }
        }
    }
}