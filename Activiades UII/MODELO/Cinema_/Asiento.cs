using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.modelo.cinema
{
    class Asiento
    {
        private int _numero;
        private bool _estaDisponible;

        public Asiento()
        {
            _numero = 1;
            _estaDisponible = false;
        }
        public Asiento(int num,bool disponible)
        {
            _numero = num;
            _estaDisponible = disponible;

        }
        public int Numero { get; set; }
        public bool EstaDisponible { get; set; }

    }
}
