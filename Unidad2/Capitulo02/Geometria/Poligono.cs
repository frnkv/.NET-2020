using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Geometria
{
    public class Poligono
    {
        private int m_base;

        private int m_altura;

        public int Base { get => m_base; set => m_base = value; }
        public int Altura { get => m_altura; set => m_altura = value; }

        public int CalcularPerimetro()
        {
            return Base * 2 + Altura * 2;
        }

        public int CalcularSuperficie()
        {
            return Base * Altura;
        }
    }
}