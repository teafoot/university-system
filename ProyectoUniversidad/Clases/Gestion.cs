using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libreria
{
    class Gestion
    {
        private int idgestion;
        private string nombregestion;
        public int Idgestion
        {
            get
            {
                return idgestion;
            }

            set
            {
                idgestion = value;
            }
        }

        public string Nombregestion
        {
            get
            {
                return nombregestion;
            }

            set
            {
                nombregestion = value;
            }
        }
    }
}
