﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Activiades_UII.VISTA;
namespace Activiades_UII
{
    static class Program
    {
       
        public static Principal formaPrincipal = null;
        public static FormCampeonato formaCampeonato = null;
        public static FormJornada formaJornada = null;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
           
            formaCampeonato = new FormCampeonato();
            formaJornada = new FormJornada();
            formaPrincipal = new VISTA.Principal();
            Application.Run(new Principal());
        }
    }
}
