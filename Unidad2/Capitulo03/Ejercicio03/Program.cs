using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio03
{
    class Program
    {
        /*
            Dado un ArrayList que incluya al menos 10 Ciudades de Argentina incluyendo Nombre y Código
            Postal usar LINQ para obtener y mostrar por Consola el Código Postal de aquellas ciudades que
            incluyan dentro de su nombre una expresión de busqueda de tres caracteres, sin respetar
            mayusculas o minusculas. Por ejemplo, si se ingresa “ros” y el ArrayList incluye Rosario entonces
            debe mostrarse el Código Postal de Rosario. 
             
        */
        static void Main(string[] args)
        {
            ArrayList ciudades = new ArrayList();

            ciudades.Add(new Ciudad("Rosario", 2000));
            ciudades.Add(new Ciudad("Venado Tuerto", 2600));
            ciudades.Add(new Ciudad("Pergamino", 2700));
            ciudades.Add(new Ciudad("La Plata", 1900));
            ciudades.Add(new Ciudad("Salta", 4400));
            ciudades.Add(new Ciudad("Villa Carlos Paz", 5152));
            ciudades.Add(new Ciudad("San Carlos de Bariloche", 8400));
            ciudades.Add(new Ciudad("Mendoza", 5500));
            ciudades.Add(new Ciudad("Santa Fe", 3000));
            ciudades.Add(new Ciudad("Ceres", 2340));

            string input;
            do
            {
                Console.Clear();
                Console.WriteLine("Ingrese no mas de 3 caracteres para la busqueda.");
                input = Console.ReadLine();

            } while (input.Length == 2);

            ArrayList ciudadesFiltradas = new ArrayList();
            foreach (Ciudad ciudad in ciudades)
            {
                if (ciudad.Nombre.ToLower().IndexOf(input.ToLower()) > -1)
                {
                    ciudadesFiltradas.Add(ciudad);
                }
            }

            Console.WriteLine("Encontramos los siguientes codigos postales:");

            foreach(Ciudad ciudad in ciudadesFiltradas)
            {
                Console.WriteLine("Codigo postal: " + ciudad.CodPostal);
            }

            Console.ReadKey();

        }
    }

    class Ciudad
    {
        private string m_nombre;

        private int m_codPostal;

        public Ciudad(string nombre, int codPostal)
        {
            Nombre = nombre;
            CodPostal = codPostal;
        }

        public string Nombre { get => m_nombre; set => m_nombre = value; }
        public int CodPostal { get => m_codPostal; set => m_codPostal = value; }
    }
}
