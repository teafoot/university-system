using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libreria
{
    class MetodoAdministrador
    {
        public static int Ingresar(Administrador a)
        {
            int retorno = 0;
            SqlConnection connection = Conexion.Conectar();
            string sqlQuery = "INSERT INTO Admin VALUES(@login,@password)";
            SqlCommand comando = new SqlCommand(sqlQuery, connection);
            comando.Parameters.AddWithValue("@login", a.Login);
            comando.Parameters.AddWithValue("@password", a.Password);
            retorno = comando.ExecuteNonQuery();
            connection.Close();
            return retorno;
        }
        public static List<Administrador> ObtenerAdministradores()
        {
            List<Administrador> lista = new List<Administrador>();
            SqlConnection connection = Conexion.Conectar();
            string sqlQuery = "SELECT * FROM Admin";
            SqlCommand comando = new SqlCommand(sqlQuery, connection);
            SqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                Administrador a = new Administrador();
                a.Login = reader["Login"].ToString();
                a.Password = reader["Password"].ToString();
                lista.Add(a);
            }
            connection.Close();
            return lista;
        }
        public static Administrador CargarAdministrador(string login)
        {
            Administrador a = new Administrador();
            SqlConnection connection = Conexion.Conectar();
            string sqlQuery = "SELECT * FROM Admin WHERE Login='" + login+"'";
            SqlCommand comando = new SqlCommand(sqlQuery, connection);
            SqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                a.Login = reader["Login"].ToString();
                a.Password = reader["Password"].ToString();
            }
            connection.Close();
            return a;
        }
        public static int Modificar(Administrador a)
        {
            int retorno = 0;
            SqlConnection connection = Conexion.Conectar();
            string sqlQuery = "UPDATE Admin SET Login=@login,Password=@password WHERE Login='" + a.Login+"'";
            SqlCommand comando = new SqlCommand(sqlQuery, connection);
            comando.Parameters.AddWithValue("@login", a.Login);
            comando.Parameters.AddWithValue("@password", a.Password);
            retorno = comando.ExecuteNonQuery();
            connection.Close();
            return retorno;
        }
        public static int Eliminar(String login)
        {
            int retorno = 0;
            SqlConnection connection = Conexion.Conectar();
            string sqlQuery = "DELETE FROM Admin WHERE Login='" + login+"'";
            SqlCommand comando = new SqlCommand(sqlQuery, connection);
            retorno = comando.ExecuteNonQuery();
            connection.Close();
            return retorno;
        }
    }
}
