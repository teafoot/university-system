using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libreria
{
    class MetodoSede
    {
        public static List<Sede> ObtenerSedes()
        {
            List<Sede> lista = new List<Sede>();
            SqlConnection connection = Conexion.Conectar();
            string sqlQuery = "SELECT * FROM Sede";
            SqlCommand comando = new SqlCommand(sqlQuery, connection);
            SqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                Sede a = new Sede();
                a.Idsede = reader.GetInt32(0);
                a.Nombresede = reader.GetString(1);
                lista.Add(a);
            }
            connection.Close();
            return lista;
        }
        public static int CargarSede(int codigoE)
        {
            int a=0;
            SqlConnection connection = Conexion.Conectar();
            string sqlQuery = "SELECT Sede FROM Universidad WHERE CodigoEstudiante=" + codigoE;
            SqlCommand comando = new SqlCommand(sqlQuery, connection);
            SqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                a = Convert.ToInt32(reader["Sede"]);
            }
            connection.Close();
            return a;
        }
    }
}
