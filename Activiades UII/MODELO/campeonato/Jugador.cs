using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activiades_UII.MODELO.campeonato
{
    class Jugador:Persona
    {
        //Propiedades de la clase
        private string _equipo;
        private int _num;
        private string _posicion;

        //Enlace con la clase Equipo
        private Equipo _equipe;

        //Métodos Getter´s y Setter´s
        public string Equipo{ get; set; }
        public int Num { get; set; }
        public int Posicion{ get; set; }
        public Equipo Equipe { get; set; }
    }
}
