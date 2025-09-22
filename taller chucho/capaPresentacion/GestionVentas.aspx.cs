using capaNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace capaPresentacion
{
    public partial class GestionVentas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        CN_RegistroVentas ventas = new CN_RegistroVentas();

        protected void btnRegistrar_Click(object sender, EventArgs e)
        {
            ventas.Venta(int.Parse(txtId.Text), txtFecha.Text, txtOrigen.Text,txtDestino.Text , int.Parse(txtValor.Text));
            lblExito.Text = "Venta registrada con exito!";
            txtId.Text = "";
            txtFecha.Text = "";
            txtOrigen.Text = "";
            txtDestino.Text = "";
            txtValor.Text = "";
        }

        protected void btnAtras_Click(object sender, EventArgs e)
        {
            Response.Redirect("default.aspx");
        }
    }
}