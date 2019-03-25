using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activiades_UII.MODELO.campeonato
{
    class Campeonato
    {
        //propiedades del equipo
        private int _id;
        private string _nombre;
        private DateTime _fechaInicio ;
        private DateTime _fechaTermino;
        

        //Enlace con jornada
        private List<Jornada> jornada = new List<Jornada>();

        //Métodos Getter´s y Setter´s
        public int Id { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaTermino { get; set; }
        
    }
}
