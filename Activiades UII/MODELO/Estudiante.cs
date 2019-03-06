using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activiades_UII.MODELO
{
    class Estudiante
    {
        public string nombre;
        public byte edad;
        public char genero;
        public long numeroControl;

        public byte Edad { get; set; }
        public char Genero { get; set; }
        public string Nombre { get; set; }
        public long NumeroControl { get; set; }

        public void Estudiar(string texto)
        {
            return;
            //metodo para estudiar
        }
        public void HacerTarea(string texto)
        {
            return;
            //metodo que hace tarea

        }//fin del metodo
    }
}