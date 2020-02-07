using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libreria
{
    class MetodoPago
    {
        public static List<Pago> ObtenerPagos()
        {
            List<Pago> lista = new List<Pago>();
            SqlConnection connection = Conexion.Conectar();
            string sqlQuery = "SELECT * FROM Pago";
            SqlCommand comando = new SqlCommand(sqlQuery, connection);
            SqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                Pago a = new Pago();
                a.Idpago = reader.GetInt32(0);
                a.Nombrepago = reader.GetString(1);
                lista.Add(a);
            }
            connection.Close();
            return lista;
        }
        public static int CargarPago(int codigoE)
        {
            int a = 0;
            SqlConnection connection = Conexion.Conectar();
            string sqlQuery = "SELECT Pago FROM Universidad WHERE CodigoEstudiante=" + codigoE;
            SqlCommand comando = new SqlCommand(sqlQuery, connection);
            SqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                a = Convert.ToInt32(reader["Pago"]);
            }
            connection.Close();
            return a;
        }
    }
}
