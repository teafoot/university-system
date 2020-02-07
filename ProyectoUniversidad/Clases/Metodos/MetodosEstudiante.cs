using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libreria
{
    class MetodosEstudiante
    {
        
        public static int Ingresar(Estudiante a)
        {
            int retorno = 0;
            SqlConnection connection = Conexion.Conectar();
            string sqlQuery = "INSERT INTO Estudiante VALUES(@nombre,@apellidopaterno,@apellidomaterno,@sexo,@carnetidentidad,@fechanacimiento,@paisnacimiento,@direccion,@telefono,@email)";
            SqlCommand comando = new SqlCommand(sqlQuery, connection);
            comando.Parameters.AddWithValue("@nombre", a.Nombre);
            comando.Parameters.AddWithValue("@apellidopaterno", a.Apellidopaterno);
            comando.Parameters.AddWithValue("@apellidomaterno", a.Apellidomaterno);
            comando.Parameters.AddWithValue("@sexo", a.Sexo);
            comando.Parameters.AddWithValue("@carnetidentidad", a.Carnetidentidad);
            comando.Parameters.AddWithValue("@fechanacimiento", a.Fechanacimiento);
            comando.Parameters.AddWithValue("@paisnacimiento", a.Paisnacimiento);
            comando.Parameters.AddWithValue("@direccion", a.Direccion);
            comando.Parameters.AddWithValue("@telefono", a.Telefono);
            comando.Parameters.AddWithValue("@email", a.Email);
            retorno = comando.ExecuteNonQuery();
            connection.Close();
            return retorno;
        }
        public static List<Estudiante> ObtenerEstudiantes(int sede, int carrera)
        {
            List<Estudiante> lista = new List<Estudiante>();
            SqlConnection connection = Conexion.Conectar();
            string sqlQuery = "SELECT CarnetIdentidad,(Nombre + ' ' + ApellidoPaterno + ' ' + ApellidoMaterno) AS completo FROM Estudiante, Universidad WHERE CarnetIdentidad = CodigoEstudiante AND Sede="+sede+" AND Carrera="+carrera;
            SqlCommand comando = new SqlCommand(sqlQuery, connection);
            SqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                Estudiante a = new Estudiante();
                a.Carnetidentidad = Convert.ToInt32(reader["CarnetIdentidad"]);
                a.Nombre = reader["completo"].ToString();
                lista.Add(a);
            }
            connection.Close();
            return lista;
        }
        public static Estudiante CargarEstudiante(int Ci)
        {
            Estudiante a = new Estudiante();
            SqlConnection connection = Conexion.Conectar();
            string sqlQuery = "SELECT * FROM Estudiante WHERE CarnetIdentidad=" + Ci;
            SqlCommand comando = new SqlCommand(sqlQuery, connection);
            SqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                a.Nombre = reader["Nombre"].ToString();
                a.Apellidopaterno = reader["ApellidoPaterno"].ToString();
                a.Apellidomaterno = reader["ApellidoMaterno"].ToString();
                a.Sexo = Convert.ToInt32(reader["Sexo"]);
                a.Carnetidentidad = Convert.ToInt32(reader["CarnetIdentidad"]);
                a.Fechanacimiento = Convert.ToDateTime(reader["FechaNacimiento"]);
                a.Paisnacimiento = reader["PaisNacimiento"].ToString();
                a.Direccion = reader["Direccion"].ToString();
                a.Telefono = Convert.ToInt32(reader["Telefono"]);
                a.Email = reader["Email"].ToString();
            }
            connection.Close();
            return a;
        }
        public static int Modificar(Estudiante a)
        {
            int retorno = 0;
            SqlConnection connection = Conexion.Conectar();
            string sqlQuery = "UPDATE Estudiante SET Nombre=@nombre,ApellidoPaterno=@apellidopaterno,ApellidoMaterno=@apellidomaterno,Sexo=@sexo,CarnetIdentidad=@carnetidentidad,FechaNacimiento=@fechanacimiento,PaisNacimiento=@paisnacimiento,Direccion=@direccion,Telefono=@telefono,Email=@email WHERE CarnetIdentidad=@carnetidentidad";
            SqlCommand comando = new SqlCommand(sqlQuery, connection);
            comando.Parameters.AddWithValue("@carnetidentidad", a.Carnetidentidad);
            comando.Parameters.AddWithValue("@nombre", a.Nombre);
            comando.Parameters.AddWithValue("@apellidopaterno", a.Apellidopaterno);
            comando.Parameters.AddWithValue("@apellidomaterno", a.Apellidomaterno);
            comando.Parameters.AddWithValue("@sexo", a.Sexo);
            comando.Parameters.AddWithValue("@fechanacimiento", a.Fechanacimiento);
            comando.Parameters.AddWithValue("@paisnacimiento", a.Paisnacimiento);
            comando.Parameters.AddWithValue("@direccion", a.Direccion);
            comando.Parameters.AddWithValue("@telefono", a.Telefono);
            comando.Parameters.AddWithValue("@email", a.Email);
            retorno = comando.ExecuteNonQuery();
            connection.Close();
            return retorno;
        }
        public static int Eliminar(int CI)
        {
            int retorno = 0;
            SqlConnection connection = Conexion.Conectar();
            string sqlQuery = "DELETE FROM Estudiante WHERE CarnetIdentidad='" + CI + "'; DELETE FROM Universidad WHERE CodigoEstudiante='" + CI + "'"+"; DELETE FROM NotasUniversidad WHERE CodigoEstudiante='"+CI+"'";
            SqlCommand comando = new SqlCommand(sqlQuery, connection);
            retorno = comando.ExecuteNonQuery();
            connection.Close();
            return retorno;
        }
    }
}
