using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosParaPensar
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo opcion = muestraMenu();
            muestraEjercicio(opcion);
            Console.ReadKey();
        }


        private static ConsoleKeyInfo muestraMenu()
        {
            bool teclaValida;
            ConsoleKeyInfo keyPressed;

            do
            {
                Console.Clear();
                Console.Write("Seleccione una opcion del menu" + Environment.NewLine +
                    "1- Ejercicio 1: Suma de dos numeros." + Environment.NewLine +
                    "2- Ejercicio 2: Verificar anio bisiesto." + Environment.NewLine +
                    "3- Ejercicio 3: Suma de Fibonacci" + Environment.NewLine +
                    "4- Ejercicio 4: Numeros pares" + Environment.NewLine +
                    "5- Ejercicio 5: Numero de mes" + Environment.NewLine +
                    "6- Ejercicio 6: Convertir numero entero a romano" + Environment.NewLine +
                    "7- Ejercicio 7: Calcular primeros N numeros primos gemelos" + Environment.NewLine +
                    "8- Ejercicio 8: Algoritmo basado en diagrama" + Environment.NewLine +
                    "9- Ejercicio 9: Triangulo de asteriscos" + Environment.NewLine);

                Console.Write("Opcion: ");

                keyPressed = Console.ReadKey();

                teclaValida = validarTecla(keyPressed);

            } while (!teclaValida);

            return keyPressed;
        }

        private static void muestraEjercicio(ConsoleKeyInfo opcion)
        {
            Console.Clear();
            switch (opcion.Key)
            {
                case ConsoleKey.D1:
                case ConsoleKey.NumPad1:
                    sumaDosNumeros();
                    break;
                case ConsoleKey.D2:
                case ConsoleKey.NumPad2:
                    verificarAnioBisiesto();
                    break;
                case ConsoleKey.D3:
                case ConsoleKey.NumPad3:
                    serieFibonacci();
                    break;
                case ConsoleKey.D4:
                case ConsoleKey.NumPad4:
                    numerosPares();
                    break;
                case ConsoleKey.D5:
                case ConsoleKey.NumPad5:
                    Console.Write("Opcion no desarrollada.");
                    break;
                case ConsoleKey.D6:
                case ConsoleKey.NumPad6:
                    Console.Write("Opcion no desarrollada.");
                    break;
                case ConsoleKey.D7:
                case ConsoleKey.NumPad7:
                    Console.Write("Opcion no desarrollada.");
                    break;
                case ConsoleKey.D8:
                case ConsoleKey.NumPad8:
                    Console.Write("Opcion no desarrollada.");
                    break;
                case ConsoleKey.D9:
                case ConsoleKey.NumPad9:
                    Console.Write("Opcion no desarrollada.");
                    break;
            }
        }

        private static void sumaDosNumeros()
        {
            Console.WriteLine("Construir una aplicación que sume dos números y proporcione el resultado con el formato siguiente: " +
                "El resultado de la suma de < número uno > y < número dos > es < resultado >." + Environment.NewLine);

            int[] numeros = new int[2];

            for (int i = 1; i < 3; i++)
            {
                int numero = devuelveNumero("numero " + i);

                numeros[(i - 1)] = numero;
            }

            Console.Write(Environment.NewLine + "El resultado de la suma de " + numeros[0] + " y " + numeros[1] + " es " + (numeros[0] + numeros[1]));
        }

        private static void verificarAnioBisiesto()
        {
            Console.Write("Verificar anio bisiesto." + Environment.NewLine +
                "Observación: Un año es bisiesto si es divisible por 4, excepto el último de cada siglo (aquel divisible por 100)," +
                " salvo que éste último sea divisible por 400." + Environment.NewLine +
                "Es decir los años que sean divisibles por 4 serán bisiestos; " + Environment.NewLine +
                "aunque no serán bisiestos si son divisibles entre 100 (como los años 1700, 1800, 1900 y 2100)" + Environment.NewLine +
                " a no ser que sean divisibles por 400 (como los años 1600, 2000 ó 2400))" + Environment.NewLine);

            int anio = devuelveNumero("anio");

            if ((anio % 100 == 0 && anio % 400 == 0) || (anio % 4 == 0 && anio % 100 != 0))
            {
                Console.WriteLine("El anio " + anio + " es bisiesto.");
            } else
            {
                Console.WriteLine("El anio " + anio + " no es bisiesto.");
            }
        }

        private static void serieFibonacci()
        {
            Console.Write("Serie de Fibonacci, debe ingresar la cantidad de numeros, es decir:" + Environment.NewLine +
                "Si ingresa 3, se le mostrara -> 0, 1, 1" + Environment.NewLine + Environment.NewLine);

            int cantidadNumeros = devuelveNumero("cantidad de numeros a mostrar");
            string mensajeAMostrar = "";

            int antePenultimo = 0;
            int penultimo = 1;

            for (int i = 0; i < cantidadNumeros; i++)
            {
                if (i == 0)
                {
                    mensajeAMostrar = antePenultimo + ", ";
                } else if (i == 1)
                {
                    mensajeAMostrar = mensajeAMostrar + penultimo + ", ";
                } else
                {
                    int valorAuxiliar = antePenultimo + penultimo;

                    mensajeAMostrar = mensajeAMostrar + valorAuxiliar + ", ";

                    antePenultimo = penultimo;
                    penultimo = valorAuxiliar;
                }
            }

            Console.WriteLine("Serie de Fibonacci a mostrar: " + mensajeAMostrar);
        }

        private static void numerosPares()
        {
            Console.Write("Escribe todos los numeros pares del 0 al 100" + Environment.NewLine);

            string numPares = "";

            for (int i = 0; i < 101; i += 2)
            {
                numPares = numPares + i + ", ";
            }

            Console.Write(numPares);
        }

        private static bool validarTecla(ConsoleKeyInfo opcion)
        {
            return opcion.Key == ConsoleKey.D1 || opcion.Key == ConsoleKey.NumPad1 || // verifico numpad 1 y 1 comun
                opcion.Key == ConsoleKey.D2 || opcion.Key == ConsoleKey.NumPad2 || // verifico numpad 2 y 2 comun
                opcion.Key == ConsoleKey.D3 || opcion.Key == ConsoleKey.NumPad3 || // verifico numpad 3 y 3 comun
                opcion.Key == ConsoleKey.D4 || opcion.Key == ConsoleKey.NumPad4 || // verifico numpad 4 y 4 comun
                opcion.Key == ConsoleKey.D5 || opcion.Key == ConsoleKey.NumPad5 || // verifico numpad 5 y 5 comun
                opcion.Key == ConsoleKey.D6 || opcion.Key == ConsoleKey.NumPad6 || // verifico numpad 6 y 6 comun
                opcion.Key == ConsoleKey.D7 || opcion.Key == ConsoleKey.NumPad7 || // verifico numpad 7 y 7 comun
                opcion.Key == ConsoleKey.D8 || opcion.Key == ConsoleKey.NumPad8 || // verifico numpad 8 y 8 comun
                opcion.Key == ConsoleKey.D9 || opcion.Key == ConsoleKey.NumPad9; // verifico numpad 8 y 8 comun
        }

        /// <summary>
        /// Devuelve numero pos verificacion de entrada, muestra mensaje Ingrese + mensaje enviado por parametro + :
        /// </summary>
        /// <param name="mensaje"></param>
        /// <returns></returns>
        private static int devuelveNumero(string mensaje)
        {
            int numero;
            string input;
            do
            {
                Console.Write("Ingrese " + mensaje+ ": ");
                input = Console.ReadLine();

            } while (!int.TryParse(input, out numero));

            return numero;
        }
    }
}
