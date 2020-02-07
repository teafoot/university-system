using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libreria
{
    class MetodoSemestre
    {
        public static List<Semestre> ObtenerSemestres()
        {
            List<Semestre> lista = new List<Semestre>();
            SqlConnection connection = Conexion.Conectar();
            string sqlQuery = "SELECT * FROM Semestre";
            SqlCommand comando = new SqlCommand(sqlQuery, connection);
            SqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                Semestre a = new Semestre();
                a.Idsemestre = reader.GetInt32(0);
                a.Nombresemestre = reader.GetString(1);
                lista.Add(a);
            }
            connection.Close();
            return lista;
        }
    }
}
