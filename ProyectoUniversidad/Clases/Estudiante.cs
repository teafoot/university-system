using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libreria
{
    class Estudiante
    {
        private string nombre;
        private string apellidopaterno;
        private string apellidomaterno;
        private int sexo;
        private int carnetidentidad;
        private DateTime fechanacimiento;
        private string paisnacimiento;
        private string direccion;
        private int telefono;
        private string email;

        public string Nombre
        {
            get
            {
                return nombre;
            }

            set
            {
                nombre = value;
            }
        }

        public string Apellidopaterno
        {
            get
            {
                return apellidopaterno;
            }

            set
            {
                apellidopaterno = value;
            }
        }

        public int Carnetidentidad
        {
            get
            {
                return carnetidentidad;
            }

            set
            {
                carnetidentidad = value;
            }
        }

        public DateTime Fechanacimiento
        {
            get
            {
                return fechanacimiento;
            }

            set
            {
                fechanacimiento = value;
            }
        }

        public string Paisnacimiento
        {
            get
            {
                return paisnacimiento;
            }

            set
            {
                paisnacimiento = value;
            }
        }

        public string Direccion
        {
            get
            {
                return direccion;
            }

            set
            {
                direccion = value;
            }
        }

        public int Telefono
        {
            get
            {
                return telefono;
            }

            set
            {
                telefono = value;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
            }
        }

        public string Apellidomaterno
        {
            get
            {
                return apellidomaterno;
            }

            set
            {
                apellidomaterno = value;
            }
        }

        public int Sexo
        {
            get
            {
                return sexo;
            }

            set
            {
                sexo = value;
            }
        }
    }
}
