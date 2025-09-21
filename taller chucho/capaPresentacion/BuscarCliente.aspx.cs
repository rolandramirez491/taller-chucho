using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using capaNegocio;
namespace capaPresentacion
{
    public partial class BuscarCliente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        CN_RegistroVentas registro = new CN_RegistroVentas();
        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);


        }
    }
}