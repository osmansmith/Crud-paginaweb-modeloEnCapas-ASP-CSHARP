using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class MPSite : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnFiltrar_Click(object sender, EventArgs e)
        {
            string filter = txtFiltro.Text;

            string url = string.Format("~/Ticket/ListarTicket.aspx?filter={0}", filter);

            Response.Redirect(url);
        }
    }
}