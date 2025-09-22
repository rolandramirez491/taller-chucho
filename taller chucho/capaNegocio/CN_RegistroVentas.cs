using capaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace capaNegocio
{
    public class CN_RegistroVentas
    {
        CD_RegistroVentas registro = new CD_RegistroVentas();
        CD_RegistroVentas ventas = new CD_RegistroVentas();


        public void Guardar(int id, string nombre, string apellido, int telefono)
        {
            registro.GuardarRegistro(id, nombre, apellido, telefono);
        }
        public void Venta(int id, string nombre,string apellido,int telefono,string fecha, string origen,string destino, int valor)
        {
            ventas.GuardarVenta(id,nombre,apellido,telefono, fecha, origen,destino, valor);
        }
        public DataTable Listar()
        {
            return ventas.ListarVentas();
        }
        public DataTable Buscar(int id)
        {
            return registro.BuscarCliente(id);
        }
    }
}
