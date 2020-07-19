using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio02
{
    class Program
    {
        /*
            Crear un programa que acepte una lista de números, los almacene en un objeto del tipo List<int>;
            y luego usando LINQ muestre por Consola aquellos que son mayores a 20.
         */


        static void Main(string[] args)
        {
            List<int> numeros = new List<int> { };
            bool sigue;
            do
            {
                Console.Clear();
                int numero;
                Console.WriteLine("Ingrese un numero para anadir a la lista: ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out numero))
                {
                    numeros.Add(numero);
                } else
                {
                    Console.WriteLine("Numero no valido.");
                    Console.ReadKey();
                }


                Console.WriteLine("Desea anadir otro? S para seguir, cualquier tecla para terminar de ingresar. ");

                string input2 = Console.ReadLine();

                sigue = input2.ToUpper() == "S";


            } while (sigue);

            IEnumerable<int> numerosFiltrados = from n in numeros
                                                where n > 20
                                                select n;

            Console.Clear();
            Console.WriteLine("Estos son los numeros que ingresaste mayores a 20:" );

            foreach(int num in numerosFiltrados)
            {
                Console.WriteLine(num);
            }

            Console.ReadKey();
        }
    }
}
