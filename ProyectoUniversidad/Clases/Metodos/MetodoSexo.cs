using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libreria
{
    class MetodoSexo
    {
        public static List<Sexo> ObtenerSexos()
        {
            List<Sexo> lista = new List<Sexo>();
            SqlConnection connection = Conexion.Conectar();
            string sqlQuery = "SELECT * FROM Sexo";
            SqlCommand comando = new SqlCommand(sqlQuery, connection);
            SqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                Sexo a = new Sexo();
                a.Idsexo= reader.GetInt32(0);
                a.Nombresexo = reader.GetString(1);
                lista.Add(a);
            }
            connection.Close();
            return lista;
        }
        public static int CargarSexo(int carnetidentidad)
        {
            int a=0;
            SqlConnection connection = Conexion.Conectar();
            string sqlQuery = "SELECT Sexo FROM Estudiante WHERE CarnetIdentidad=" + carnetidentidad;
            SqlCommand comando = new SqlCommand(sqlQuery, connection);
            SqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                a=Convert.ToInt32(reader["Sexo"]);
            }
            connection.Close();
            return a;
        }
    }
}
