using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio5
{
    public class Jugada
    {
        private bool m_adivino;

        private int m_intentos;

        private int m_numero;

        public Jugada(int minNumero, int maxNumero)
        {
            Random rnd = new Random();
            Numero = rnd.Next(minNumero, maxNumero);
        }

        public bool Adivino
        {
            get => m_adivino;
            set
            {
                m_adivino = value;
            }
        }

        public int Intentos
        {
            get => m_intentos;
            set
            {
                m_intentos = value;
            }
        }

        public int Numero
        {
            get => m_numero;
            set
            {
                m_numero = value;
            }

        }

        public void Comparar(int num)
        {
            Adivino = (num == Numero);

            Intentos += 1;
        }
    }
}