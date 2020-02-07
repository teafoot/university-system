using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libreria
{
    class MetodoAutenticar
    {
        public static int Admin(string Login, string Password)
        {
            int retorno = 0;
            SqlConnection connection = Conexion.Conectar();
            string sqlQuery = "SELECT Login,Password FROM Admin WHERE Login='" + Login + "' AND Password='" + Password + "'";
            SqlCommand comando = new SqlCommand(sqlQuery, connection);
            SqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                if ((reader["Login"].ToString() == Login) && (reader["Password"].ToString() == Password))
                {
                    retorno = 1;
                    //tipouser = Convert.ToInt32(reader["tipouser"]);
                }
                else
                {
                    retorno = 0;
                }
            }
            connection.Close();
            return retorno;
        }
        public static int Estudiante(string Login, string Password)
        {
            int retorno = 0;
            SqlConnection connection = Conexion.Conectar();
            string sqlQuery = "SELECT CodigoEstudiante,PasswordEstudiante FROM Universidad WHERE CodigoEstudiante='" + Login + "' AND PasswordEstudiante='" + Password + "'";
            SqlCommand comando = new SqlCommand(sqlQuery, connection);
            SqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                if ((reader["CodigoEstudiante"].ToString() == Login) && (reader["PasswordEstudiante"].ToString() == Password))
                {
                    retorno = 1;
                    //tipouser = Convert.ToInt32(reader["tipouser"]);
                }
                else
                {
                    retorno = 0;
                }
            }
            connection.Close();
            return retorno;
        }
    }
}
