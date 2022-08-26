using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    internal class Estudiante : Persona
    {
        public double Promedio { get; set; }
        public string Grado { get; set; }

        public Estudiante(string nombre, int edad, double promedio, string grado) : base(nombre, edad)
        {
            Promedio = promedio;
            Grado = grado;
        }

        public override void Saludar()
        {
            Console.WriteLine("Hola, mi nombre es {0} y estoy en el grado {1}", Nombre, Grado);
        }

        public void Estudiar()
        {
            Console.WriteLine("{0} esta estudiando...", Nombre);
        }

        public void IrAClase()
        {
            Console.WriteLine("{0} va a clases en el salon del grado {1}", Nombre, Grado);
        }

        public override string ToString()
        {
            return String.Format("{0}, tiene {1} años, esta en el grado {2} y su promedio es {3}", Nombre, Edad, Grado, Promedio);
        }
    }
}
