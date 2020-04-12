using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabSintaxis3
{
    /*
     1)	Crear una nueva aplicación de consola, llamada LabSintaxis3
     2)	Crear un array de strings, las posiciones se determinarán por la variable cantIteraciones, un entero al que se le asignaran 5 posiciones. Luego, siempre se utilizara la misma variable
     3)	Crear un ciclo for para ingresar cada una de las posiciones.

     for (int i = 0; i < cantIteraciones; i++)
     
     4)	Crear un ciclo for para mostrar por pantalla cada una de las posiciones, una por línea, comenzando desde la última que se ingreso, hasta la primera.
     5)	Ejecutar la aplicación.
     
    */
    class Program
    {
        static void Main(string[] args)
        {
            int cantIteraciones;
            string[] valores;

            cantIteraciones = obtenerCantidadIteraciones();

            valores = rellenarArreglo(cantIteraciones);

            muestraArrayInverso(valores);

            Console.ReadKey();
        }

        /// <summary>
        /// Retorna cantidad de operaciones que quiere el cliente
        /// </summary>
        /// <returns>int</returns>
        private static int obtenerCantidadIteraciones()
        {
            string input;
            int cantIteraciones;

            do
            {
                Console.Clear();
                Console.Write("Escriba la cantidad de iteraciones: ");

                input = Console.ReadLine();

                if (!int.TryParse(input, out _))
                {
                    Console.WriteLine("El valor ingresado debe ser un numero");
                    Console.ReadKey();
                }

            } while (!int.TryParse(input, out cantIteraciones));

            return cantIteraciones;
        }

        /// <summary>
        /// Retorna el arreglo de string con sus respectivos valores
        /// </summary>
        /// <param name="iteraciones"></param>
        /// <returns>string[]</returns>
        private static string[] rellenarArreglo(int iteraciones)
        {
            string[] valoresIngresados = new string[iteraciones];

            for (int i = 0; i < iteraciones; i++)
            {
                Console.Write("Ingrese un valor para el arreglo en la posicion " + i + ": ");
                valoresIngresados[i] = Console.ReadLine();
            }

            return valoresIngresados;
        }

        /// <summary>
        /// Muestra array inverso
        /// </summary>
        /// <param name="array"></param>
        private static void muestraArrayInverso(string[] array)
        {
            for (int i = array.Length-1; i > -1; i--)
            {
                Console.WriteLine("Posicion: " + i + " valor: " + array[i]);
            }
        }
    }
}
