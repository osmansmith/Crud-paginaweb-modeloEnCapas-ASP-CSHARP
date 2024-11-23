using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Modelo;

namespace WebApplication1.Ticket
{
    public partial class ListarTicket : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string message = Request.Params["message"];
            if (message != null)
                lblMessage.Text += message + "\n";

            string filter = Request.Params["filter"];

            if (filter != null)
                BusquedaAvanzada(filter);
            else
                ListAll();

        }

        private void ListAll()
        {
            gdvListadoTickets.DataSource = null;

            var res = TicketController.ReadAll();
            if (res.Count() == 0)
            {
                lblMessage.Text += "No existen más registros para mostrar";
            }
            else
            {
                gdvListadoTickets.DataSource = res;
                gdvListadoTickets.DataBind();
            }
        }
        private void BusquedaAvanzada(string filtro)
        {
            gdvListadoTickets.DataSource = null;

            var res = TicketController.Search(filtro);
            if (res.Count == 0)
                lblMessage.Text += $"No existen registro con el filtro: {filtro}";
            else
            {
                lblMessage.Text = $"Se han encontrado {res.Count} coincidencias con el filtro {filtro}";
                gdvListadoTickets.DataSource = res;
                gdvListadoTickets.DataBind();
            }
        }

        protected void gdvListadoTickets_SelectedIndexChanged(object sender, EventArgs e)
        {
            int row = gdvListadoTickets.SelectedIndex;

            string id = gdvListadoTickets.DataKeys[row].Values[0].ToString();

            string url = string.Format("~/Ticket/DetalleTicket.aspx?id={0}",id);

            Response.Redirect(url);

        }
    }
}