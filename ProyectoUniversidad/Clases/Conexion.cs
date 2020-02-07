using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libreria
{
    class Conexion
    {
        public static SqlConnection Conectar()
        {
            SqlConnection Connection = new SqlConnection("Data Source=LAPTOP-FS0I3MUM;Initial Catalog=unifranz;Integrated Security=True");
            Connection.Open();
            return Connection;
        }
    }
}
