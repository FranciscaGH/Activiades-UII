using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.modelo.cinema
{
    class Taquillero : Persona
    {
        private int _numeroEmpleado;
        private string _tipo;

        public Taquillero() : base ()
        {
            _numeroEmpleado = 100;
        }

        public int NumeroEmpleado { get; set; }
        public string Tipo { get; set; }

    }
}
