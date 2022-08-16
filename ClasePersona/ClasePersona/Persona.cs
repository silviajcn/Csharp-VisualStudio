using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasePersona
{
    internal class Persona
    {
        public string Nombre { get; set;}
        public string Apellido { get; set; }

        private int _edad;
        public int Edad {
            get {
                return _edad;
            }
            set { 
                _edad = value >= 0 ? value : 0;
            }
        }

        //Constructores:

        public Persona()
        {
        }

        public Persona(string nombre)
        {
            Nombre = nombre;
        }

        public Persona(string nombre, string apellido) : this(nombre)
        {
            Apellido = apellido;
        }

        public Persona(string nombre, string apellido, int edad) : this(nombre, apellido)
        {
            Edad = edad;
        }

        public void Saludar()
        {
            Console.WriteLine("Hola, mi nombre es {0} {1}", Nombre, Apellido);
        }

        public override string ToString()
        {
            return string.Format("Nombre: {0}, Apellido: {1}, Edad: {2}", Nombre, Apellido, Edad);
        }

    }
}
