using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    internal class Persona
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }

        public Persona() { }

        public  Persona(string nombre, int edad)
        {
            Nombre = nombre;
            Edad = edad;
        }

        /// /Metodo que puede modificarse o personaliZarce en futuras subclases
        //(override o sobreescritura de metodos)
        public virtual void Saludar()
        {
            Console.WriteLine("Holis, mi nombre es {0}", Nombre);
        }

        public override string ToString()
        {
            return string.Format("{0}, {1} años", Nombre, Edad);
        }

    }
}
