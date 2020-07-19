using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio01
{
    /*
        Dado un Array que incluya todas las Provincias de Argentina usar LINQ para obtener y mostrar
        por Consola aquellas provincias que empiezan con la letra “S” o “T”
    */
    class Program
    {

        static void Main(string[] args)
        {
            string[] provincias = new string[] {
                "Buenos Aires",
                "Catamarca",
                "Chaco",
                "Chubut",
                "Cordoba",
                "Corrientes",
                "Entre Rios",
                "Formosa",
                "Jujuy",
                "La Pampa",
                "La Rioja",
                "Mendoza",
                "Misiones",
                "Neuquen",
                "Rio Negro",
                "Salta",
                "San Juan",
                "San Luis",
                "Santa Cruz",
                "Santa Fe",
                "Santiago del Estero",
                "Tierra del Fuego",
                "Tucuman"
            };

            IEnumerable<string> provinciasFiltradas = from p in provincias
                                      where p.ToLower().StartsWith("s") ||p.ToLower().StartsWith("t")
                                      select p;

            foreach (string p in provinciasFiltradas)
            {
                Console.WriteLine(p);
            }

            Console.ReadKey();
            
        }
    }
}
