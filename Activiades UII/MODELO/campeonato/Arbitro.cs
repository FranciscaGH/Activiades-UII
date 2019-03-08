using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activiades_UII.MODELO.campeonato
{
    class Arbitro:Persona
    {
        //Atributos
        private int _aniosExperencia;
        private bool tieneGafete;
        //Métodos Getter´s y Setter´s
        public int AniosExperiencia { get; set; }
        public bool TieneGafete{ get; set; }
    }
}
