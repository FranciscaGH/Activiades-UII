using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activiades_UII.MODELO.campeonato
{
    class Cancha
    {
        //Propiedades de la clase
        private int _id;
        private string _nombre;
        private string _ubicaciòn;
        private string _tipo;//soccer,futbol 7

        //Mètodos Getter's y Setter's
        public int Id { get; set; }
        public string Tipo { get; set; }
        public string Nombre { get; set; }
        public string Ubicacion { get; set; }
        
    }
}
