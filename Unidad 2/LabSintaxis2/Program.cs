using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabSintaxis2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un texto");
            string inputTexto = Console.ReadLine();

            if (inputTexto != "")
            {
                muestraMenu(inputTexto);
            }
            else
            {
                Console.Clear();
                Console.WriteLine("¡ERROR! Debe ingresar un texto.");
            }
            Console.ReadKey();
        }

        private static void muestraMenu(string inputTexto)
        {
            Console.Clear();

            Console.Write("Ingrese una opcion:" + Environment.NewLine +
                "1- Mostrar en mayúsculas" + Environment.NewLine +
                "2- Mostrar en minúsculas" + Environment.NewLine +
                "3- Mostrar cantidad de caracteres" + Environment.NewLine);

            ConsoleKeyInfo opcion = Console.ReadKey();

            if (esOpcionValida(opcion))
            {
                muestraRespuestaMenu(opcion, inputTexto);
            }
            else
            {
                Console.Clear();
                Console.WriteLine("¡ERROR! Debe ingresar una opción válida.");
            }
        }

        private static bool esOpcionValida(ConsoleKeyInfo opcion)
        {
            return opcion.Key == ConsoleKey.D1 || opcion.Key == ConsoleKey.NumPad1 || // verifico numpad 1 y 1 comun
                opcion.Key == ConsoleKey.D2 || opcion.Key == ConsoleKey.NumPad2 || // verifico numpad 2 y 2 comun
                opcion.Key == ConsoleKey.D3 || opcion.Key == ConsoleKey.NumPad3; // verifico numpad 3 y 3 comun
        } 

        private static void muestraRespuestaMenu(ConsoleKeyInfo opcion, string texto)
        {
            Console.Clear();
            Console.Write("El resultado es: ");
            switch (opcion.Key)
            {
                case ConsoleKey.D1:
                case ConsoleKey.NumPad1:
                    Console.Write(texto.ToUpper());
                    break;
                case ConsoleKey.D2:
                case ConsoleKey.NumPad2:
                    Console.Write(texto.ToLower());
                    break;
                case ConsoleKey.D3:
                case ConsoleKey.NumPad3:
                    Console.Write(texto.Length);
                    break;
            }
        }
    }
}
