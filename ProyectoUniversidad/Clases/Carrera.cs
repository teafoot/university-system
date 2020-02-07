using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libreria
{
    class Carrera
    {
        private int idcarrera;
        private string nombrecarrera;

        public int Idcarrera
        {
            get
            {
                return idcarrera;
            }

            set
            {
                idcarrera = value;
            }
        }

        public string Nombrecarrera
        {
            get
            {
                return nombrecarrera;
            }

            set
            {
                nombrecarrera = value;
            }
        }
    }
}
