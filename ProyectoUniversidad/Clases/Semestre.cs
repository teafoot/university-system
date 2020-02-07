using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libreria
{
    class Semestre
    {
        private int idsemestre;
        private string nombresemestre;

        public int Idsemestre
        {
            get
            {
                return idsemestre;
            }

            set
            {
                idsemestre = value;
            }
        }

        public string Nombresemestre
        {
            get
            {
                return nombresemestre;
            }

            set
            {
                nombresemestre = value;
            }
        }
    }
}
