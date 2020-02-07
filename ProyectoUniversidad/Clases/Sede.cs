using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libreria
{
    class Sede
    {
        private int idsede;
        private string nombresede;

        public int Idsede
        {
            get
            {
                return idsede;
            }

            set
            {
                idsede = value;
            }
        }

        public string Nombresede
        {
            get
            {
                return nombresede;
            }

            set
            {
                nombresede = value;
            }
        }
    }
}
