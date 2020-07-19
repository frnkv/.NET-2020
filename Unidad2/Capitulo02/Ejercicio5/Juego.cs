using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5
{
    public class Juego
    {
        private int m_record;

        private int m_maximo;

        private int m_minimo;

        private Jugada jugada;

        public Juego()
        {
        }

        private Jugada Jugada { get => jugada; set => jugada = value; }
        private int Maximo { get => m_maximo; set => m_maximo = value; }
        private int Minimo { get => m_minimo; set => m_minimo = value; }
        private int Record { get => m_record; set => m_record = value; }

        /*
2)	Juego debe tener un único método publico, ComenzarJuego(), llamado desde el main de la aplicación. 
Se debe encargar de mostrar mensajes al usuario, 
permitir realizar otra partida, 
llevar un control de record de menor cantidad de intentos para un acierto, etc.
3)	Jugada debe generar, en el constructor, 
el número a adivinar, a partir de un máximo, para esto, se utilizará como constructor:

*/
        public void ComenzarJuego()
        {
            bool seguirJugando = true;
            do
            {
                Console.WriteLine("Ingrese numero minimo: ");
                Minimo = int.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese numero maximo para comenzar el juego: ");
                Maximo = int.Parse(Console.ReadLine());

                Jugada = new Jugada(Minimo, Maximo);

                Console.Clear();

                int opcion;
                do
                {
                    Console.WriteLine("ADIVINE EL NUMERO RANDOM GENERADO!!!" + Environment.NewLine);

                    Console.WriteLine("Ingrese opcion:" + Environment.NewLine +
                        "1- Comparar Record" + Environment.NewLine +
                        "2- Preguntar Maximo" + Environment.NewLine +
                        "3- Preguntar Minimo" + Environment.NewLine +
                        "4- Ingresar numero para probar suerte!!" + Environment.NewLine +
                        "5- Comenzar de nuevo" + Environment.NewLine +
                        "6- Salir" + Environment.NewLine);

                    opcion = int.Parse(Console.ReadLine());

                    Console.Clear();
                    switch (opcion)
                    {
                        case 1:
                            string mensaje = CompararRecord() ? "No mejoraste tu record! :(" : "Superaste tu record!!";
                            Console.WriteLine(mensaje);
                            break;
                        case 2:
                            Console.WriteLine("El numero maximo es: " + PreguntarMaximo());
                            break;
                        case 3:
                            Console.WriteLine("El numero minimo es: " + PreguntarMinimo());
                            break;
                        case 4:
                            Console.WriteLine("Ingrese numero: ");
                            int numero = int.Parse(Console.ReadLine());

                            Jugada.Comparar(numero);

                            if (Jugada.Adivino)
                            {
                                Console.WriteLine("ADIVINASTE!!");
                                Record = Jugada.Intentos;
                            } else
                            {
                                Console.WriteLine("Mala suerte, intenta nuevamente!!");
                            }

                            break;
                    }
                    Console.ReadKey();
                } while (opcion < 5);

                if (opcion == 6)
                {
                    seguirJugando = false;
                }

            } while (seguirJugando);
        }

        private bool CompararRecord()
        {
            return Jugada.Intentos > Record;
        }

        private void Continuar()
        {
            throw new System.NotImplementedException();
        }

        private int PreguntarMaximo()
        {
            return Maximo;
        }

        private int PreguntarMinimo()
        {
            return Minimo;
        }
    }
}
