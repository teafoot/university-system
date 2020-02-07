using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libreria
{
    class MetodoCarrera
    {
        public static List<Carrera> ObtenerCarreras()
        {
            List<Carrera> lista = new List<Carrera>();
            SqlConnection connection = Conexion.Conectar();
            string sqlQuery = "SELECT * FROM Carrera";
            SqlCommand comando = new SqlCommand(sqlQuery, connection);
            SqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                Carrera a = new Carrera();
                a.Idcarrera = reader.GetInt32(0);
                a.Nombrecarrera = reader.GetString(1);
                lista.Add(a);
            }
            connection.Close();
            return lista;
        }
        public static int CargarCarrera(int codigoE)
        {
            int a=0;
            SqlConnection connection = Conexion.Conectar();
            string sqlQuery = "SELECT Carrera FROM Universidad WHERE CodigoEstudiante=" + codigoE;
            SqlCommand comando = new SqlCommand(sqlQuery, connection);
            SqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                a= Convert.ToInt32(reader["Carrera"]);
            }
            connection.Close();
            return a;
        }
    }
}
