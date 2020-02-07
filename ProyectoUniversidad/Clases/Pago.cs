using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libreria
{
    class Pago
    {
        private int idpago;
        private string nombrepago;

        public int Idpago
        {
            get
            {
                return idpago;
            }

            set
            {
                idpago = value;
            }
        }

        public string Nombrepago
        {
            get
            {
                return nombrepago;
            }

            set
            {
                nombrepago = value;
            }
        }
    }
}
