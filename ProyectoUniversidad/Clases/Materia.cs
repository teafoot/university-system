using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libreria
{
    class Materia
    {
        private int idmateria;
        private string nombremateria;

        public int Idmateria
        {
            get
            {
                return idmateria;
            }

            set
            {
                idmateria = value;
            }
        }

        public string Nombremateria
        {
            get
            {
                return nombremateria;
            }

            set
            {
                nombremateria = value;
            }
        }
    }
}
