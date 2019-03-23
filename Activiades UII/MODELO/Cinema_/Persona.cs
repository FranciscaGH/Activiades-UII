using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.modelo.cinema
{
    class Persona
    {//propiedades de la clase
        protected int _id;
        protected string _nombre;
        protected string _apellidos;
        protected string _domicilio;
        protected string _email;
        protected string _password;


        public Persona()
        {
            _nombre = " Juanito";
            _apellidos = "Pérez";
        }



        public Persona(string nombre, string apellidos)
        {
            _nombre = nombre;
            _apellidos = apellidos;
        }
        public int Id
        {
            get
            {
                return _id;
            }

            set
            {
                if (value > 0)
                _id = value;
            }
        }

        public string Nombre
        {
            get
            {
                return _nombre;
            }

            set
            {
                if (value.Leght >= 3 && value.Leght <= 0)
                    _nombre = value;
            }
        }


        public string Apellidos
        {
            get
            {
                return _apellidos;
            }

            set
            {
                _apellidos = value;
            }
        }

        public string Domicilio
        {
            get
            {
                return _domicilio;
            }

            set
            {
                _domicilio = value;
            }
        }

        public string Email
        {
            get
            {
                return _email;
            }

            set
            {
                _email = value;
            }
        }

        public string Password
        {
            get
            {
                return _password;
            }

            set
            {
                _password = value;
            }
        }


    }
}
