using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activiades_UII.MODELO.campeonato
{
    class Equipo
    {
        //propiedades del equipo
        private int _id;
        private string _nombre;
        private string _entrenador;
        private string _comunidad;
        private string _categoria;

        //Enlace con jugador
        private List<Jugador> jugadores = new List<Jugador>();

        //Métodos Getter´s y Setter´s
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Entrenador { get; set; }
        public string Comunidad { get; set; }
        public string Categoria { get; set; }



    }
}
