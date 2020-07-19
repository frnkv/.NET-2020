using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    /*
     •	Un constructor que reciba la información necesaria para iniciar la instancia y que 
     proporcione un mensaje que indique la creación del objeto.
•	Un destructor que proporcione un mensaje que indique la destrucción del objeto.
•	Las propiedades correspondientes para acceder a cada uno de los atributos de la clase.
•	Un método GetFullName, el cual debe devolver la concatenación del nombre y apellido.
•	Un método GetAge, para calcular la edad de la persona.
*/
    public class Persona
    {
        private string m_nombre;

        private string m_apellido;

        private DateTime m_edad;

        private int m_dni;

        Persona(string nombre, string apellido, DateTime edad, int dni) {
            Nombre = nombre;
            Apellido = apellido;
            Edad = edad;
            Dni = dni;

            Console.WriteLine("Se creo la instancia persona.");
        }

        ~Persona()
        {
            Console.WriteLine("Se destruye el objeto");
        }

        public int Dni { get => m_dni; set => m_dni = value; }
        public DateTime Edad { get => m_edad; set => m_edad = value; }
        public string Apellido { get => m_apellido; set => m_apellido = value; }
        public string Nombre { get => m_nombre; set => m_nombre = value; }

        public string GetFullName()
        {
            return Nombre + ' ' + Apellido;
        }

        public int getAge()
        {
            return (DateTime.Now - Edad).Days / 365;
        }
    }
}
