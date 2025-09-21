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
        public void GuardarRegistro(int id,string nombre,string apellido,int telefono)
        {
            registro.Add($"ID: {id}, Nombre: {nombre}, Apellido: {apellido}, Teléfono: {telefono}");
        }
        public void GuardarVenta(int id, string fecha, string origen,string destino, int valor)
        {
            registro.Add($"ID: {id}, Fecha: {fecha}, Origen: {origen},Destino: {destino}, Valor: {valor}");
        }
        public DataTable ListarVentas()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Id", typeof(int));
            dt.Columns.Add("Fecha", typeof(string));
            dt.Columns.Add("Origen", typeof(string));
            dt.Columns.Add("Destino", typeof(string));
            dt.Columns.Add("Valor", typeof(int));
            foreach (string linea in registro)
            {
                // Dividir la cadena por el separador (coma, punto y coma, etc.)
                string[] campos = linea.Split(','); // Cambiar separador según tu formato

                // Verificar que tenga exactamente 5 campos
                if (campos.Length == 5)
                {
                    DataRow fila = dt.NewRow();
                    fila["Id"] = Convert.ToInt32(campos[0].Trim());
                    fila["Fecha"] = campos[1].Trim();
                    fila["Origen"] = campos[2].Trim();
                    fila["Destino"] = campos[3].Trim();
                    fila["Valor"] = Convert.ToInt32(campos[4].Trim());

                    dt.Rows.Add(fila);
                }
            }

            return dt;

        }
        public DataRow BuscarCliente(int idFind)
        {
            // Crear DataTable con las columnas necesarias
            DataTable dt = new DataTable();
            dt.Columns.Add("Id", typeof(int));
            dt.Columns.Add("Fecha", typeof(string));
            dt.Columns.Add("Origen", typeof(string));
            dt.Columns.Add("Destino", typeof(string));
            dt.Columns.Add("Valor", typeof(int));

            foreach (string linea in registro)
            {
                // Dividir la línea por comas
                string[] campos = linea.Split(',');

                // Convertir el primer campo (ID) a número
                int id = int.Parse(campos[0]);

                // Comparar si es igual al ID buscado
                if (id == idFind)
                {
                    // Crear nueva fila con los datos encontrados
                    DataRow nuevaFila = dt.NewRow();
                    nuevaFila["Id"] = int.Parse(campos[0].Trim());
                    nuevaFila["Fecha"] = campos[1].Trim();
                    nuevaFila["Origen"] = campos[2].Trim();
                    nuevaFila["Destino"] = campos[3].Trim();
                    nuevaFila["Valor"] = int.Parse(campos[4].Trim());

                    return nuevaFila; // Devolver el DataRow
                }
            }

            return null; // No se encontró
        }
    }
}
