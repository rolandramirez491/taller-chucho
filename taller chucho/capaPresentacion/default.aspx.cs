using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services.Description;
using System.Web.UI;
using System.Web.UI.WebControls;
using capaNegocio;
namespace capaPresentacion
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        CN_RegistroVentas registro = new CN_RegistroVentas();
        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            registro.Guardar(int.Parse(txtId.Text), txtNomb.Text, txtApell.Text, int.Parse(txtTel.Text));
        }
    }
}