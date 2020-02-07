using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libreria
{
    class MetodoNota
    {
        public static List<Nota> ObtenerPrimerParcial()
        {
            List<Nota> lista = new List<Nota>();
            SqlConnection connection = Conexion.Conectar();
            string sqlQuery = "SELECT PrimerParcial FROM PrimerParcial";
            SqlCommand comando = new SqlCommand(sqlQuery, connection);
            SqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                Nota a = new Nota();
                a.Primerparcial = Convert.ToInt32(reader["PrimerParcial"]);
                lista.Add(a);
            }
            connection.Close();
            return lista;
        }
        public static List<Nota> ObtenerSegundoParcial()
        {
            List<Nota> lista = new List<Nota>();
            SqlConnection connection = Conexion.Conectar();
            string sqlQuery = "SELECT SegundoParcial FROM SegundoParcial";
            SqlCommand comando = new SqlCommand(sqlQuery, connection);
            SqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                Nota a = new Nota();
                a.Segundoparcial = Convert.ToInt32(reader["SegundoParcial"]);
                lista.Add(a);
            }
            connection.Close();
            return lista;
        }
        public static List<Nota> ObtenerEvaluacionProyecto()
        {
            List<Nota> lista = new List<Nota>();
            SqlConnection connection = Conexion.Conectar();
            string sqlQuery = "SELECT EvaluacionProyecto FROM EvaluacionProyecto";
            SqlCommand comando = new SqlCommand(sqlQuery, connection);
            SqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                Nota a = new Nota();
                a.Evaluacionproyecto = Convert.ToInt32(reader["EvaluacionProyecto"]);
                lista.Add(a);
            }
            connection.Close();
            return lista;
        }
        public static List<Nota> ObtenerExamenFinal()
        {
            List<Nota> lista = new List<Nota>();
            SqlConnection connection = Conexion.Conectar();
            string sqlQuery = "SELECT ExamenFinal FROM ExamenFinal";
            SqlCommand comando = new SqlCommand(sqlQuery, connection);
            SqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                Nota a = new Nota();
                a.Examenfinal = Convert.ToInt32(reader["ExamenFinal"]);
                lista.Add(a);
            }
            connection.Close();
            return lista;
        }
        public static List<Nota> ObtenerSegundoTurno()
        {
            List<Nota> lista = new List<Nota>();
            SqlConnection connection = Conexion.Conectar();
            string sqlQuery = "SELECT SegundoTurno FROM SegundoTurno";
            SqlCommand comando = new SqlCommand(sqlQuery, connection);
            SqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                Nota a = new Nota();
                a.Segundoturno = Convert.ToInt32(reader["SegundoTurno"]);
                lista.Add(a);
            }
            connection.Close();
            return lista;
        }
    }
}
