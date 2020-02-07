using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libreria
{
    class MetodosUniversidad
    {
        public static int Ingresar(Universidad a)
        {
            int retorno = 0;
            SqlConnection connection = Conexion.Conectar();
            string sqlQuery = "INSERT INTO Universidad VALUES(@codigoestudiante,@passwordestudiante,@carrera,@sede,@pago,@gestion,@legalizadabachiller,@fotocopialibreta,@certificadonacimiento,@fotocopiacarnetidentidad,@fotografiasfondoazul)";
            SqlCommand comando = new SqlCommand(sqlQuery, connection);
            comando.Parameters.AddWithValue("@codigoestudiante", a.Codigoestudiante);//
            comando.Parameters.AddWithValue("@passwordestudiante", a.Passwordestudiante);
            comando.Parameters.AddWithValue("@carrera", a.Carrera);
            comando.Parameters.AddWithValue("@sede", a.Sede);
            comando.Parameters.AddWithValue("@pago", a.Pago);
            comando.Parameters.AddWithValue("@gestion", a.Gestion);
            comando.Parameters.AddWithValue("@legalizadabachiller", a.Legalizadabachiller);
            comando.Parameters.AddWithValue("@fotocopialibreta", a.Fotocopialibreta);
            comando.Parameters.AddWithValue("@certificadonacimiento", a.Certificadonacimiento);
            comando.Parameters.AddWithValue("@fotocopiacarnetidentidad", a.Fotocopiacarnetidentidad);
            comando.Parameters.AddWithValue("@fotografiasfondoazul",a.Fotografiasfondoazul);
            retorno = comando.ExecuteNonQuery();
            connection.Close();
            return retorno;
        }
        public static int IngresarNota(int ci, int sede, int carrera)
        {
            int retorno = 0;
            SqlConnection connection = Conexion.Conectar();
            for (int i = 1; i <= 11; i++) // semestres 11MAX
            {
                for (int j = 1; j <= 7; j++) // materias 7MAX
                {
                    string sqlQuery = "INSERT INTO NotasUniversidad VALUES(@codigoestudiante,@sede,@carrera,@semestre,@materia,@primerparcial,@segundoparcial,@evaluacionproyecto,@examenfinal,@segundoturno,@notafinal)";
                    SqlCommand comando = new SqlCommand(sqlQuery, connection);
                    comando.Parameters.AddWithValue("@codigoestudiante", ci);//
                    comando.Parameters.AddWithValue("@sede", sede);
                    comando.Parameters.AddWithValue("@carrera", carrera);
                    comando.Parameters.AddWithValue("@semestre", i);
                    comando.Parameters.AddWithValue("@materia", j);
                    comando.Parameters.AddWithValue("@primerparcial", Convert.ToInt32(null));
                    comando.Parameters.AddWithValue("@segundoparcial", Convert.ToInt32(null));
                    comando.Parameters.AddWithValue("@evaluacionproyecto", Convert.ToInt32(null));
                    comando.Parameters.AddWithValue("@examenfinal", Convert.ToInt32(null));
                    comando.Parameters.AddWithValue("@segundoturno", Convert.ToInt32(null));
                    comando.Parameters.AddWithValue("@notafinal", Convert.ToInt32(null));
                    retorno=comando.ExecuteNonQuery();
                }
            }
            connection.Close();
            return retorno;
        }
        public static Universidad Cargar(int codigoE)
        {
            Universidad a = new Universidad();
            SqlConnection connection = Conexion.Conectar();
            string sqlQuery = "SELECT * FROM Universidad WHERE CodigoEstudiante=" + codigoE;
            SqlCommand comando = new SqlCommand(sqlQuery, connection);
            SqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                a.Codigoestudiante = Convert.ToInt32(reader["CodigoEstudiante"]);
                a.Passwordestudiante = reader["PasswordEstudiante"].ToString();
                a.Carrera = Convert.ToInt32(reader["Carrera"]);
                a.Sede = Convert.ToInt32(reader["Sede"]);
                a.Pago = Convert.ToInt32(reader["Pago"]);
                a.Gestion = Convert.ToInt32(reader["Gestion"]);
                a.Legalizadabachiller = Convert.ToInt32(reader["LegalizadaBachiller"]);
                a.Fotocopialibreta = Convert.ToInt32(reader["FotocopiaLibreta"]);
                a.Certificadonacimiento = Convert.ToInt32(reader["CertificadoNacimiento"]);
                a.Fotocopiacarnetidentidad = Convert.ToInt32(reader["FotocopiaCarnetIdentidad"]);
                a.Fotografiasfondoazul = Convert.ToInt32(reader["FotografiasFondoAzul"]);
            }
            connection.Close();
            return a;
        }
        public static Nota CargarNota(int codigoE, int idsemestre, int idmateria)
        {
            Nota a = new Nota();
            SqlConnection connection = Conexion.Conectar();
            string sqlQuery = "SELECT PrimerParcial,SegundoParcial,EvaluacionProyecto,ExamenFinal,SegundoTurno,NotaFinal FROM NotasUniversidad WHERE CodigoEstudiante=" + codigoE + " AND Semestre=" + idsemestre + " AND Materia=" + idmateria;
            SqlCommand comando = new SqlCommand(sqlQuery, connection);
            SqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                a.Primerparcial = Convert.ToInt32(reader["PrimerParcial"]);
                a.Segundoparcial = Convert.ToInt32(reader["SegundoParcial"]);
                a.Evaluacionproyecto = Convert.ToInt32(reader["EvaluacionProyecto"]);
                a.Examenfinal = Convert.ToInt32(reader["ExamenFinal"]);
                a.Segundoturno = Convert.ToInt32(reader["SegundoTurno"]);
                a.Notafinal = Convert.ToInt32(reader["NotaFinal"]);
            }
            connection.Close();
            return a;
        }
        public static int Modificar(Universidad a)
        {
            int retorno = 0;
            SqlConnection connection = Conexion.Conectar();
            string sqlQuery = "UPDATE Universidad SET PasswordEstudiante=@passwordestudiante,Carrera=@carrera,Sede=@sede,Pago=@pago,Gestion=@gestion,LegalizadaBachiller=@legalizadabachiller,FotocopiaLibreta=@fotocopialibreta,CertificadoNacimiento=@certificadonacimiento,FotocopiaCarnetIdentidad=@fotocopiacarnetidentidad,FotografiasFondoAzul=@fotografiasfondoazul WHERE CodigoEstudiante=@codigoestudiante;";
            sqlQuery += "UPDATE NotasUniversidad SET Carrera=@carrera WHERE CodigoEstudiante=@codigoestudiante";
            SqlCommand comando = new SqlCommand(sqlQuery, connection);
            comando.Parameters.AddWithValue("@codigoestudiante", a.Codigoestudiante);//
            comando.Parameters.AddWithValue("@passwordestudiante", a.Passwordestudiante);
            comando.Parameters.AddWithValue("@carrera", a.Carrera);
            comando.Parameters.AddWithValue("@sede", a.Sede);
            comando.Parameters.AddWithValue("@pago", a.Pago);
            comando.Parameters.AddWithValue("@gestion", a.Gestion);
            comando.Parameters.AddWithValue("@legalizadabachiller", a.Legalizadabachiller);
            comando.Parameters.AddWithValue("@fotocopialibreta", a.Fotocopialibreta);
            comando.Parameters.AddWithValue("@certificadonacimiento", a.Certificadonacimiento);
            comando.Parameters.AddWithValue("@fotocopiacarnetidentidad", a.Fotocopiacarnetidentidad);
            comando.Parameters.AddWithValue("@fotografiasfondoazul", a.Fotografiasfondoazul);
            retorno = comando.ExecuteNonQuery();
            connection.Close();
            return retorno;
        }
        public static int ModificarNota(Nota a)
        {
            int retorno = 0;
            SqlConnection connection = Conexion.Conectar();
            string sqlQuery = "UPDATE NotasUniversidad SET Sede=@sede,Carrera=@carrera,Semestre=@semestre,Materia=@materia,PrimerParcial=@primerparcial,SegundoParcial=@segundoparcial,EvaluacionProyecto=@evaluacionproyecto,ExamenFinal=@examenfinal,SegundoTurno=@segundoturno,NotaFinal=@notafinal "+ "WHERE CodigoEstudiante=@codigoestudiante AND Semestre=@semestre AND Materia=@materia";
            SqlCommand comando = new SqlCommand(sqlQuery, connection);
            comando.Parameters.AddWithValue("@codigoestudiante", a.Codigoestudiante);//
            comando.Parameters.AddWithValue("@sede", a.Sede);
            comando.Parameters.AddWithValue("@carrera", a.Carrera);
            comando.Parameters.AddWithValue("@semestre", a.Semestre);
            comando.Parameters.AddWithValue("@materia", a.Materia);
            comando.Parameters.AddWithValue("@primerparcial", a.Primerparcial);
            comando.Parameters.AddWithValue("@segundoparcial", a.Segundoparcial);
            comando.Parameters.AddWithValue("@evaluacionproyecto", a.Evaluacionproyecto);
            comando.Parameters.AddWithValue("@examenfinal", a.Examenfinal);
            comando.Parameters.AddWithValue("@segundoturno", a.Segundoturno);
            a.Notafinal = a.Primerparcial + a.Segundoparcial + a.Evaluacionproyecto + a.Examenfinal + a.Segundoturno;
            comando.Parameters.AddWithValue("@notafinal", a.Notafinal);
            retorno = comando.ExecuteNonQuery();
            connection.Close();
            return retorno;
        }
        
    }
}
