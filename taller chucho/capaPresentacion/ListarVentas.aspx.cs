using capaNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace capaPresentacion
{
    public partial class ListarVentas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        CN_RegistroVentas ventas = new CN_RegistroVentas();
        protected void btnListar_Click(object sender, EventArgs e)
        {
            dgvListaVentas.DataSource = null;
            dgvListaVentas.DataSource = ventas.Listar();
            dgvListaVentas.DataBind();
            btnAtras.BackColor = System.Drawing.Color.LightGreen;
        }

        protected void btnAtras_Click(object sender, EventArgs e)
        {
            Response.Redirect("default.aspx");
        }
    }
}