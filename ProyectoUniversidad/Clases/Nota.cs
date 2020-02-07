using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libreria
{
    class Nota
    {
        private int codigoestudiante;
        private int sede;
        private int carrera;
        private int semestre;
        private int materia;
        private int primerparcial;
        private int segundoparcial;
        private int evaluacionproyecto;
        private int examenfinal;
        private int segundoturno;
        private int notafinal;

        public int Primerparcial
        {
            get
            {
                return primerparcial;
            }

            set
            {
                primerparcial = value;
            }
        }

        public int Segundoparcial
        {
            get
            {
                return segundoparcial;
            }

            set
            {
                segundoparcial = value;
            }
        }

        public int Evaluacionproyecto
        {
            get
            {
                return evaluacionproyecto;
            }

            set
            {
                evaluacionproyecto = value;
            }
        }

        public int Examenfinal
        {
            get
            {
                return examenfinal;
            }

            set
            {
                examenfinal = value;
            }
        }

        public int Segundoturno
        {
            get
            {
                return segundoturno;
            }

            set
            {
                segundoturno = value;
            }
        }

        public int Notafinal
        {
            get
            {
                return notafinal;
            }

            set
            {
                notafinal = value;
            }
        }

        public int Codigoestudiante
        {
            get
            {
                return codigoestudiante;
            }

            set
            {
                codigoestudiante = value;
            }
        }

        public int Carrera
        {
            get
            {
                return carrera;
            }

            set
            {
                carrera = value;
            }
        }

        public int Semestre
        {
            get
            {
                return semestre;
            }

            set
            {
                semestre = value;
            }
        }

        public int Materia
        {
            get
            {
                return materia;
            }

            set
            {
                materia = value;
            }
        }

        public int Sede
        {
            get
            {
                return sede;
            }

            set
            {
                sede = value;
            }
        }
    }
}
