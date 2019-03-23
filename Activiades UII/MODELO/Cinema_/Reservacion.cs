using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.modelo.cinema
{
    class Reservacion
    {
        private DateTime _fecha;
        private string _numeroTargeta;

        public DateTime Fecha { get; set; }
        public string NumeroTargeta { get; set; }
    }
}
