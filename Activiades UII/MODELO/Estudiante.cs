using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activiades_UII.MODELO
{
    class Estudiante
    {
        public byte edad { get; set; }
        public string genero { get; set; }
        public string nombre { get; set; }
        public long numeroControl { get; set; }

        public void Estudiar(string texto)
        {
            //metodo para estudiar
        }
        public void HacerTarea(string texto)
        {
            //metodo que hace tarea

        }//fin del metodo
    }
}