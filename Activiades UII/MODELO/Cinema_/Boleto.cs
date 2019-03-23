using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.modelo.cinema
{
    class Boleto
    {
        private long _folio;
        private DateTime _fecha;
        private int _asiento;
        private double _costo;

        public long Folio { get; set; }
        public DateTime Fecha { get; set; }
        public int Asiento { get; set; }

        public double Costo { get; set; }
    }
}
