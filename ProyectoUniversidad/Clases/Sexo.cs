using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libreria
{
    class Sexo
    {
        private int idsexo;
        private string nombresexo;

        public int Idsexo
        {
            get
            {
                return idsexo;
            }

            set
            {
                idsexo = value;
            }
        }

        public string Nombresexo
        {
            get
            {
                return nombresexo;
            }

            set
            {
                nombresexo = value;
            }
        }
    }
}
