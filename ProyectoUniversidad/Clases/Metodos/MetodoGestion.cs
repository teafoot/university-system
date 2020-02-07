using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libreria
{
    class MetodoGestion
    {
        public static List<Gestion> ObtenerGestiones()
        {
            List<Gestion> lista = new List<Gestion>();
            SqlConnection connection = Conexion.Conectar();
            string sqlQuery = "SELECT * FROM Gestion";
            SqlCommand comando = new SqlCommand(sqlQuery, connection);
            SqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                Gestion a = new Gestion();
                a.Idgestion = reader.GetInt32(0);
                a.Nombregestion = reader.GetString(1);
                lista.Add(a);
            }
            connection.Close();
            return lista;
        }
        public static int CargarGestion(int codigoE)
        {
            int a = 0;
            SqlConnection connection = Conexion.Conectar();
            string sqlQuery = "SELECT Gestion FROM Universidad WHERE CodigoEstudiante=" + codigoE;
            SqlCommand comando = new SqlCommand(sqlQuery, connection);
            SqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                a = Convert.ToInt32(reader["Gestion"]);
            }
            connection.Close();
            return a;
        }
    }
}
