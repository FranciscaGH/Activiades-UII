using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.modelo.cinema
{
    class Pelicula
    {
        private int _numero;
        private string _nombre;
        private string _director;
        private string _clasificacion;
        private string _resumen;


        public int Numero
        {
            get
            {
                return _numero;
            }
            set
            {
                _numero = value;
            }
        }


        public string Nombre
        {
            get
            {
                return _nombre;
            }

            set
            {
                _nombre= value;
            }
        }

        public string Director
        {
            get
            {
                return _director;
            }

            set
            {
                _director = value;
            }
        }

        public string Clasificacion
        {
            get
            {
                return _clasificacion;
            }

            set
            {
                _clasificacion = value;
            }
        }


        public string Resumen
        {
            get
            {
                return _resumen;
            }

            set
            {
                _resumen = value;
            }
        }




    }
}
