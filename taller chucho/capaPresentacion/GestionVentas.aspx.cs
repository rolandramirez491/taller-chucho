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
            ventas.Venta(int.Parse(txtId.Text), txtFecha.Text, txtOrigen.Text,txtDestino , int.Parse(txtValor.Text));
        }
    }
}