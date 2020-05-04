using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosParaPensar
{
    class Program
    {

        string[] meses = new string[] {
                "enero",
                "febrero",
                "marzo",
                "abril",
                "mayo",
                "junio",
                "julio",
                "agosto",
                "septiembre",
                "octubre",
                "noviembre",
                "diciembre",
        };

        Dictionary<string, Int16> numerosRomanos = new Dictionary<string, Int16> {
            { "M", 1000 },
            { "C", 100 },
            { "L", 50 },
            { "X", 10 },
            { "V", 5 },
            { "D", 500 },
            { "I", 1 },
        };

        static void Main(string[] args)
        {
            Program ejercicio = new Program();
            
            ConsoleKeyInfo opcion = ejercicio.MuestraMenu();

            ejercicio.MuestraEjercicio(opcion);

            Console.ReadKey();
        }


        ConsoleKeyInfo MuestraMenu()
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

                teclaValida = ValidarTecla(keyPressed);

            } while (!teclaValida);

            return keyPressed;
        }

        void MuestraEjercicio(ConsoleKeyInfo opcion)
        {
            Console.Clear();
            switch (opcion.Key)
            {
                case ConsoleKey.D1:
                case ConsoleKey.NumPad1:
                    SumaDosNumeros();
                    break;
                case ConsoleKey.D2:
                case ConsoleKey.NumPad2:
                    VerificarAnioBisiesto();
                    break;
                case ConsoleKey.D3:
                case ConsoleKey.NumPad3:
                    SerieFibonacci();
                    break;
                case ConsoleKey.D4:
                case ConsoleKey.NumPad4:
                    NumerosPares();
                    break;
                case ConsoleKey.D5:
                case ConsoleKey.NumPad5:
                    NumeroMes();
                    break;
                case ConsoleKey.D6:
                case ConsoleKey.NumPad6:
                    NumerosRomanos();
                    break;
                case ConsoleKey.D7:
                case ConsoleKey.NumPad7:
                    NumerosPrimosGemelos();
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

        void SumaDosNumeros()
        {
            Console.WriteLine("Construir una aplicación que sume dos números y proporcione el resultado con el formato siguiente: " +
                "El resultado de la suma de < número uno > y < número dos > es < resultado >." + Environment.NewLine);

            int[] numeros = new int[2];

            for (int i = 1; i < 3; i++)
            {
                int numero = DevuelveNumero("numero " + i);

                numeros[(i - 1)] = numero;
            }

            Console.Write(Environment.NewLine + "El resultado de la suma de " + numeros[0] + " y " + numeros[1] + " es " + (numeros[0] + numeros[1]));
        }

        void VerificarAnioBisiesto()
        {
            Console.Write("Verificar anio bisiesto." + Environment.NewLine +
                "Observación: Un año es bisiesto si es divisible por 4, excepto el último de cada siglo (aquel divisible por 100)," +
                " salvo que éste último sea divisible por 400." + Environment.NewLine +
                "Es decir los años que sean divisibles por 4 serán bisiestos; " + Environment.NewLine +
                "aunque no serán bisiestos si son divisibles entre 100 (como los años 1700, 1800, 1900 y 2100)" + Environment.NewLine +
                " a no ser que sean divisibles por 400 (como los años 1600, 2000 ó 2400))" + Environment.NewLine);

            int anio = DevuelveNumero("anio");

            if ((anio % 100 == 0 && anio % 400 == 0) || (anio % 4 == 0 && anio % 100 != 0))
            {
                Console.WriteLine("El anio " + anio + " es bisiesto.");
            } else
            {
                Console.WriteLine("El anio " + anio + " no es bisiesto.");
            }
        }

        void SerieFibonacci()
        {
            Console.Write("Serie de Fibonacci, debe ingresar la cantidad de numeros, es decir:" + Environment.NewLine +
                "Si ingresa 3, se le mostrara -> 0, 1, 1" + Environment.NewLine + Environment.NewLine);

            int cantidadNumeros = DevuelveNumero("cantidad de numeros a mostrar");
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

        void NumerosPares()
        {
            Console.Write("Escribe todos los numeros pares del 0 al 100" + Environment.NewLine);

            string numPares = "";

            for (int i = 0; i < 101; i += 2)
            {
                numPares = numPares + i + ", ";
            }

            Console.Write(numPares);
        }
        
        void NumeroMes()
        {
            Console.Write("Construir una aplicación que reciba el nombre de un mes del año como el parámetro" +
                " y proporcione su número correspondiente. " + Environment.NewLine +
                "Debe ser con el formato: < Nombre del mes > + < número del mes >." + Environment.NewLine);

            Console.Write("Ingrese mes: ");

            string texto = Console.ReadLine();

            int numero = 0;

            if (MesValido(texto))
            {
                numero = ObtenerNumeroMes(texto);

                Console.WriteLine("< " + texto + " >" + "< " + numero + " >");
            }

        }

        void NumerosRomanos()
        {
            Console.WriteLine("Dado un número entero, que se convierta a número romano. (Regla: numero menor o igual a 3000)" + Environment.NewLine);

            int numeroInput;
            do
            {
                numeroInput = DevuelveNumero("numero para ser convertido");
            } while (numeroInput > 3000);

            string numRomano = "";

            foreach (KeyValuePair<string, Int16> pair in numerosRomanos.OrderByDescending(pair => pair.Value))
            {
                int cociente = numeroInput / pair.Value; // cociente
                int resto = numeroInput % pair.Value; // resto
                if (cociente > 0)
                {
                    for (int i = 0; i < cociente; i++)
                    {
                        numRomano = numRomano + pair.Key;
                    }

                    numeroInput = resto;
                }
            }

            Console.WriteLine("Numero romano: " + numRomano);
        }

        void NumerosPrimosGemelos()
        {
            Console.Write("Calcular los N primeros números primos gemelos." + Environment.NewLine + Environment.NewLine +
                "Dos números primos se denominan gemelos si uno de ellos es igual al otro más dos unidades." + Environment.NewLine +
                "Así pues, los números primos 3 y 5 forman una pareja de primos gemelos." + Environment.NewLine);

            int num = DevuelveNumero("cantidad maxima de numeros a evaluar" + Environment.NewLine);

            List<int> listNumerosPrimos = new List<int>();

            for (int i = num; i > 0; i--)
            {
                List<int> listDivisores = new List<int>();
                for (int j = 1; j <= i; j++)
                {
                    int resto = i % j;
                    if (resto == 0)
                    {
                        listDivisores.Add(j);
                    }
                }

                if (listDivisores.ToArray().Length == 2)
                {
                    listNumerosPrimos.Add(i);
                }
            }

            List<int> listNumerosPrimosGemelos = new List<int>();
            listNumerosPrimos.Reverse();

            int[] arrayNumerosPrimos = listNumerosPrimos.ToArray();

            for(int i = 0; i < arrayNumerosPrimos.Length; i++)
            {

                Console.WriteLine(arrayNumerosPrimos[i]);

                if (arrayNumerosPrimos.Last() != arrayNumerosPrimos[i])
                {
                    Console.WriteLine(arrayNumerosPrimos[++i]);

                    if (arrayNumerosPrimos[i] + 2 == arrayNumerosPrimos[++i])
                    {
                        listNumerosPrimosGemelos.Add(arrayNumerosPrimos[i]);
                    }

                } else if (listNumerosPrimosGemelos.Contains(arrayNumerosPrimos[i] - 2))
                {
                    listNumerosPrimosGemelos.Add(arrayNumerosPrimos[i]);
                }
            }


            Console.WriteLine("Lista numeros primos gemelos dentro de " + num + ":" + Environment.NewLine);

            for (int i = 0; i < listNumerosPrimosGemelos.ToArray().Length; i++)
            {
                Console.WriteLine(listNumerosPrimosGemelos.ToArray()[i]);
            }

            Console.ReadLine();
        }

        bool MesValido(string texto)
        {
            string input = texto.ToLower();

            bool resultado = meses.Contains(input);

            if (!resultado)
            {
                Console.WriteLine("Mes no valido.");
            }

            return resultado;
        }

        int ObtenerNumeroMes(string mes)
        {
            return Array.FindIndex(meses, (m) => m == mes) + 1;
        }

        bool ValidarTecla(ConsoleKeyInfo opcion)
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
        int DevuelveNumero(string mensaje)
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
