using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activiades_UII.MODELO.campeonato
{
    class Jornada
    {//propiedades del equipo
        private int _id;
        private DateTime _fechaInicio;
        private DateTime _fechaTermino;
        private bool _isCocluida;

       

        //Métodos Getter´s y Setter´s
        public int Id { get; set; }
       
        public DateTime FechaInicio { get; set; }
        public DateTime FechaTermino { get; set; }
        public bool IsConcluida { get; set; }

    }
}
