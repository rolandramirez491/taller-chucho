using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaDatos
{
    public class CD_RegistroVentas
    {
        private static List<string> registro = new List<string>();
        private static List<string> registroV = new List<string>();
        public void GuardarRegistro(int id,string nombre,string apellido,int telefono)
        {
            registro.Add($"ID: {id}, Nombre: {nombre}, Apellido: {apellido}, Teléfono: {telefono}");
        }
        public void GuardarVenta(int id, string fecha, string origen,string destino, int valor)
        {
            registroV.Add($"ID: {id}, Fecha: {fecha}, Origen: {origen},Destino: {destino}, Valor: {valor}");
        }
        public DataTable ListarVentas()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Id", typeof(int));
            dt.Columns.Add("Fecha", typeof(string));
            dt.Columns.Add("Origen", typeof(string));
            dt.Columns.Add("Destino", typeof(string));
            dt.Columns.Add("Valor", typeof(int));
            foreach (string linea in registroV)
            {
                // Dividir la cadena por el separador (coma, punto y coma, etc.)
                string[] campos = linea.Split(','); // Cambiar separador según tu formato

                // Verificar que tenga exactamente 5 campos
                if (campos.Length == 5)
                {
                    DataRow fila = dt.NewRow();
                    fila["Id"] = int.Parse(campos[0].Trim().Split(':')[1]);
                    fila["Fecha"] = campos[1].Trim();
                    fila["Origen"] = campos[2].Trim();
                    fila["Destino"] = campos[3].Trim();
                    fila["Valor"] = int.Parse(campos[4].Trim().Split(':')[1]);

                    dt.Rows.Add(fila);
                }
            }

            return dt;

        }
        public DataTable BuscarCliente(int idFind)
        {
            // Crear DataTable con las columnas necesarias


            DataTable dt = new DataTable();
            dt.Columns.Add("Id", typeof(int));
            dt.Columns.Add("Nombre", typeof(string));
            dt.Columns.Add("Apellido", typeof(string));
            dt.Columns.Add("Telefono", typeof(int));
            foreach (string linea in registro)
            {
                // Dividir la cadena por el separador (coma, punto y coma, etc.)
                string[] campos = linea.Split(','); // Cambiar separador según tu formato

                // Verificar que tenga exactamente 5 campos
                if (campos.Length == 4)
                {
                    DataRow fila = dt.NewRow();
                    fila["Id"] = int.Parse(campos[0].Trim().Split(':')[1]);
                    fila["Nombre"] = campos[1].Trim();
                    fila["Apellido"] = campos[2].Trim();
                    fila["Telefono"] = int.Parse(campos[3].Trim().Split(':')[1]);

                    dt.Rows.Add(fila);
                }
            }
            DataRow[] filasFiltradas = dt.Select($"Id = {idFind}");
            DataTable dtFiltrado = dt.Clone();
            foreach (DataRow fila in filasFiltradas)
            {
                dtFiltrado.ImportRow(fila);
            }
            return dtFiltrado;
        }
    }
}
