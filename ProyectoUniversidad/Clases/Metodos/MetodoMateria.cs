using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libreria
{
    class MetodoMateria
    {
        public static List<Materia> ObtenerMaterias(int idcarrera,int idsemestre)
        {
            List<Materia> lista = new List<Materia>();
            SqlConnection connection = Conexion.Conectar();
            string sqlQuery = "SELECT IdMateria,NombreMateria FROM Materia WHERE IdCarrera=" + idcarrera+" AND IdSemestre="+idsemestre;
            SqlCommand comando = new SqlCommand(sqlQuery, connection);
            SqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                Materia a = new Materia();
                // carrera y semestre
                a.Idmateria = Convert.ToInt32(reader["IdMateria"]);
                a.Nombremateria = reader["NombreMateria"].ToString();
                lista.Add(a);
            }
            connection.Close();
            return lista;
        }
        
    }
}
